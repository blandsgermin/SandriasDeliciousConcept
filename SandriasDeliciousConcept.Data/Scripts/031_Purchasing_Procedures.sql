
-- =============================================
-- 031_PURCHASING_PROCEDURES.SQL
-- Sandria's Delicious Concept ERP
-- =============================================

-- 1. ADD SUPPLIER
CREATE OR ALTER PROCEDURE dbo.usp_Supplier_Add
    @SupplierName NVARCHAR(150),
    @ContactPerson NVARCHAR(100) = NULL,
    @ContactNumber NVARCHAR(30) = NULL,
    @Email NVARCHAR(100) = NULL,
    @Address NVARCHAR(250) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.Suppliers
    (
        SupplierName, ContactPerson, ContactNumber,
        Email, Address, Status
    )
    VALUES
    (
        @SupplierName, @ContactPerson, @ContactNumber,
        @Email, @Address, N'Active'
    );

    SELECT CAST(SCOPE_IDENTITY() AS INT) AS SupplierID;
END;
GO

-- 2. GET ALL SUPPLIERS
CREATE OR ALTER PROCEDURE dbo.usp_Supplier_GetAll
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        SupplierID, SupplierName, ContactPerson,
        ContactNumber, Email, Address, Status, DateCreated
    FROM dbo.Suppliers
    ORDER BY SupplierName;
END;
GO

-- 3. GET SUPPLIER BY ID
CREATE OR ALTER PROCEDURE dbo.usp_Supplier_GetById
    @SupplierID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM dbo.Suppliers
    WHERE SupplierID = @SupplierID;
END;
GO

-- 4. UPDATE SUPPLIER
CREATE OR ALTER PROCEDURE dbo.usp_Supplier_Update
    @SupplierID INT,
    @SupplierName NVARCHAR(150),
    @ContactPerson NVARCHAR(100) = NULL,
    @ContactNumber NVARCHAR(30) = NULL,
    @Email NVARCHAR(100) = NULL,
    @Address NVARCHAR(250) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.Suppliers
    SET
        SupplierName = @SupplierName,
        ContactPerson = @ContactPerson,
        ContactNumber = @ContactNumber,
        Email = @Email,
        Address = @Address
    WHERE SupplierID = @SupplierID;

    SELECT @@ROWCOUNT AS RowsAffected;
END;
GO

-- 5. CHANGE SUPPLIER STATUS
CREATE OR ALTER PROCEDURE dbo.usp_Supplier_SetStatus
    @SupplierID INT,
    @Status NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.Suppliers
    SET Status = @Status
    WHERE SupplierID = @SupplierID;

    SELECT @@ROWCOUNT AS RowsAffected;
END;
GO

-- 6. ADD SUPPLIER QUOTATION
CREATE OR ALTER PROCEDURE dbo.usp_Quotation_Add
    @QuotationNumber NVARCHAR(50),
    @SupplierID INT,
    @QuotationDate DATE,
    @ValidUntil DATE = NULL,
    @Remarks NVARCHAR(300) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.SupplierQuotations
    (
        QuotationNumber, SupplierID, QuotationDate,
        ValidUntil, Status, Remarks
    )
    VALUES
    (
        @QuotationNumber, @SupplierID, @QuotationDate,
        @ValidUntil, N'Pending', @Remarks
    );

    SELECT CAST(SCOPE_IDENTITY() AS INT) AS QuotationID;
END;
GO

-- 7. GET ALL QUOTATIONS
CREATE OR ALTER PROCEDURE dbo.usp_Quotation_GetAll
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        q.QuotationID,
        q.QuotationNumber,
        q.SupplierID,
        s.SupplierName,
        q.QuotationDate,
        q.ValidUntil,
        q.Status,
        q.Remarks,
        q.DateCreated
    FROM dbo.SupplierQuotations q
    INNER JOIN dbo.Suppliers s
        ON q.SupplierID = s.SupplierID
    ORDER BY q.QuotationDate DESC;
END;
GO

-- 8. ADD QUOTATION ITEM
CREATE OR ALTER PROCEDURE dbo.usp_QuotationItem_Add
    @QuotationID INT,
    @ItemID INT,
    @Quantity DECIMAL(10,2),
    @UnitPrice DECIMAL(12,2),
    @Remarks NVARCHAR(300) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.QuotationItems
    (
        QuotationID, ItemID, Quantity, UnitPrice, Remarks
    )
    VALUES
    (
        @QuotationID, @ItemID, @Quantity, @UnitPrice, @Remarks
    );

    SELECT CAST(SCOPE_IDENTITY() AS INT) AS QuotationItemID;
END;
GO

-- 9. GET QUOTATION ITEMS
CREATE OR ALTER PROCEDURE dbo.usp_QuotationItem_GetByQuotation
    @QuotationID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        qi.QuotationItemID,
        qi.QuotationID,
        qi.ItemID,
        i.ItemName,
        qi.Quantity,
        i.Unit,
        qi.UnitPrice,
        (qi.Quantity * qi.UnitPrice) AS Subtotal,
        qi.Remarks
    FROM dbo.QuotationItems qi
    INNER JOIN dbo.Items i
        ON qi.ItemID = i.ItemId
    WHERE qi.QuotationID = @QuotationID;
END;
GO

-- 10. CHANGE QUOTATION STATUS
CREATE OR ALTER PROCEDURE dbo.usp_Quotation_SetStatus
    @QuotationID INT,
    @Status NVARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.SupplierQuotations
    SET Status = @Status
    WHERE QuotationID = @QuotationID;

    SELECT @@ROWCOUNT AS RowsAffected;
END;
GO

-- 11. ADD PURCHASE ORDER
CREATE OR ALTER PROCEDURE dbo.usp_PurchaseOrder_Add
    @PONumber NVARCHAR(50),
    @SupplierID INT,
    @OrderDate DATE,
    @ExpectedDeliveryDate DATE = NULL,
    @Remarks NVARCHAR(300) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.PurchaseOrders
    (
        PONumber, SupplierID, OrderDate,
        ExpectedDeliveryDate, Status, TotalAmount, Remarks
    )
    VALUES
    (
        @PONumber, @SupplierID, @OrderDate,
        @ExpectedDeliveryDate, N'Pending', 0, @Remarks
    );

    SELECT CAST(SCOPE_IDENTITY() AS INT) AS PurchaseOrderID;
END;
GO

-- 12. GET ALL PURCHASE ORDERS
CREATE OR ALTER PROCEDURE dbo.usp_PurchaseOrder_GetAll
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        po.PurchaseOrderID,
        po.PONumber,
        po.SupplierID,
        s.SupplierName,
        po.OrderDate,
        po.ExpectedDeliveryDate,
        po.Status,
        po.TotalAmount,
        po.Remarks,
        po.DateCreated
    FROM dbo.PurchaseOrders po
    INNER JOIN dbo.Suppliers s
        ON po.SupplierID = s.SupplierID
    ORDER BY po.OrderDate DESC;
END;
GO

-- 13. ADD PURCHASE ORDER ITEM
CREATE OR ALTER PROCEDURE dbo.usp_PurchaseOrderItem_Add
    @PurchaseOrderID INT,
    @ItemID INT,
    @Quantity DECIMAL(10,2),
    @UnitPrice DECIMAL(12,2),
    @Remarks NVARCHAR(300) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        INSERT INTO dbo.PurchaseOrderItems
        (
            PurchaseOrderID, ItemID, Quantity, UnitPrice, Remarks
        )
        VALUES
        (
            @PurchaseOrderID, @ItemID, @Quantity, @UnitPrice, @Remarks
        );

        UPDATE dbo.PurchaseOrders
        SET TotalAmount = TotalAmount + (@Quantity * @UnitPrice)
        WHERE PurchaseOrderID = @PurchaseOrderID;

        DECLARE @POItemID INT = CAST(SCOPE_IDENTITY() AS INT);

        COMMIT TRANSACTION;

        SELECT @POItemID AS POItemID;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        THROW;
    END CATCH;
END;
GO

-- 14. GET PURCHASE ORDER ITEMS
CREATE OR ALTER PROCEDURE dbo.usp_PurchaseOrderItem_GetByPO
    @PurchaseOrderID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        poi.POItemID,
        poi.PurchaseOrderID,
        poi.ItemID,
        i.ItemName,
        poi.Quantity,
        i.Unit,
        poi.UnitPrice,
        (poi.Quantity * poi.UnitPrice) AS Subtotal,
        poi.Remarks
    FROM dbo.PurchaseOrderItems poi
    INNER JOIN dbo.Items i
        ON poi.ItemID = i.ItemId
    WHERE poi.PurchaseOrderID = @PurchaseOrderID;
END;
GO

-- 15. CHANGE PURCHASE ORDER STATUS
CREATE OR ALTER PROCEDURE dbo.usp_PurchaseOrder_SetStatus
    @PurchaseOrderID INT,
    @Status NVARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.PurchaseOrders
    SET Status = @Status
    WHERE PurchaseOrderID = @PurchaseOrderID;

    SELECT @@ROWCOUNT AS RowsAffected;
END;
GO

-- 16. ADD PURCHASE LOG / ACTIVITY
CREATE OR ALTER PROCEDURE dbo.usp_PurchaseLog_Add
    @PurchaseOrderID INT = NULL,
    @ActivityType NVARCHAR(50),
    @Description NVARCHAR(300),
    @PerformedBy NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.PurchaseLogs
    (
        PurchaseOrderID, ActivityType, Description, PerformedBy
    )
    VALUES
    (
        @PurchaseOrderID, @ActivityType, @Description, @PerformedBy
    );

    SELECT CAST(SCOPE_IDENTITY() AS INT) AS PurchaseLogID;
END;
GO

-- 17. ADD PURCHASE LOG ITEM
CREATE OR ALTER PROCEDURE dbo.usp_PurchaseLogItem_Add
    @PurchaseLogID INT,
    @ItemID INT,
    @Quantity DECIMAL(10,2),
    @UnitPrice DECIMAL(12,2)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.PurchaseLogItems
    (
        PurchaseLogID, ItemID, Quantity, UnitPrice
    )
    VALUES
    (
        @PurchaseLogID, @ItemID, @Quantity, @UnitPrice
    );

    SELECT CAST(SCOPE_IDENTITY() AS INT) AS PurchaseLogItemID;
END;
GO

-- 18. GET ALL PURCHASE LOGS
CREATE OR ALTER PROCEDURE dbo.usp_PurchaseLog_GetAll
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        pl.PurchaseLogID,
        pl.PurchaseOrderID,
        po.PONumber,
        pl.ActivityType,
        pl.Description,
        pl.PerformedBy,
        pl.ActivityDate
    FROM dbo.PurchaseLogs pl
    LEFT JOIN dbo.PurchaseOrders po
        ON pl.PurchaseOrderID = po.PurchaseOrderID
    ORDER BY pl.ActivityDate DESC;
END;
GO

-- 19. GET PURCHASE LOG ITEMS
CREATE OR ALTER PROCEDURE dbo.usp_PurchaseLogItem_GetByLog
    @PurchaseLogID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        pli.PurchaseLogItemID,
        pli.PurchaseLogID,
        pli.ItemID,
        i.ItemName,
        pli.Quantity,
        i.Unit,
        pli.UnitPrice,
        (pli.Quantity * pli.UnitPrice) AS Subtotal
    FROM dbo.PurchaseLogItems pli
    INNER JOIN dbo.Items i
        ON pli.ItemID = i.ItemId
    WHERE pli.PurchaseLogID = @PurchaseLogID;
END;
GO
