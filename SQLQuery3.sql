USE SandriasCommissaryDB;
GO

SELECT name
FROM sys.procedures
WHERE name LIKE 'usp_PurchaseRequest%'
ORDER BY name;
GO