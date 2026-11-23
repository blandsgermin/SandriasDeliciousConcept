
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SandriasDeliciousConcept.Data
{
    public class PurchaseOrderRepository
    {
        private readonly string _connectionString =
            DatabaseInitializer.AppConnection;

        public int Add(
            string poNumber,
            int supplierId,
            DateTime orderDate,
            DateTime? expectedDeliveryDate,
            string? remarks)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseOrder_Add", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@PONumber", SqlDbType.NVarChar, 50)
                .Value = poNumber;

            command.Parameters.Add("@SupplierID", SqlDbType.Int)
                .Value = supplierId;

            command.Parameters.Add("@OrderDate", SqlDbType.Date)
                .Value = orderDate.Date;

            command.Parameters.Add("@ExpectedDeliveryDate", SqlDbType.Date)
                .Value = (object?)expectedDeliveryDate?.Date ?? DBNull.Value;

            command.Parameters.Add("@Remarks", SqlDbType.NVarChar, 300)
                .Value = (object?)remarks ?? DBNull.Value;

            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public DataTable GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseOrder_GetAll", connection);

            command.CommandType = CommandType.StoredProcedure;

            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        public int AddItem(
            int purchaseOrderId,
            int itemId,
            decimal quantity,
            decimal unitPrice,
            string? remarks)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseOrderItem_Add", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@PurchaseOrderID", SqlDbType.Int)
                .Value = purchaseOrderId;

            command.Parameters.Add("@ItemID", SqlDbType.Int)
                .Value = itemId;

            var quantityParameter =
                command.Parameters.Add("@Quantity", SqlDbType.Decimal);
            quantityParameter.Precision = 10;
            quantityParameter.Scale = 2;
            quantityParameter.Value = quantity;

            var priceParameter =
                command.Parameters.Add("@UnitPrice", SqlDbType.Decimal);
            priceParameter.Precision = 12;
            priceParameter.Scale = 2;
            priceParameter.Value = unitPrice;

            command.Parameters.Add("@Remarks", SqlDbType.NVarChar, 300)
                .Value = (object?)remarks ?? DBNull.Value;

            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public DataTable GetItems(int purchaseOrderId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseOrderItem_GetByPO", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@PurchaseOrderID", SqlDbType.Int)
                .Value = purchaseOrderId;

            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        public int SetStatus(int purchaseOrderId, string status)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseOrder_SetStatus", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@PurchaseOrderID", SqlDbType.Int)
                .Value = purchaseOrderId;

            command.Parameters.Add("@Status", SqlDbType.NVarChar, 30)
                .Value = status;

            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }
    }
}
