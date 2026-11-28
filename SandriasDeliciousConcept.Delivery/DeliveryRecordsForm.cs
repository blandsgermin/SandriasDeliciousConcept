using System;
using System.Data;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Delivery
{
    public partial class DeliveryRecordsForm : Form
    {
        private readonly DeliveryService _deliveryService;
        private DataTable? _recordsTable;

        public DeliveryRecordsForm()
        {
            InitializeComponent();

            _deliveryService = new DeliveryService();

            cmbStatus.Items.AddRange(new object[]
            {
                "Scheduled",
                "Preparing",
                "Out for Delivery",
                "Delivered",
                "Cancelled"
            });

            cmbStatus.SelectedIndex = 0;

            txtSearch.TextChanged += txtSearch_TextChanged;
            btnRefresh.Click += btnRefresh_Click;
            btnUpdateStatus.Click += btnUpdateStatus_Click;

            LoadRecords();
        }

        private void LoadRecords()
        {
            try
            {
                _recordsTable = _deliveryService.GetAllDeliveries();
                DisplayRecords(_recordsTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load delivery records.\n\n" + ex.Message,
                    "Delivery Records",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                dgvRecords.DataSource = null;
                lblRecordCount.Text = "0 delivery records";
            }
        }

        private void DisplayRecords(DataTable source)
        {
            dgvRecords.DataSource = source;

            ConfigureGrid();

            lblRecordCount.Text =
                source.Rows.Count == 1
                    ? "1 delivery record"
                    : $"{source.Rows.Count} delivery records";
        }

        private void ConfigureGrid()
        {
            dgvRecords.AutoGenerateColumns = true;
            dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRecords.ScrollBars = ScrollBars.Both;

            foreach (DataGridViewColumn column in dgvRecords.Columns)
            {
                column.HeaderText = column.HeaderText
                    .Replace("_", " ")
                    .ToUpperInvariant();
            }

            SetColumnVisibility("DeliveryId", false);
            SetColumnVisibility("AssignedUserId", false);

            SetColumnHeader("DeliveryNumber", "DELIVERY NUMBER");
            SetColumnHeader("RfId", "REQUEST ID");
            SetColumnHeader("RfNumber", "REQUEST NUMBER");
            SetColumnHeader("Requester", "REQUESTER");
            SetColumnHeader("CustomerName", "CUSTOMER");
            SetColumnHeader("EventDate", "EVENT DATE");
            SetColumnHeader("Venue", "VENUE");
            SetColumnHeader("AssignedUserName", "ASSIGNED PERSONNEL");
            SetColumnHeader("AssignedPersonnel", "ASSIGNED PERSONNEL");
            SetColumnHeader("PersonnelRole", "PERSONNEL ROLE");
            SetColumnHeader("Vehicle", "VEHICLE");
            SetColumnHeader("ScheduledDate", "SCHEDULED DATE");
            SetColumnHeader("ActualDeliveryDate", "ACTUAL DELIVERY");
            SetColumnHeader("Status", "STATUS");
            SetColumnHeader("Remarks", "REMARKS");
            SetColumnHeader("DeliveryAddress", "DELIVERY ADDRESS");

            SetColumnFormat("EventDate", "MMM dd, yyyy");
            SetColumnFormat("ScheduledDate", "MMM dd, yyyy hh:mm tt");
            SetColumnFormat("ActualDeliveryDate", "MMM dd, yyyy hh:mm tt");
        }

        private void SetColumnVisibility(string name, bool visible)
        {
            if (dgvRecords.Columns.Contains(name))
            {
                DataGridViewColumn? column = dgvRecords.Columns[name];
                if (column != null)
                    column.Visible = visible;
            }
        }

        private void SetColumnHeader(string name, string header)
        {
            if (dgvRecords.Columns.Contains(name))
            {
                DataGridViewColumn? column = dgvRecords.Columns[name];
                if (column != null)
                    column.HeaderText = header;
            }
        }

        private void SetColumnFormat(string name, string format)
        {
            if (dgvRecords.Columns.Contains(name))
            {
                DataGridViewColumn? column = dgvRecords.Columns[name];
                if (column != null)
                    column.DefaultCellStyle.Format = format;
            }
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            try
            {
                DataTable results = string.IsNullOrWhiteSpace(searchText)
                    ? _deliveryService.GetAllDeliveries()
                    : _deliveryService.SearchDeliveries(searchText);

                _recordsTable = results;
                DisplayRecords(results);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to search delivery records.\n\n" + ex.Message,
                    "Delivery Records",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadRecords();
        }

        private void btnUpdateStatus_Click(object? sender, EventArgs e)
        {
            if (dgvRecords.CurrentRow == null ||
                dgvRecords.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Please select a delivery record first.",
                    "Update Delivery Status",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a delivery status.",
                    "Update Delivery Status",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            object? idValue =
                dgvRecords.CurrentRow.Cells["DeliveryId"].Value;

            if (idValue == null || idValue == DBNull.Value)
            {
                MessageBox.Show(
                    "The selected delivery ID is unavailable.",
                    "Update Delivery Status",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int deliveryId = Convert.ToInt32(idValue);
            string newStatus = cmbStatus.SelectedItem.ToString() ?? string.Empty;
            string remarks = txtStatusRemarks.Text.Trim();

            DialogResult confirmation = MessageBox.Show(
                $"Change the selected delivery status to '{newStatus}'?",
                "Confirm Status Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
                return;

            try
            {
                _deliveryService.UpdateDeliveryStatus(
                    deliveryId,
                    newStatus,
                    null,
                    string.IsNullOrWhiteSpace(remarks) ? null : remarks);

                MessageBox.Show(
                    "Delivery status updated successfully.",
                    "Delivery Records",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtStatusRemarks.Clear();
                LoadRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update delivery status.\n\n" + ex.Message,
                    "Delivery Records",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}