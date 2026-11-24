
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SandriasDeliciousConcept.Data
{
    public class PurchaseRequestRepository
    {
        private readonly string _connectionString =
            DatabaseInitializer.AppConnection;

        // ADD PURCHASE REQUEST
        public int Add(
            string prNumber,
            string? requisitionReference,
            string requestedBy,
            DateTime requestDate,
            DateTime? requiredDate,
            string? purpose,
            decimal? estimatedBudget)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseRequest_Add", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@PRNumber", SqlDbType.NVarChar, 60).Value = prNumber;
            command.Parameters.Add("@RequisitionReference", SqlDbType.NVarChar, 100).Value =
                (object?)requisitionReference ?? DBNull.Value;
            command.Parameters.Add("@RequestedBy", SqlDbType.NVarChar, 200).Value = requestedBy;
            command.Parameters.Add("@RequestDate", SqlDbType.DateTime).Value = requestDate;
            command.Parameters.Add("@RequiredDate", SqlDbType.Date).Value =
                (object?)requiredDate ?? DBNull.Value;
            command.Parameters.Add("@Purpose", SqlDbType.NVarChar, 500).Value =
                (object?)purpose ?? DBNull.Value;

            var budgetParameter = command.Parameters.Add(
                "@EstimatedBudget", SqlDbType.Decimal);
            budgetParameter.Precision = 12;
            budgetParameter.Scale = 2;
            budgetParameter.Value = (object?)estimatedBudget ?? DBNull.Value;

            var outputParameter = command.Parameters.Add(
                "@NewPurchaseRequestID", SqlDbType.Int);
            outputParameter.Direction = ParameterDirection.Output;

            connection.Open();
            command.ExecuteNonQuery();

            return Convert.ToInt32(outputParameter.Value);
        }

        // GET ALL PURCHASE REQUESTS
        public DataTable GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseRequest_GetAll", connection);

            command.CommandType = CommandType.StoredProcedure;

            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        // GET PURCHASE REQUEST AND ITS ITEMS
        public DataSet GetById(int purchaseRequestID)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseRequest_GetById", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@PurchaseRequestID", SqlDbType.Int).Value =
                purchaseRequestID;

            using var adapter = new SqlDataAdapter(command);
            var dataSet = new DataSet();

            adapter.Fill(dataSet);
            return dataSet;
        }

        // SEARCH PURCHASE REQUESTS
        public DataTable Search(string searchText)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseRequest_Search", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@SearchText", SqlDbType.NVarChar, 200).Value =
                searchText ?? string.Empty;

            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        // UPDATE PURCHASE REQUEST
        public void Update(
            int purchaseRequestID,
            string? requisitionReference,
            string requestedBy,
            DateTime? requiredDate,
            string? purpose,
            decimal? estimatedBudget)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseRequest_Update", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@PurchaseRequestID", SqlDbType.Int).Value =
                purchaseRequestID;
            command.Parameters.Add("@RequisitionReference", SqlDbType.NVarChar, 100).Value =
                (object?)requisitionReference ?? DBNull.Value;
            command.Parameters.Add("@RequestedBy", SqlDbType.NVarChar, 200).Value =
                requestedBy;
            command.Parameters.Add("@RequiredDate", SqlDbType.Date).Value =
                (object?)requiredDate ?? DBNull.Value;
            command.Parameters.Add("@Purpose", SqlDbType.NVarChar, 500).Value =
                (object?)purpose ?? DBNull.Value;

            var budgetParameter = command.Parameters.Add(
                "@EstimatedBudget", SqlDbType.Decimal);
            budgetParameter.Precision = 12;
            budgetParameter.Scale = 2;
            budgetParameter.Value = (object?)estimatedBudget ?? DBNull.Value;

            connection.Open();
            command.ExecuteNonQuery();
        }

        // CHANGE PURCHASE REQUEST STATUS
        public void SetStatus(int purchaseRequestID, string requestStatus)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseRequest_SetStatus", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@PurchaseRequestID", SqlDbType.Int).Value =
                purchaseRequestID;
            command.Parameters.Add("@RequestStatus", SqlDbType.NVarChar, 30).Value =
                requestStatus;

            connection.Open();
            command.ExecuteNonQuery();
        }

        // DELETE PURCHASE REQUEST
        public void Delete(int purchaseRequestID)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseRequest_Delete", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@PurchaseRequestID", SqlDbType.Int).Value =
                purchaseRequestID;

            connection.Open();
            command.ExecuteNonQuery();
        }

        // ADD PURCHASE REQUEST ITEM
        public void AddItem(
            int purchaseRequestID,
            string? itemCode,
            string itemName,
            decimal quantity,
            string unit,
            decimal? estimatedUnitPrice,
            string? remarks)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseRequestItem_Add", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@PurchaseRequestID", SqlDbType.Int).Value =
                purchaseRequestID;
            command.Parameters.Add("@ItemCode", SqlDbType.NVarChar, 100).Value =
                (object?)itemCode ?? DBNull.Value;
            command.Parameters.Add("@ItemName", SqlDbType.NVarChar, 300).Value =
                itemName;

            var quantityParameter = command.Parameters.Add(
                "@Quantity", SqlDbType.Decimal);
            quantityParameter.Precision = 12;
            quantityParameter.Scale = 2;
            quantityParameter.Value = quantity;

            command.Parameters.Add("@Unit", SqlDbType.NVarChar, 60).Value = unit;

            var priceParameter = command.Parameters.Add(
                "@EstimatedUnitPrice", SqlDbType.Decimal);
            priceParameter.Precision = 12;
            priceParameter.Scale = 2;
            priceParameter.Value = (object?)estimatedUnitPrice ?? DBNull.Value;

            command.Parameters.Add("@Remarks", SqlDbType.NVarChar, 500).Value =
                (object?)remarks ?? DBNull.Value;

            connection.Open();
            command.ExecuteNonQuery();
        }

        // GET ITEMS FOR A PURCHASE REQUEST
        public DataTable GetItems(int purchaseRequestID)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseRequestItem_GetByRequest", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@PurchaseRequestID", SqlDbType.Int).Value =
                purchaseRequestID;

            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        // DELETE PURCHASE REQUEST ITEM
        public void DeleteItem(int requestItemID)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "dbo.usp_PurchaseRequestItem_Delete", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@RequestItemID", SqlDbType.Int).Value =
                requestItemID;

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
