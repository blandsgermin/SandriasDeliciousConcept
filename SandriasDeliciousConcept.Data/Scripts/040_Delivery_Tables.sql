
-- =============================================
-- 040_Delivery_Tables.sql
-- Sandrias Delicious Concept ERP
-- =============================================

IF OBJECT_ID(N'dbo.Delivery', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Delivery
    (
        DeliveryId INT IDENTITY(1,1) PRIMARY KEY,
        DeliveryNumber NVARCHAR(30) NOT NULL UNIQUE,

        RfId INT NOT NULL
            REFERENCES dbo.RF(RfId),

        AssignedUserId INT NOT NULL
            REFERENCES dbo.Users(UserId),

        Vehicle NVARCHAR(100) NULL,
        ScheduledDate DATETIME2 NOT NULL,
        ActualDeliveryDate DATETIME2 NULL,
        DeliveryAddress NVARCHAR(250) NULL,

        Status NVARCHAR(30) NOT NULL
            CONSTRAINT DF_Delivery_Status DEFAULT N'Scheduled',

        Remarks NVARCHAR(300) NULL,

        CreatedAt DATETIME2 NOT NULL
            CONSTRAINT DF_Delivery_CreatedAt DEFAULT SYSDATETIME(),

        CreatedBy INT NULL
            REFERENCES dbo.Users(UserId),

        CONSTRAINT CK_Delivery_Status CHECK
        (
            Status IN
            (
                N'Scheduled',
                N'Preparing',
                N'Out for Delivery',
                N'Delivered',
                N'Cancelled'
            )
        )
    );
END;
GO

IF OBJECT_ID(N'dbo.DeliveryStatusHistory', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.DeliveryStatusHistory
    (
        HistoryId INT IDENTITY(1,1) PRIMARY KEY,

        DeliveryId INT NOT NULL
            REFERENCES dbo.Delivery(DeliveryId)
            ON DELETE CASCADE,

        PreviousStatus NVARCHAR(30) NULL,
        NewStatus NVARCHAR(30) NOT NULL,

        ChangedBy INT NULL
            REFERENCES dbo.Users(UserId),

        Remarks NVARCHAR(300) NULL,

        ChangedAt DATETIME2 NOT NULL
            CONSTRAINT DF_DeliveryHistory_ChangedAt
            DEFAULT SYSDATETIME()
    );
END;
GO
