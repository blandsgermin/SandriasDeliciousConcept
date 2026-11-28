SELECT name
FROM sys.tables
WHERE name IN ('Delivery', 'DeliveryStatusHistory');

SELECT name
FROM sys.procedures
WHERE name LIKE 'usp_Delivery_%'
ORDER BY name;