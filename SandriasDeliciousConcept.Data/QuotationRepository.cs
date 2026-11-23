
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SandriasDeliciousConcept.Data
{
    public class QuotationRepository
    {
        private readonly string _connectionString =
            DatabaseInitializer.AppConnection;

        public int Add(
            string quotationNumber,
            int supplierId,
            DateTime quotationDate,
            DateTime? validUntil,
            string? remarks)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_Quotation_Add", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@QuotationNumber", SqlDbType.NVarChar, 50)
                .Value = quotationNumber;

            command.Parameters.Add("@SupplierID", SqlDbType.Int)
                .Value = supplierId;

            command.Parameters.Add("@QuotationDate", SqlDbType.Date)
                .Value = quotationDate.Date;

            command.Parameters.Add("@ValidUntil", SqlDbType.Date)
                .Value = (object?)validUntil?.Date ?? DBNull.Value;

            command.Parameters.Add("@Remarks", SqlDbType.NVarChar, 300)
                .Value = (object?)remarks ?? DBNull.Value;

            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public DataTable GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_Quotation_GetAll", connection);

            command.CommandType = CommandType.StoredProcedure;

            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        public int AddItem(
            int quotationId,
            int itemId,
            decimal quantity,
            decimal unitPrice,
            string? remarks)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_QuotationItem_Add", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@QuotationID", SqlDbType.Int)
                .Value = quotationId;

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

        public DataTable GetItems(int quotationId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_QuotationItem_GetByQuotation", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@QuotationID", SqlDbType.Int)
                .Value = quotationId;

            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        public int SetStatus(int quotationId, string status)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_Quotation_SetStatus", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@QuotationID", SqlDbType.Int)
                .Value = quotationId;

            command.Parameters.Add("@Status", SqlDbType.NVarChar, 30)
                .Value = status;

            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }
    }
}
