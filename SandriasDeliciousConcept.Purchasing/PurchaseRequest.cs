using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using SandriasDeliciousConcept.Data;

namespace SandriasDeliciousConcept.Purchasing
{
    public partial class PurchaseRequest : Form
    {
        private readonly PurchaseRequestRepository _repository =
            new PurchaseRequestRepository();

        private readonly PrintDocument _printDocument =
            new PrintDocument();

        private string _printContent = string.Empty;
        private bool _isDashboardMode;

        public PurchaseRequest()
        {
            InitializeComponent();

            Load += PurchaseRequest_Load;
            _printDocument.PrintPage += PrintDocument_PrintPage;
        }

        public void PrepareForDashboard()
        {
            _isDashboardMode = true;

            panel1.Visible = false;

            panel2.Visible = true;
            panel2.Dock = DockStyle.Right;
            panel2.Width = 190;

            panel3.Dock = DockStyle.Top;
            panel3.Height = 65;

            panel4.Dock = DockStyle.Fill;

            PerformLayout();
        }

        private void PurchaseRequest_Load(object? sender, EventArgs e)
        {
            ConfigureGrid();
            LoadPurchaseRequests();
        }

        private void ConfigureGrid()
        {
            dgvPurchaseRequests.ReadOnly = true;
            dgvPurchaseRequests.AllowUserToAddRows = false;
            dgvPurchaseRequests.AllowUserToDeleteRows = false;
            dgvPurchaseRequests.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvPurchaseRequests.MultiSelect = false;
            dgvPurchaseRequests.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadPurchaseRequests()
        {
            try
            {
                DataTable dt = _repository.GetAll();

                dgvPurchaseRequests.DataSource = dt;

                FormatGrid();
                UpdateSummary(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load purchase requests.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            if (dgvPurchaseRequests.Columns.Contains("PurchaseRequestID"))
                dgvPurchaseRequests.Columns["PurchaseRequestID"]!.Visible = false;

            if (dgvPurchaseRequests.Columns.Contains("PRNumber"))
                dgvPurchaseRequests.Columns["PRNumber"]!.HeaderText = "PR Number";

            if (dgvPurchaseRequests.Columns.Contains("RequestedBy"))
                dgvPurchaseRequests.Columns["RequestedBy"]!.HeaderText = "Requested By";

            if (dgvPurchaseRequests.Columns.Contains("RequestDate"))
            {
                dgvPurchaseRequests.Columns["RequestDate"]!.HeaderText = "Request Date";
                dgvPurchaseRequests.Columns["RequestDate"]!.DefaultCellStyle.Format = "MMM dd, yyyy";
            }

            if (dgvPurchaseRequests.Columns.Contains("RequiredDate"))
            {
                dgvPurchaseRequests.Columns["RequiredDate"]!.HeaderText = "Required Date";
                dgvPurchaseRequests.Columns["RequiredDate"]!.DefaultCellStyle.Format = "MMM dd, yyyy";
            }

            if (dgvPurchaseRequests.Columns.Contains("RequestStatus"))
                dgvPurchaseRequests.Columns["RequestStatus"]!.HeaderText = "Status";

            if (dgvPurchaseRequests.Columns.Contains("TotalEstimatedAmount"))
            {
                dgvPurchaseRequests.Columns["TotalEstimatedAmount"]!.HeaderText = "Estimated Amount";
                dgvPurchaseRequests.Columns["TotalEstimatedAmount"]!.DefaultCellStyle.Format = "N2";
            }
        }

        private void UpdateSummary(DataTable dt)
        {
            int total = dt.Rows.Count;
            int pending = 0;
            int approved = 0;
            int forOrdering = 0;

            foreach (DataRow row in dt.Rows)
            {
                string status =
                    dt.Columns.Contains("RequestStatus") &&
                    row["RequestStatus"] != DBNull.Value
                    ? Convert.ToString(row["RequestStatus"])?.Trim().ToLowerInvariant() ?? string.Empty
                    : string.Empty;

                if (status == "pending")
                    pending++;

                if (status == "approved")
                    approved++;

                if (status.Contains("order"))
                    forOrdering++;
            }

            label7.Text = total.ToString("00");
            label8.Text = pending.ToString("00");
            label9.Text = approved.ToString("00");
            label10.Text = forOrdering.ToString("00");
        }

        private int GetSelectedRequestID()
        {
            if (dgvPurchaseRequests.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a purchase request first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return 0;
            }

            if (!dgvPurchaseRequests.Columns.Contains("PurchaseRequestID"))
            {
                MessageBox.Show(
                    "The PurchaseRequestID column was not returned by the database.",
                    "Missing Column",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return 0;
            }

            object? value =
                dgvPurchaseRequests.CurrentRow.Cells["PurchaseRequestID"].Value;

            if (value == null ||
                value == DBNull.Value ||
                !int.TryParse(value.ToString(), out int id))
            {
                MessageBox.Show(
                    "Unable to identify the selected request.",
                    "Invalid Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return 0;
            }

            return id;
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            SearchPurchaseRequests();
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            SearchPurchaseRequests();
        }

        private void SearchPurchaseRequests()
        {
            try
            {
                string keyword = txtSearch.Text.Trim();

                DataTable dt = string.IsNullOrWhiteSpace(keyword)
                    ? _repository.GetAll()
                    : _repository.Search(keyword);

                dgvPurchaseRequests.DataSource = dt;

                FormatGrid();
                UpdateSummary(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Search failed.\n\n" + ex.Message,
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNewRequest_Click(object? sender, EventArgs e)
        {
            try
            {
                string requestedBy = Interaction.InputBox(
                    "Enter the name of the requester:",
                    "New Purchase Request",
                    "");

                if (string.IsNullOrWhiteSpace(requestedBy))
                    return;

                string purpose = Interaction.InputBox(
                    "Enter the purpose of this purchase request:",
                    "New Purchase Request",
                    "");

                string requiredDateText = Interaction.InputBox(
                    "Enter the required date (MM/dd/yyyy), or leave blank:",
                    "New Purchase Request",
                    "");

                DateTime? requiredDate = null;

                if (!string.IsNullOrWhiteSpace(requiredDateText))
                {
                    if (!DateTime.TryParse(
                        requiredDateText,
                        CultureInfo.CurrentCulture,
                        DateTimeStyles.None,
                        out DateTime parsedDate))
                    {
                        MessageBox.Show(
                            "Invalid required date. Please use MM/dd/yyyy.",
                            "Invalid Date",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    requiredDate = parsedDate;
                }

                string budgetText = Interaction.InputBox(
                    "Enter the estimated budget, or leave blank:",
                    "New Purchase Request",
                    "");

                decimal? estimatedBudget = null;

                if (!string.IsNullOrWhiteSpace(budgetText))
                {
                    if (!decimal.TryParse(
                        budgetText,
                        NumberStyles.Number,
                        CultureInfo.CurrentCulture,
                        out decimal budget) || budget < 0)
                    {
                        MessageBox.Show(
                            "Please enter a valid estimated budget.",
                            "Invalid Budget",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    estimatedBudget = budget;
                }

                string prNumber =
                    "PR-" + DateTime.Now.ToString("yyyyMMddHHmmss");

                int newRequestID = _repository.Add(
                    prNumber,
                    null,
                    requestedBy.Trim(),
                    DateTime.Now,
                    requiredDate,
                    string.IsNullOrWhiteSpace(purpose) ? null : purpose.Trim(),
                    estimatedBudget);

                if (newRequestID > 0)
                {
                    MessageBox.Show(
                        "Purchase request created successfully.\n\nPR Number: " + prNumber,
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadPurchaseRequests();
                }
                else
                {
                    MessageBox.Show(
                        "The purchase request was not created.",
                        "Save Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to create purchase request.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEditRequest_Click(object? sender, EventArgs e)
        {
            int requestID = GetSelectedRequestID();

            if (requestID == 0)
                return;

            try
            {
                DataSet ds = _repository.GetById(requestID);

                if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Purchase request not found.");
                    return;
                }

                DataRow row = ds.Tables[0].Rows[0];

                string requestedBy = GetString(row, "RequestedBy");
                string purpose = GetString(row, "Purpose");
                string requiredDateText = GetDateString(row, "RequiredDate");
                string budgetText = GetDecimalString(row, "EstimatedBudget");

                requestedBy = Interaction.InputBox(
                    "Enter the requester:",
                    "Edit Purchase Request",
                    requestedBy);

                if (string.IsNullOrWhiteSpace(requestedBy))
                    return;

                purpose = Interaction.InputBox(
                    "Enter the purpose:",
                    "Edit Purchase Request",
                    purpose);

                requiredDateText = Interaction.InputBox(
                    "Enter the required date (MM/dd/yyyy), or leave blank:",
                    "Edit Purchase Request",
                    requiredDateText);

                DateTime? requiredDate = null;

                if (!string.IsNullOrWhiteSpace(requiredDateText))
                {
                    if (!DateTime.TryParse(requiredDateText, out DateTime parsedDate))
                    {
                        MessageBox.Show("Invalid required date.");
                        return;
                    }

                    requiredDate = parsedDate;
                }

                budgetText = Interaction.InputBox(
                    "Enter the estimated budget, or leave blank:",
                    "Edit Purchase Request",
                    budgetText);

                decimal? budget = null;

                if (!string.IsNullOrWhiteSpace(budgetText))
                {
                    if (!decimal.TryParse(
                        budgetText,
                        NumberStyles.Number,
                        CultureInfo.CurrentCulture,
                        out decimal parsedBudget) || parsedBudget < 0)
                    {
                        MessageBox.Show("Please enter a valid estimated budget.");
                        return;
                    }

                    budget = parsedBudget;
                }

                _repository.Update(
                    requestID,
                    GetNullableString(row, "RequisitionReference"),
                    requestedBy.Trim(),
                    requiredDate,
                    string.IsNullOrWhiteSpace(purpose) ? null : purpose.Trim(),
                    budget);

                MessageBox.Show(
                    "Purchase request updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadPurchaseRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update purchase request.\n\n" + ex.Message,
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnViewDetails_Click(object? sender, EventArgs e)
        {
            int requestID = GetSelectedRequestID();

            if (requestID == 0)
                return;

            try
            {
                DataSet ds = _repository.GetById(requestID);

                if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Purchase request not found.");
                    return;
                }

                DataRow row = ds.Tables[0].Rows[0];

                string details =
                    "PURCHASE REQUEST DETAILS\n\n" +
                    "PR Number: " + GetString(row, "PRNumber") + "\n" +
                    "Requester: " + GetString(row, "RequestedBy") + "\n" +
                    "Request Date: " + GetDateString(row, "RequestDate") + "\n" +
                    "Required Date: " + GetDateString(row, "RequiredDate") + "\n" +
                    "Purpose: " + GetString(row, "Purpose") + "\n" +
                    "Estimated Budget: " + GetDecimalString(row, "EstimatedBudget") + "\n" +
                    "Total Estimated Amount: " + GetDecimalString(row, "TotalEstimatedAmount") + "\n" +
                    "Status: " + GetString(row, "RequestStatus") + "\n\n" +
                    "REQUEST ITEMS\n";

                if (ds.Tables.Count > 1)
                {
                    DataTable items = ds.Tables[1];

                    if (items.Rows.Count == 0)
                    {
                        details += "\nNo items recorded.";
                    }
                    else
                    {
                        foreach (DataRow item in items.Rows)
                        {
                            details +=
                                "\nItem: " + GetString(item, "ItemName") +
                                "\nItem Code: " + GetString(item, "ItemCode") +
                                "\nQuantity: " + GetDecimalString(item, "Quantity") +
                                "\nUnit: " + GetString(item, "Unit") +
                                "\nEstimated Unit Price: " + GetDecimalString(item, "EstimatedUnitPrice") +
                                "\nEstimated Subtotal: " + GetDecimalString(item, "EstimatedSubtotal") +
                                "\nRemarks: " + GetString(item, "Remarks") +
                                "\n------------------------------\n";
                        }
                    }
                }
                else
                {
                    details += "\nItem information was not returned.";
                }

                MessageBox.Show(
                    details,
                    "Purchase Request Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to retrieve request details.\n\n" + ex.Message,
                    "Details Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLoadRequisition_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "Requisition integration is not yet enabled.\n\nPurchase requests can currently be created manually.",
                "Requisition Integration",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnPrintRequest_Click(object? sender, EventArgs e)
        {
            int requestID = GetSelectedRequestID();

            if (requestID == 0)
                return;

            try
            {
                DataSet ds = _repository.GetById(requestID);

                if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Purchase request not found.");
                    return;
                }

                DataRow row = ds.Tables[0].Rows[0];

                _printContent =
                    "SANDRIA'S DELICIOUS CONCEPT\n" +
                    "PURCHASE REQUEST\n\n" +
                    "PR Number: " + GetString(row, "PRNumber") + "\n" +
                    "Requester: " + GetString(row, "RequestedBy") + "\n" +
                    "Request Date: " + GetDateString(row, "RequestDate") + "\n" +
                    "Required Date: " + GetDateString(row, "RequiredDate") + "\n" +
                    "Purpose: " + GetString(row, "Purpose") + "\n" +
                    "Estimated Budget: " + GetDecimalString(row, "EstimatedBudget") + "\n" +
                    "Total Estimated Amount: " + GetDecimalString(row, "TotalEstimatedAmount") + "\n" +
                    "Status: " + GetString(row, "RequestStatus") + "\n\n" +
                    "REQUEST ITEMS\n" +
                    "------------------------------------------\n";

                if (ds.Tables.Count > 1)
                {
                    foreach (DataRow item in ds.Tables[1].Rows)
                    {
                        _printContent +=
                            "Item: " + GetString(item, "ItemName") + "\n" +
                            "Code: " + GetString(item, "ItemCode") + "\n" +
                            "Quantity: " + GetDecimalString(item, "Quantity") + " " +
                            GetString(item, "Unit") + "\n" +
                            "Unit Price: " + GetDecimalString(item, "EstimatedUnitPrice") + "\n" +
                            "Subtotal: " + GetDecimalString(item, "EstimatedSubtotal") + "\n" +
                            "Remarks: " + GetString(item, "Remarks") + "\n" +
                            "------------------------------------------\n";
                    }
                }

                using (PrintPreviewDialog preview = new PrintPreviewDialog())
                {
                    preview.Document = _printDocument;
                    preview.Width = 900;
                    preview.Height = 700;
                    preview.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to prepare the purchase request for printing.\n\n" + ex.Message,
                    "Print Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(
            object? sender,
            PrintPageEventArgs e)
        {
            if (e.Graphics == null)
                return;

            using Font font = new Font("Arial", 10);

            e.Graphics.DrawString(
                _printContent,
                font,
                Brushes.Black,
                e.MarginBounds);
        }

        private string GetString(DataRow row, string column)
        {
            if (!row.Table.Columns.Contains(column) || row[column] == DBNull.Value)
                return string.Empty;

            return Convert.ToString(row[column]) ?? string.Empty;
        }

        private string? GetNullableString(DataRow row, string column)
        {
            if (!row.Table.Columns.Contains(column) || row[column] == DBNull.Value)
                return null;

            return Convert.ToString(row[column]);
        }

        private string GetDateString(DataRow row, string column)
        {
            if (!row.Table.Columns.Contains(column) || row[column] == DBNull.Value)
                return string.Empty;

            if (DateTime.TryParse(row[column].ToString(), out DateTime date))
                return date.ToString("MM/dd/yyyy");

            return string.Empty;
        }

        private string GetDecimalString(DataRow row, string column)
        {
            if (!row.Table.Columns.Contains(column) || row[column] == DBNull.Value)
                return string.Empty;

            if (decimal.TryParse(row[column].ToString(), out decimal value))
                return value.ToString("N2");

            return string.Empty;
        }
        private void btnDashboard_Click(object? sender, EventArgs e) { }
        private void btnSuppliers_Click(object? sender, EventArgs e) { }

        private void btnPurchaseRequest_Click(object? sender, EventArgs e)
        {
            LoadPurchaseRequests();
        }
        private void button4_Click(object? sender, EventArgs e) { }
        private void btnPurchaseOrder_Click(object? sender, EventArgs e) { }
        private void btnPurchaseHIstory_Click(object? sender, EventArgs e) { }
        private void panel4_Paint(object? sender, PaintEventArgs e) { }
        private void panel5_Paint(object? sender, PaintEventArgs e) { }
        private void panel6_Paint(object? sender, PaintEventArgs e) { }
        private void panel7_Paint(object? sender, PaintEventArgs e) { }
        private void panel8_Paint(object? sender, PaintEventArgs e) { }
    }
}
