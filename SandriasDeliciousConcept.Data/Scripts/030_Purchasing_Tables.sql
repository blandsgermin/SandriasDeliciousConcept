IF OBJECT_ID(N'dbo.Suppliers', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Suppliers
    (
        SupplierID INT IDENTITY(1,1) PRIMARY KEY,
        SupplierName NVARCHAR(150) NOT NULL,
        ContactPerson NVARCHAR(100) NULL,
        ContactNumber NVARCHAR(30) NULL,
        Email NVARCHAR(100) NULL,
        Address NVARCHAR(250) NULL,
        Status NVARCHAR(20) NOT NULL
            CONSTRAINT DF_Suppliers_Status DEFAULT N'Active',
        DateCreated DATETIME2 NOT NULL
            CONSTRAINT DF_Suppliers_DateCreated DEFAULT SYSDATETIME()
    );
END;
GO
IF OBJECT_ID(N'dbo.SupplierQuotations', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.SupplierQuotations
    (
        QuotationID INT IDENTITY(1,1) PRIMARY KEY,
        QuotationNumber NVARCHAR(50) NOT NULL UNIQUE,
        SupplierID INT NOT NULL,
        QuotationDate DATE NOT NULL,
        ValidUntil DATE NULL,
        Status NVARCHAR(30) NOT NULL
            CONSTRAINT DF_SupplierQuotations_Status
            DEFAULT N'Pending',
        Remarks NVARCHAR(300) NULL,
        DateCreated DATETIME2 NOT NULL
            CONSTRAINT DF_SupplierQuotations_DateCreated
            DEFAULT SYSDATETIME(),

        CONSTRAINT FK_SupplierQuotations_Suppliers
            FOREIGN KEY (SupplierID)
            REFERENCES dbo.Suppliers(SupplierID)
    );
END;
GO
IF OBJECT_ID(N'dbo.QuotationItems', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.QuotationItems
    (
        QuotationItemID INT IDENTITY(1,1) PRIMARY KEY,
        QuotationID INT NOT NULL,
        ItemID INT NOT NULL,
        Quantity DECIMAL(10,2) NOT NULL
            CHECK (Quantity > 0),
        UnitPrice DECIMAL(12,2) NOT NULL
            CHECK (UnitPrice >= 0),
        Remarks NVARCHAR(300) NULL,

        CONSTRAINT FK_QuotationItems_SupplierQuotations
            FOREIGN KEY (QuotationID)
            REFERENCES dbo.SupplierQuotations(QuotationID),

        CONSTRAINT FK_QuotationItems_Items
            FOREIGN KEY (ItemID)
            REFERENCES dbo.Items(ItemId)
    );
END;
GO
IF OBJECT_ID(N'dbo.PurchaseOrders', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.PurchaseOrders
    (
        PurchaseOrderID INT IDENTITY(1,1) PRIMARY KEY,
        PONumber NVARCHAR(50) NOT NULL UNIQUE,
        SupplierID INT NOT NULL,
        OrderDate DATE NOT NULL,
        ExpectedDeliveryDate DATE NULL,
        Status NVARCHAR(30) NOT NULL
            CONSTRAINT DF_PurchaseOrders_Status DEFAULT N'Pending',
        TotalAmount DECIMAL(18,2) NOT NULL
            CONSTRAINT DF_PurchaseOrders_TotalAmount DEFAULT 0,
        Remarks NVARCHAR(300) NULL,
        DateCreated DATETIME2 NOT NULL
            CONSTRAINT DF_PurchaseOrders_DateCreated DEFAULT SYSDATETIME(),

        CONSTRAINT FK_PurchaseOrders_Suppliers
            FOREIGN KEY (SupplierID)
            REFERENCES dbo.Suppliers(SupplierID)
    );
END;
GO
IF OBJECT_ID(N'dbo.PurchaseOrderItems', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.PurchaseOrderItems
    (
        POItemID INT IDENTITY(1,1) PRIMARY KEY,
        PurchaseOrderID INT NOT NULL,
        ItemID INT NOT NULL,
        Quantity DECIMAL(10,2) NOT NULL
            CHECK (Quantity > 0),
        UnitPrice DECIMAL(12,2) NOT NULL
            CHECK (UnitPrice >= 0),
        Remarks NVARCHAR(300) NULL,

        CONSTRAINT FK_PurchaseOrderItems_PurchaseOrders
            FOREIGN KEY (PurchaseOrderID)
            REFERENCES dbo.PurchaseOrders(PurchaseOrderID),

        CONSTRAINT FK_PurchaseOrderItems_Items
            FOREIGN KEY (ItemID)
            REFERENCES dbo.Items(ItemId)
    );
END;
GO
IF OBJECT_ID(N'dbo.PurchaseLogs', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.PurchaseLogs
    (
        PurchaseLogID INT IDENTITY(1,1) PRIMARY KEY,
        PurchaseOrderID INT NULL,
        ActivityType NVARCHAR(50) NOT NULL,
        Description NVARCHAR(300) NOT NULL,
        PerformedBy NVARCHAR(100) NOT NULL,
        ActivityDate DATETIME2 NOT NULL
            CONSTRAINT DF_PurchaseLogs_ActivityDate DEFAULT SYSDATETIME(),

        CONSTRAINT FK_PurchaseLogs_PurchaseOrders
            FOREIGN KEY (PurchaseOrderID)
            REFERENCES dbo.PurchaseOrders(PurchaseOrderID)
    );
END;
GO
IF OBJECT_ID(N'dbo.PurchaseLogItems', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.PurchaseLogItems
    (
        PurchaseLogItemID INT IDENTITY(1,1) PRIMARY KEY,
        PurchaseLogID INT NOT NULL,
        ItemID INT NOT NULL,
        Quantity DECIMAL(10,2) NOT NULL
            CHECK (Quantity > 0),
        UnitPrice DECIMAL(12,2) NOT NULL
            CHECK (UnitPrice >= 0),

        CONSTRAINT FK_PurchaseLogItems_PurchaseLogs
            FOREIGN KEY (PurchaseLogID)
            REFERENCES dbo.PurchaseLogs(PurchaseLogID),

        CONSTRAINT FK_PurchaseLogItems_Items
            FOREIGN KEY (ItemID)
            REFERENCES dbo.Items(ItemId)
    );
END;
GO