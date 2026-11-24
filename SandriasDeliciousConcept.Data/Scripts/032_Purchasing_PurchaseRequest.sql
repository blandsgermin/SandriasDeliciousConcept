CREATE OR ALTER PROCEDURE dbo.usp_PurchaseRequest_Add
    @PRNumber NVARCHAR(60),
    @RequisitionReference NVARCHAR(100) = NULL,
    @RequestedBy NVARCHAR(200),
    @RequestDate DATETIME,
    @RequiredDate DATE = NULL,
    @Purpose NVARCHAR(500) = NULL,
    @EstimatedBudget DECIMAL(12,2) = NULL,
    @NewPurchaseRequestID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.PurchaseRequests
    (
        PRNumber,
        RequisitionReference,
        RequestedBy,
        RequestDate,
        RequiredDate,
        Purpose,
        EstimatedBudget
    )
    VALUES
    (
        @PRNumber,
        @RequisitionReference,
        @RequestedBy,
        @RequestDate,
        @RequiredDate,
        @Purpose,
        @EstimatedBudget
    );

    SET @NewPurchaseRequestID = SCOPE_IDENTITY();
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_PurchaseRequest_GetAll
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM dbo.PurchaseRequests
    ORDER BY PurchaseRequestID DESC;
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_PurchaseRequest_GetById
    @PurchaseRequestID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM dbo.PurchaseRequests
    WHERE PurchaseRequestID = @PurchaseRequestID;

    SELECT *
    FROM dbo.PurchaseRequestItems
    WHERE PurchaseRequestID = @PurchaseRequestID
    ORDER BY RequestItemID;
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_PurchaseRequestItem_Add
    @PurchaseRequestID INT,
    @ItemCode NVARCHAR(100) = NULL,
    @ItemName NVARCHAR(300),
    @Quantity DECIMAL(12,2),
    @Unit NVARCHAR(60),
    @EstimatedUnitPrice DECIMAL(12,2) = NULL,
    @Remarks NVARCHAR(500) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Quantity <= 0
        THROW 50001, 'Quantity must be greater than zero.', 1;

    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.PurchaseRequests
        WHERE PurchaseRequestID = @PurchaseRequestID
    )
        THROW 50002, 'Purchase request does not exist.', 1;

    INSERT INTO dbo.PurchaseRequestItems
    (
        PurchaseRequestID,
        ItemCode,
        ItemName,
        Quantity,
        Unit,
        EstimatedUnitPrice,
        EstimatedSubtotal,
        Remarks
    )
    VALUES
    (
        @PurchaseRequestID,
        @ItemCode,
        @ItemName,
        @Quantity,
        @Unit,
        @EstimatedUnitPrice,
        CASE
            WHEN @EstimatedUnitPrice IS NULL THEN NULL
            ELSE @Quantity * @EstimatedUnitPrice
        END,
        @Remarks
    );
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_PurchaseRequestItem_GetByRequest
    @PurchaseRequestID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        RequestItemID,
        PurchaseRequestID,
        ItemCode,
        ItemName,
        Quantity,
        Unit,
        EstimatedUnitPrice,
        EstimatedSubtotal,
        Remarks
    FROM dbo.PurchaseRequestItems
    WHERE PurchaseRequestID = @PurchaseRequestID
    ORDER BY RequestItemID;
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_PurchaseRequest_Update
    @PurchaseRequestID INT,
    @RequisitionReference NVARCHAR(100) = NULL,
    @RequestedBy NVARCHAR(200),
    @RequiredDate DATE = NULL,
    @Purpose NVARCHAR(500) = NULL,
    @EstimatedBudget DECIMAL(12,2) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.PurchaseRequests
    SET
        RequisitionReference = @RequisitionReference,
        RequestedBy = @RequestedBy,
        RequiredDate = @RequiredDate,
        Purpose = @Purpose,
        EstimatedBudget = @EstimatedBudget
    WHERE PurchaseRequestID = @PurchaseRequestID;

    IF @@ROWCOUNT = 0
        THROW 50003, 'Purchase request not found.', 1;
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_PurchaseRequest_SetStatus
    @PurchaseRequestID INT,
    @RequestStatus NVARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.PurchaseRequests
    SET RequestStatus = @RequestStatus
    WHERE PurchaseRequestID = @PurchaseRequestID;

    IF @@ROWCOUNT = 0
        THROW 50004, 'Purchase request not found.', 1;
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_PurchaseRequest_Search
    @SearchText NVARCHAR(200)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM dbo.PurchaseRequests
    WHERE
        PRNumber LIKE N'%' + @SearchText + N'%'
        OR RequestedBy LIKE N'%' + @SearchText + N'%'
        OR RequisitionReference LIKE N'%' + @SearchText + N'%'
        OR RequestStatus LIKE N'%' + @SearchText + N'%'
    ORDER BY PurchaseRequestID DESC;
END;
GO


/* 9. DELETE PURCHASE REQUEST ITEM */
CREATE OR ALTER PROCEDURE dbo.usp_PurchaseRequestItem_Delete
    @RequestItemID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM dbo.PurchaseRequestItems
    WHERE RequestItemID = @RequestItemID;

    IF @@ROWCOUNT = 0
        THROW 50005, 'Purchase request item not found.', 1;
END;
GO


/* 10. DELETE PURCHASE REQUEST */
CREATE OR ALTER PROCEDURE dbo.usp_PurchaseRequest_Delete
    @PurchaseRequestID INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DELETE FROM dbo.PurchaseRequestItems
        WHERE PurchaseRequestID = @PurchaseRequestID;

        DELETE FROM dbo.PurchaseRequests
        WHERE PurchaseRequestID = @PurchaseRequestID;

        IF @@ROWCOUNT = 0
            THROW 50006, 'Purchase request not found.', 1;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO
