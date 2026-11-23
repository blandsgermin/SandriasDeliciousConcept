
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SandriasDeliciousConcept.Data
{
    public class PurchaseLogRepository
    {
        private readonly string _connectionString =
            DatabaseInitializer.AppConnection;

        public int Add(
            int? purchaseOrderId,
            string activityType,
            string description,
            string performedBy)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseLog_Add", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@PurchaseOrderID", SqlDbType.Int)
                .Value = (object?)purchaseOrderId ?? DBNull.Value;

            command.Parameters.Add("@ActivityType", SqlDbType.NVarChar, 50)
                .Value = activityType;

            command.Parameters.Add("@Description", SqlDbType.NVarChar, 300)
                .Value = description;

            command.Parameters.Add("@PerformedBy", SqlDbType.NVarChar, 100)
                .Value = performedBy;

            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public int AddItem(
            int purchaseLogId,
            int itemId,
            decimal quantity,
            decimal unitPrice)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseLogItem_Add", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@PurchaseLogID", SqlDbType.Int)
                .Value = purchaseLogId;

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

            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public DataTable GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseLog_GetAll", connection);

            command.CommandType = CommandType.StoredProcedure;

            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        public DataTable GetItems(int purchaseLogId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseLogItem_GetByLog", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@PurchaseLogID", SqlDbType.Int)
                .Value = purchaseLogId;

            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);
            return table;
        }
    }
}
