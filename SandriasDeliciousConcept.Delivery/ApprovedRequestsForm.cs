using System;
using System.Data;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Delivery
{
    public partial class ApprovedRequestsForm : Form
    {
        private readonly DeliveryService _deliveryService;
        private DataTable? _requestsTable;

        public ApprovedRequestsForm()
        {
            InitializeComponent();

            _deliveryService = new DeliveryService();

            txtSearch.TextChanged += txtSearch_TextChanged;
            btnRefresh.Click += btnRefresh_Click;

            LoadApprovedRequests();
        }

        private void LoadApprovedRequests()
        {
            try
            {
                _requestsTable = _deliveryService.GetApprovedRequests();
                DisplayRequests(_requestsTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load approved requests.\n\n" + ex.Message,
                    "Approved Requests",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                dgvApprovedRequests.DataSource = null;
                lblRequestCount.Text = "0 approved requests";
            }
        }

        private void DisplayRequests(DataTable source)
        {
            DataTable filteredTable = source.Clone();
            string searchText = txtSearch.Text.Trim();

            foreach (DataRow row in source.Rows)
            {
                bool matches = searchText.Length == 0;

                if (!matches)
                {
                    foreach (DataColumn column in source.Columns)
                    {
                        string value = Convert.ToString(row[column]) ?? string.Empty;

                        if (value.Contains(
                            searchText,
                            StringComparison.OrdinalIgnoreCase))
                        {
                            matches = true;
                            break;
                        }
                    }
                }

                if (matches)
                {
                    filteredTable.ImportRow(row);
                }
            }

            dgvApprovedRequests.DataSource = filteredTable;

            ConfigureGrid();

            lblRequestCount.Text =
                filteredTable.Rows.Count == 1
                    ? "1 approved request"
                    : $"{filteredTable.Rows.Count} approved requests";
        }

        private void ConfigureGrid()
        {
            if (dgvApprovedRequests.Columns.Count == 0)
                return;

            dgvApprovedRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn column in dgvApprovedRequests.Columns)
            {
                column.HeaderText = column.HeaderText
                    .Replace("_", " ")
                    .ToUpperInvariant();
                column.MinimumWidth = 95;
            }

            SetColumn("RfId", "REQUEST ID", 0, 10f);
            SetColumn("RfNumber", "RF NUMBER", 1, 13f);
            SetColumn("Requester", "REQUESTER", 2, 15f);
            SetColumn("CustomerName", "CUSTOMER NAME", 3, 18f);
            SetColumn("EventDate", "EVENT DATE", 4, 12f, "MMM dd, yyyy");
            SetColumn("Venue", "VENUE", 5, 14f);
            SetColumn("RequiredDate", "REQUIRED DATE", 6, 12f, "MMM dd, yyyy");
            SetColumn("Status", "STATUS", 7, 11f);
        }

        private void SetColumn(
            string columnName,
            string headerText,
            int displayIndex,
            float fillWeight,
            string? dateFormat = null)
        {
            if (!dgvApprovedRequests.Columns.Contains(columnName))
                return;

            DataGridViewColumn? column = dgvApprovedRequests.Columns[columnName];
            if (column == null)
                return;

            column.HeaderText = headerText;
            column.DisplayIndex = displayIndex;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column.FillWeight = fillWeight;

            if (!string.IsNullOrEmpty(dateFormat))
            {
                column.DefaultCellStyle.Format = dateFormat;
            }
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            if (_requestsTable != null)
            {
                DisplayRequests(_requestsTable);
            }
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadApprovedRequests();
        }
    }
}