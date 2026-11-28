CREATE OR ALTER PROCEDURE dbo.usp_Delivery_GetAll
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        d.DeliveryId,
        d.DeliveryNumber,
        d.RfId,
        r.RfNumber,
        r.Requester,
        r.CustomerName,
        r.EventDate,
        r.Venue,
        d.AssignedUserId,
        u.FullName AS AssignedPersonnel,
        u.Role AS PersonnelRole,
        d.Vehicle,
        d.ScheduledDate,
        d.ActualDeliveryDate,
        d.DeliveryAddress,
        d.Status,
        d.Remarks
    FROM dbo.Delivery d
    INNER JOIN dbo.RF r ON d.RfId = r.RfId
    INNER JOIN dbo.Users u ON d.AssignedUserId = u.UserId
    ORDER BY d.ScheduledDate DESC;
END;
GO
CREATE OR ALTER PROCEDURE dbo.usp_Delivery_GetById
    @DeliveryId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        d.*,
        r.RfNumber,
        r.Requester,
        r.CustomerName,
        u.FullName AS AssignedPersonnel,
        u.Role AS PersonnelRole
    FROM dbo.Delivery d
    INNER JOIN dbo.RF r ON d.RfId = r.RfId
    INNER JOIN dbo.Users u ON d.AssignedUserId = u.UserId
    WHERE d.DeliveryId = @DeliveryId;
END;
GO
CREATE OR ALTER PROCEDURE dbo.usp_Delivery_Add
    @DeliveryNumber NVARCHAR(30),
    @RfId INT,
    @AssignedUserId INT,
    @Vehicle NVARCHAR(100) = NULL,
    @ScheduledDate DATETIME2,
    @DeliveryAddress NVARCHAR(250) = NULL,
    @Remarks NVARCHAR(300) = NULL,
    @CreatedBy INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1 FROM dbo.RF
        WHERE RfId = @RfId
          AND Status = N'Approved'
    )
        THROW 50020, 'Only approved requisitions can be scheduled for delivery.', 1;

    IF NOT EXISTS
    (
        SELECT 1 FROM dbo.Users
        WHERE UserId = @AssignedUserId
    )
        THROW 50021, 'Assigned personnel does not exist.', 1;

    INSERT INTO dbo.Delivery
    (
        DeliveryNumber,
        RfId,
        AssignedUserId,
        Vehicle,
        ScheduledDate,
        DeliveryAddress,
        Remarks,
        CreatedBy
    )
    VALUES
    (
        @DeliveryNumber,
        @RfId,
        @AssignedUserId,
        @Vehicle,
        @ScheduledDate,
        @DeliveryAddress,
        @Remarks,
        @CreatedBy
    );

    DECLARE @NewDeliveryId INT = SCOPE_IDENTITY();

    INSERT INTO dbo.DeliveryStatusHistory
    (
        DeliveryId,
        PreviousStatus,
        NewStatus,
        ChangedBy,
        Remarks
    )
    VALUES
    (
        @NewDeliveryId,
        NULL,
        N'Scheduled',
        @CreatedBy,
        N'Delivery scheduled.'
    );

    SELECT @NewDeliveryId AS DeliveryId;
END;
GO
CREATE OR ALTER PROCEDURE dbo.usp_Delivery_Update
    @DeliveryId INT,
    @AssignedUserId INT,
    @Vehicle NVARCHAR(100) = NULL,
    @ScheduledDate DATETIME2,
    @DeliveryAddress NVARCHAR(250) = NULL,
    @Remarks NVARCHAR(300) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1 FROM dbo.Delivery
        WHERE DeliveryId = @DeliveryId
          AND Status NOT IN (N'Delivered', N'Cancelled')
    )
        THROW 50022, 'Delivery cannot be edited.', 1;

    UPDATE dbo.Delivery
    SET
        AssignedUserId = @AssignedUserId,
        Vehicle = @Vehicle,
        ScheduledDate = @ScheduledDate,
        DeliveryAddress = @DeliveryAddress,
        Remarks = @Remarks
    WHERE DeliveryId = @DeliveryId;
END;
GO
CREATE OR ALTER PROCEDURE dbo.usp_Delivery_SetStatus
    @DeliveryId INT,
    @NewStatus NVARCHAR(30),
    @ChangedBy INT = NULL,
    @Remarks NVARCHAR(300) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @PreviousStatus NVARCHAR(30);

    IF @NewStatus NOT IN
    (
        N'Scheduled',
        N'Preparing',
        N'Out for Delivery',
        N'Delivered',
        N'Cancelled'
    )
        THROW 50023, 'Invalid delivery status.', 1;

    BEGIN TRANSACTION;

    SELECT @PreviousStatus = Status
    FROM dbo.Delivery WITH (UPDLOCK, HOLDLOCK)
    WHERE DeliveryId = @DeliveryId;

    IF @PreviousStatus IS NULL
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50024, 'Delivery record not found.', 1;
    END;

    IF @PreviousStatus IN (N'Delivered', N'Cancelled')
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50025, 'Completed or cancelled delivery cannot be changed.', 1;
    END;

    UPDATE dbo.Delivery
    SET
        Status = @NewStatus,
        ActualDeliveryDate =
            CASE
                WHEN @NewStatus = N'Delivered'
                THEN SYSDATETIME()
                ELSE ActualDeliveryDate
            END
    WHERE DeliveryId = @DeliveryId;

    INSERT INTO dbo.DeliveryStatusHistory
    (
        DeliveryId,
        PreviousStatus,
        NewStatus,
        ChangedBy,
        Remarks
    )
    VALUES
    (
        @DeliveryId,
        @PreviousStatus,
        @NewStatus,
        @ChangedBy,
        @Remarks
    );

    COMMIT TRANSACTION;
END;
GO
CREATE OR ALTER PROCEDURE dbo.usp_Delivery_Search
    @Search NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        d.DeliveryId,
        d.DeliveryNumber,
        r.RfNumber,
        r.CustomerName,
        u.FullName AS AssignedPersonnel,
        d.Vehicle,
        d.ScheduledDate,
        d.ActualDeliveryDate,
        d.Status
    FROM dbo.Delivery d
    INNER JOIN dbo.RF r ON d.RfId = r.RfId
    INNER JOIN dbo.Users u ON d.AssignedUserId = u.UserId
    WHERE
        d.DeliveryNumber LIKE N'%' + @Search + N'%'
        OR r.RfNumber LIKE N'%' + @Search + N'%'
        OR r.CustomerName LIKE N'%' + @Search + N'%'
        OR u.FullName LIKE N'%' + @Search + N'%'
        OR d.Status LIKE N'%' + @Search + N'%'
    ORDER BY d.ScheduledDate DESC;
END;
GO
CREATE OR ALTER PROCEDURE dbo.usp_Delivery_GetApprovedRequests
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        RfId,
        RfNumber,
        Requester,
        CustomerName,
        EventDate,
        Venue,
        RequiredDate,
        Status
    FROM dbo.RF
    WHERE Status = N'Approved'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.Delivery d
          WHERE d.RfId = RF.RfId
            AND d.Status <> N'Cancelled'
      )
    ORDER BY RequiredDate;
END;
GO
CREATE OR ALTER PROCEDURE dbo.usp_Delivery_GetPersonnel
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        UserId,
        FullName,
        Username,
        Role
    FROM dbo.Users
    ORDER BY FullName;
END;
GO
CREATE OR ALTER PROCEDURE dbo.usp_Delivery_GetHistory
    @DeliveryId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        h.HistoryId,
        h.DeliveryId,
        h.PreviousStatus,
        h.NewStatus,
        u.FullName AS ChangedByName,
        h.Remarks,
        h.ChangedAt
    FROM dbo.DeliveryStatusHistory h
    LEFT JOIN dbo.Users u ON h.ChangedBy = u.UserId
    WHERE h.DeliveryId = @DeliveryId
    ORDER BY h.ChangedAt DESC;
END;
GO
