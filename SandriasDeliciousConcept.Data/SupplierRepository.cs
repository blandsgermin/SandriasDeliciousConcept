using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SandriasDeliciousConcept.Data
{
    public class SupplierRepository
    {
        private readonly string _connectionString =
            DatabaseInitializer.AppConnection;

        public DataTable GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_Supplier_GetAll", connection);

            command.CommandType = CommandType.StoredProcedure;

            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        public DataTable GetById(int supplierId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_Supplier_GetById", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@SupplierID", SqlDbType.Int)
                .Value = supplierId;

            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        public int Add(
            string supplierName,
            string? contactPerson,
            string? contactNumber,
            string? email,
            string? address)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_Supplier_Add", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@SupplierName", SqlDbType.NVarChar, 150)
                .Value = supplierName;

            command.Parameters.Add("@ContactPerson", SqlDbType.NVarChar, 100)
                .Value = (object?)contactPerson ?? DBNull.Value;

            command.Parameters.Add("@ContactNumber", SqlDbType.NVarChar, 30)
                .Value = (object?)contactNumber ?? DBNull.Value;

            command.Parameters.Add("@Email", SqlDbType.NVarChar, 100)
                .Value = (object?)email ?? DBNull.Value;

            command.Parameters.Add("@Address", SqlDbType.NVarChar, 250)
                .Value = (object?)address ?? DBNull.Value;

            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public int Update(
            int supplierId,
            string supplierName,
            string? contactPerson,
            string? contactNumber,
            string? email,
            string? address)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_Supplier_Update", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@SupplierID", SqlDbType.Int)
                .Value = supplierId;

            command.Parameters.Add("@SupplierName", SqlDbType.NVarChar, 150)
                .Value = supplierName;

            command.Parameters.Add("@ContactPerson", SqlDbType.NVarChar, 100)
                .Value = (object?)contactPerson ?? DBNull.Value;

            command.Parameters.Add("@ContactNumber", SqlDbType.NVarChar, 30)
                .Value = (object?)contactNumber ?? DBNull.Value;

            command.Parameters.Add("@Email", SqlDbType.NVarChar, 100)
                .Value = (object?)email ?? DBNull.Value;

            command.Parameters.Add("@Address", SqlDbType.NVarChar, 250)
                .Value = (object?)address ?? DBNull.Value;

            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public int SetStatus(int supplierId, string status)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_Supplier_SetStatus", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@SupplierID", SqlDbType.Int)
                .Value = supplierId;

            command.Parameters.Add("@Status", SqlDbType.NVarChar, 20)
                .Value = status;

            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }
    }
}
