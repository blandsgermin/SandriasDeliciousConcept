IF OBJECT_ID(N'dbo.InventoryStock', N'U') IS NULL
CREATE TABLE dbo.InventoryStock (
    ItemId       INT NOT NULL PRIMARY KEY REFERENCES dbo.Items(ItemId),
    OnHand       DECIMAL(12,2) NOT NULL DEFAULT 0 CHECK (OnHand >= 0),
    ReorderLevel DECIMAL(12,2) NOT NULL DEFAULT 0 CHECK (ReorderLevel >= 0)
);
GO
IF OBJECT_ID(N'dbo.StockReservations', N'U') IS NULL
CREATE TABLE dbo.StockReservations (
    RfId     INT NOT NULL REFERENCES dbo.RF(RfId),
    ItemId   INT NOT NULL REFERENCES dbo.Items(ItemId),
    Quantity DECIMAL(12,2) NOT NULL CHECK (Quantity > 0),
    Status   NVARCHAR(20) NOT NULL DEFAULT N'Reserved',   -- Reserved, Issued
    PRIMARY KEY (RfId, ItemId)
);
GO
IF OBJECT_ID(N'dbo.StockMovements', N'U') IS NULL
CREATE TABLE dbo.StockMovements (
    MovementId   INT IDENTITY(1,1) PRIMARY KEY,
    ItemId       INT NOT NULL REFERENCES dbo.Items(ItemId),
    MovementType NVARCHAR(20)  NOT NULL,                  -- Receive, Adjust, Issue
    Quantity     DECIMAL(12,2) NOT NULL,                  -- positive = in, negative = out
    RfId         INT NULL,
    Remarks      NVARCHAR(200) NULL,
    PerformedBy  NVARCHAR(100) NOT NULL,
    MovementDate DATETIME2     NOT NULL DEFAULT SYSDATETIME()
);
GO
CREATE OR ALTER PROCEDURE dbo.usp_Inventory_GetStock
AS
BEGIN
    SET NOCOUNT ON;
    SELECT i.ItemId, i.ItemName, i.Unit,
           ISNULL(s.OnHand, 0) AS OnHand,
           ISNULL(r.Reserved, 0) AS Reserved,
           ISNULL(s.OnHand, 0) - ISNULL(r.Reserved, 0) AS Available,
           ISNULL(s.ReorderLevel, 0) AS ReorderLevel
    FROM dbo.Items i
    LEFT JOIN dbo.InventoryStock s ON s.ItemId = i.ItemId
    LEFT JOIN (SELECT ItemId, SUM(Quantity) AS Reserved
               FROM dbo.StockReservations WHERE Status = N'Reserved'
               GROUP BY ItemId) r ON r.ItemId = i.ItemId
    ORDER BY i.ItemName;
END
GO
CREATE OR ALTER PROCEDURE dbo.usp_Inventory_Receive
    @ItemId INT, @Quantity DECIMAL(12,2), @PerformedBy NVARCHAR(100), @Remarks NVARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    IF @Quantity <= 0 THROW 50020, 'Quantity received must be greater than zero.', 1;

    BEGIN TRANSACTION;
    UPDATE dbo.InventoryStock WITH (UPDLOCK, HOLDLOCK) SET OnHand = OnHand + @Quantity WHERE ItemId = @ItemId;
    IF @@ROWCOUNT = 0
        INSERT INTO dbo.InventoryStock (ItemId, OnHand) VALUES (@ItemId, @Quantity);
    INSERT INTO dbo.StockMovements (ItemId, MovementType, Quantity, Remarks, PerformedBy)
    VALUES (@ItemId, N'Receive', @Quantity, @Remarks, @PerformedBy);
    COMMIT TRANSACTION;
END
GO
CREATE OR ALTER PROCEDURE dbo.usp_Inventory_Adjust
    @ItemId INT, @NewOnHand DECIMAL(12,2), @PerformedBy NVARCHAR(100), @Remarks NVARCHAR(200)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    IF LTRIM(RTRIM(ISNULL(@Remarks, N''))) = N'' THROW 50021, 'A reason is required for an adjustment.', 1;

    BEGIN TRANSACTION;
    DECLARE @Old DECIMAL(12,2) =
        (SELECT OnHand FROM dbo.InventoryStock WITH (UPDLOCK, HOLDLOCK) WHERE ItemId = @ItemId);
    DECLARE @Reserved DECIMAL(12,2) =
        (SELECT ISNULL(SUM(Quantity), 0) FROM dbo.StockReservations WHERE ItemId = @ItemId AND Status = N'Reserved');
    IF @NewOnHand < @Reserved THROW 50022, 'The new count is lower than the reserved quantity.', 1;

    IF @Old IS NULL
        INSERT INTO dbo.InventoryStock (ItemId, OnHand) VALUES (@ItemId, @NewOnHand);
    ELSE
        UPDATE dbo.InventoryStock SET OnHand = @NewOnHand WHERE ItemId = @ItemId;
    INSERT INTO dbo.StockMovements (ItemId, MovementType, Quantity, Remarks, PerformedBy)
    VALUES (@ItemId, N'Adjust', @NewOnHand - ISNULL(@Old, 0), @Remarks, @PerformedBy);
    COMMIT TRANSACTION;
END
GO
CREATE OR ALTER PROCEDURE dbo.usp_Inventory_SetReorderLevel @ItemId INT, @ReorderLevel DECIMAL(12,2)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    BEGIN TRANSACTION;
    UPDATE dbo.InventoryStock WITH (UPDLOCK, HOLDLOCK) SET ReorderLevel = @ReorderLevel WHERE ItemId = @ItemId;
    IF @@ROWCOUNT = 0
        INSERT INTO dbo.InventoryStock (ItemId, ReorderLevel) VALUES (@ItemId, @ReorderLevel);
    COMMIT TRANSACTION;
END
GO
CREATE OR ALTER PROCEDURE dbo.usp_Inventory_IsReserved @RfId INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) FROM dbo.StockReservations WHERE RfId = @RfId;
END
GO
-- Called once per item, inside a transaction opened by the application.
CREATE OR ALTER PROCEDURE dbo.usp_Inventory_Reserve @RfId INT, @ItemId INT, @Quantity DECIMAL(12,2)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @OnHand DECIMAL(12,2) =
        (SELECT OnHand FROM dbo.InventoryStock WITH (UPDLOCK, HOLDLOCK) WHERE ItemId = @ItemId);
    DECLARE @Reserved DECIMAL(12,2) =
        (SELECT ISNULL(SUM(Quantity), 0) FROM dbo.StockReservations WHERE ItemId = @ItemId AND Status = N'Reserved');
    IF ISNULL(@OnHand, 0) - @Reserved < @Quantity
        THROW 50023, 'Not enough available stock to reserve.', 1;

    INSERT INTO dbo.StockReservations (RfId, ItemId, Quantity) VALUES (@RfId, @ItemId, @Quantity);
END
GO
CREATE OR ALTER PROCEDURE dbo.usp_Inventory_Deduct @RfId INT, @PerformedBy NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    BEGIN TRANSACTION;
    IF NOT EXISTS (SELECT 1 FROM dbo.StockReservations WITH (UPDLOCK, HOLDLOCK)
                   WHERE RfId = @RfId AND Status = N'Reserved')
        THROW 50024, 'There is no reserved stock for this requisition.', 1;

    UPDATE s SET s.OnHand = s.OnHand - r.Quantity
    FROM dbo.InventoryStock s
    INNER JOIN dbo.StockReservations r ON r.ItemId = s.ItemId
    WHERE r.RfId = @RfId AND r.Status = N'Reserved';

    INSERT INTO dbo.StockMovements (ItemId, MovementType, Quantity, RfId, PerformedBy)
    SELECT ItemId, N'Issue', -Quantity, RfId, @PerformedBy
    FROM dbo.StockReservations WHERE RfId = @RfId AND Status = N'Reserved';

    UPDATE dbo.StockReservations SET Status = N'Issued' WHERE RfId = @RfId AND Status = N'Reserved';
    COMMIT TRANSACTION;
END
GO
CREATE OR ALTER PROCEDURE dbo.usp_Inventory_GetMovements
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP (200) m.MovementDate, i.ItemName, m.MovementType, m.Quantity, i.Unit,
           f.RfNumber, m.Remarks, m.PerformedBy
    FROM dbo.StockMovements m
    INNER JOIN dbo.Items i ON i.ItemId = m.ItemId
    LEFT JOIN dbo.RF f ON f.RfId = m.RfId
    ORDER BY m.MovementId DESC;
END
GO
