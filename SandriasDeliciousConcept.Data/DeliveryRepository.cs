
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SandriasDeliciousConcept.Data
{
    public class DeliveryRepository
    {
        private readonly string _connectionString =
            DatabaseInitializer.AppConnection;

        // =========================================
        // GET ALL DELIVERIES
        // =========================================
        public DataTable GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_Delivery_GetAll", connection);

            command.CommandType = CommandType.StoredProcedure;

            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        // =========================================
        // GET DELIVERY BY ID
        // =========================================
        public DataTable GetById(int deliveryId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_Delivery_GetById", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@DeliveryId", SqlDbType.Int)
                .Value = deliveryId;

            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        // =========================================
        // ADD DELIVERY
        // =========================================
        public int Add(
            string deliveryNumber,
            int rfId,
            int assignedUserId,
            string? vehicle,
            DateTime scheduledDate,
            string? deliveryAddress,
            string? remarks,
            int? createdBy)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_Delivery_Add", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@DeliveryNumber", SqlDbType.NVarChar, 30)
                .Value = deliveryNumber;

            command.Parameters.Add("@RfId", SqlDbType.Int)
                .Value = rfId;

            command.Parameters.Add("@AssignedUserId", SqlDbType.Int)
                .Value = assignedUserId;

            command.Parameters.Add("@Vehicle", SqlDbType.NVarChar, 100)
                .Value = (object?)vehicle ?? DBNull.Value;

            command.Parameters.Add("@ScheduledDate", SqlDbType.DateTime2)
                .Value = scheduledDate;

            command.Parameters.Add("@DeliveryAddress", SqlDbType.NVarChar, 250)
                .Value = (object?)deliveryAddress ?? DBNull.Value;

            command.Parameters.Add("@Remarks", SqlDbType.NVarChar, 300)
                .Value = (object?)remarks ?? DBNull.Value;

            command.Parameters.Add("@CreatedBy", SqlDbType.Int)
                .Value = (object?)createdBy ?? DBNull.Value;

            connection.Open();

            return Convert.ToInt32(command.ExecuteScalar());
        }

        // =========================================
        // UPDATE DELIVERY
        // =========================================
        public void Update(
            int deliveryId,
            int assignedUserId,
            string? vehicle,
            DateTime scheduledDate,
            string? deliveryAddress,
            string? remarks)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_Delivery_Update", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@DeliveryId", SqlDbType.Int)
                .Value = deliveryId;

            command.Parameters.Add("@AssignedUserId", SqlDbType.Int)
                .Value = assignedUserId;

            command.Parameters.Add("@Vehicle", SqlDbType.NVarChar, 100)
                .Value = (object?)vehicle ?? DBNull.Value;

            command.Parameters.Add("@ScheduledDate", SqlDbType.DateTime2)
                .Value = scheduledDate;

            command.Parameters.Add("@DeliveryAddress", SqlDbType.NVarChar, 250)
                .Value = (object?)deliveryAddress ?? DBNull.Value;

            command.Parameters.Add("@Remarks", SqlDbType.NVarChar, 300)
                .Value = (object?)remarks ?? DBNull.Value;

            connection.Open();
            command.ExecuteNonQuery();
        }

        // =========================================
        // UPDATE DELIVERY STATUS
        // =========================================
        public void SetStatus(
            int deliveryId,
            string newStatus,
            int? changedBy,
            string? remarks)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_Delivery_SetStatus", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@DeliveryId", SqlDbType.Int)
                .Value = deliveryId;

            command.Parameters.Add("@NewStatus", SqlDbType.NVarChar, 30)
                .Value = newStatus;

            command.Parameters.Add("@ChangedBy", SqlDbType.Int)
                .Value = (object?)changedBy ?? DBNull.Value;

            command.Parameters.Add("@Remarks", SqlDbType.NVarChar, 300)
                .Value = (object?)remarks ?? DBNull.Value;

            connection.Open();
            command.ExecuteNonQuery();
        }

        // =========================================
        // SEARCH DELIVERIES
        // =========================================
        public DataTable Search(string search)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_Delivery_Search", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Search", SqlDbType.NVarChar, 100)
                .Value = search;

            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        // =========================================
        // GET APPROVED REQUISITIONS
        // =========================================
        public DataTable GetApprovedRequests()
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_Delivery_GetApprovedRequests", connection);

            command.CommandType = CommandType.StoredProcedure;

            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        // =========================================
        // GET DELIVERY PERSONNEL
        // =========================================
        public DataTable GetPersonnel()
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_Delivery_GetPersonnel", connection);

            command.CommandType = CommandType.StoredProcedure;

            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        // =========================================
        // GET DELIVERY STATUS HISTORY
        // =========================================
        public DataTable GetHistory(int deliveryId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_Delivery_GetHistory", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@DeliveryId", SqlDbType.Int)
                .Value = deliveryId;

            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);
            return table;
        }
    }
}
