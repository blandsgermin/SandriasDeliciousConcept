using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SandriasDeliciousConcept.Delivery
{
    public partial class DeliveryDashboardForm : Form
    {
        private readonly DeliveryService _deliveryService;
        private Form? _activeChildForm;
        private bool _isClearingSearch;

        private readonly Color NormalNavigationColor = Color.DarkSlateGray;
        private readonly Color SelectedNavigationColor = Color.Teal;

        public DeliveryDashboardForm()
        {
            InitializeComponent();

            _deliveryService = new DeliveryService();

            Load += DeliveryDashboardForm_Load;
            FormClosed += DeliveryDashboardForm_FormClosed;
            dgvDeliveries.SelectionChanged += DgvDeliveries_SelectionChanged;
        }

        private void DeliveryDashboardForm_Load(object? sender, EventArgs e)
        {
            ConfigureGrid();
            ShowDashboard();
        }

        private void DeliveryDashboardForm_FormClosed(
            object? sender,
            FormClosedEventArgs e)
        {
            CloseActiveChildForm();
        }

        private void DgvDeliveries_SelectionChanged(object? sender, EventArgs e)
        {
            UpdateRowActionButtons();
        }

        private void UpdateRowActionButtons()
        {
            bool hasSelection =
                dgvDeliveries.CurrentRow != null &&
                dgvDeliveries.SelectedRows.Count > 0;

            btnUpdateStatus.Enabled = hasSelection;
        }

        private void ConfigureGrid()
        {
            dgvDeliveries.ReadOnly = true;
            dgvDeliveries.AllowUserToAddRows = false;
            dgvDeliveries.AllowUserToDeleteRows = false;
            dgvDeliveries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeliveries.MultiSelect = false;

            // Use AllCells + Both scrollbars so wide 15-column tables never truncate headers
            dgvDeliveries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDeliveries.ScrollBars = ScrollBars.Both;
        }

        private void SetActiveNavigationButton(Button selectedButton)
        {
            Button[] navigationButtons =
            {
                btnDashboard,
                btnPersonnel,
                btnApprovedRequests,
                btnDeliverySchedule,
                btnDeliveryRecords,
                btnDeliveryHistory
            };

            foreach (Button button in navigationButtons)
            {
                button.BackColor = NormalNavigationColor;
                button.ForeColor = Color.White;
            }

            selectedButton.BackColor = SelectedNavigationColor;
            selectedButton.ForeColor = Color.White;
        }

        // =========================================================
        // DASHBOARD
        // =========================================================

        private void ShowDashboard()
        {
            CloseActiveChildForm();

            navigationHost.Visible = false;

            headerPanel.Visible = true;
            summaryPanel.Visible = true;
            toolbarPanel.Visible = true;
            contentPanel.Visible = true;

            SetActiveNavigationButton(btnDashboard);

            _isClearingSearch = true;
            txtSearch.Clear();
            _isClearingSearch = false;

            LoadDeliveries();
        }

        private void LoadDeliveries()
        {
            try
            {
                DataTable deliveries = _deliveryService.GetAllDeliveries();

                DisplayDeliveries(deliveries);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load delivery records.\n\n" + ex.Message,
                    "Delivery Dashboard",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DisplayDeliveries(DataTable deliveries)
        {
            dgvDeliveries.DataSource = deliveries;

            FormatGridColumns();
            UpdateSummary(deliveries);
            UpdateRowActionButtons();
        }

        private void FormatGridColumns()
        {
            SetColumnVisibility("DeliveryId", false);
            SetColumnVisibility("AssignedUserId", false);

            SetColumnHeader("DeliveryNumber", "Delivery Number");
            SetColumnHeader("RfId", "Request ID");
            SetColumnHeader("RfNumber", "RF Number");
            SetColumnHeader("CustomerName", "Customer Name");
            SetColumnHeader("EventDate", "Event Date");
            SetColumnHeader("AssignedUserName", "Assigned Personnel");
            SetColumnHeader("PersonnelRole", "Personnel Role");
            SetColumnHeader("ScheduledDate", "Scheduled Date");
            SetColumnHeader("ActualDeliveryDate", "Actual Delivery");
            SetColumnHeader("DeliveryAddress", "Delivery Address");

            SetColumnFormat("EventDate", "MMM dd, yyyy");
            SetColumnFormat("ScheduledDate", "MMM dd, yyyy");
            SetColumnFormat("ActualDeliveryDate", "MMM dd, yyyy");
        }

        private void SetColumnVisibility(string columnName, bool visible)
        {
            if (dgvDeliveries.Columns.Contains(columnName))
            {
                dgvDeliveries.Columns[columnName].Visible = visible;
            }
        }

        private void SetColumnHeader(string columnName, string header)
        {
            if (dgvDeliveries.Columns.Contains(columnName))
            {
                dgvDeliveries.Columns[columnName].HeaderText = header;
            }
        }

        private void SetColumnFormat(string columnName, string format)
        {
            if (dgvDeliveries.Columns.Contains(columnName))
            {
                dgvDeliveries.Columns[columnName]
                    .DefaultCellStyle.Format = format;
            }
        }

        private void UpdateSummary(DataTable deliveries)
        {
            int scheduledCount = 0;
            int preparingCount = 0;
            int outForDeliveryCount = 0;
            int deliveredCount = 0;

            foreach (DataRow row in deliveries.Rows)
            {
                if (!deliveries.Columns.Contains("Status"))
                    continue;

                string status = Convert.ToString(row["Status"]) ?? "";

                switch (status.Trim())
                {
                    case "Scheduled":
                        scheduledCount++;
                        break;

                    case "Preparing":
                        preparingCount++;
                        break;

                    case "Out for Delivery":
                        outForDeliveryCount++;
                        break;

                    case "Delivered":
                        deliveredCount++;
                        break;
                }
            }

            lblScheduled.Text = scheduledCount.ToString("00");
            lblPreparing.Text = preparingCount.ToString("00");
            lblOutForDelivery.Text = outForDeliveryCount.ToString("00");
            lblDelivered.Text = deliveredCount.ToString("00");
        }

        // =========================================================
        // SEARCH AND REFRESH
        // =========================================================

        private void PerformSearch()
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadDeliveries();
                return;
            }

            try
            {
                DataTable results =
                    _deliveryService.SearchDeliveries(searchText);

                DisplayDeliveries(results);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to search delivery records.\n\n" + ex.Message,
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            if (_isClearingSearch)
                return;

            PerformSearch();
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            PerformSearch();
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            _isClearingSearch = true;
            txtSearch.Clear();
            _isClearingSearch = false;

            LoadDeliveries();
        }

        // =========================================================
        // NAVIGATION
        // =========================================================

        private void OpenChildForm(Form childForm, Button navButton)
        {
            CloseActiveChildForm();

            headerPanel.Visible = false;
            summaryPanel.Visible = false;
            toolbarPanel.Visible = false;
            contentPanel.Visible = false;

            navigationHost.Controls.Clear();
            navigationHost.Visible = true;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            navigationHost.Controls.Add(childForm);

            _activeChildForm = childForm;

            childForm.Show();

            navigationHost.BringToFront();

            SetActiveNavigationButton(navButton);
        }

        private void CloseActiveChildForm()
        {
            if (_activeChildForm == null)
                return;

            Form childForm = _activeChildForm;
            _activeChildForm = null;

            navigationHost.Controls.Remove(childForm);

            childForm.Close();
            childForm.Dispose();

            navigationHost.Controls.Clear();
        }

        private void btnDashboard_Click(object? sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void btnPersonnel_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new DeliveryPersonnelForm(), btnPersonnel);
        }

        private void btnApprovedRequests_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new ApprovedRequestsForm(), btnApprovedRequests);
        }

        private void btnDeliverySchedule_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new DeliveryScheduleForm(), btnDeliverySchedule);
        }

        private void btnDeliveryRecords_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new DeliveryRecordsForm(), btnDeliveryRecords);
        }

        private void btnDeliveryHistory_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new DeliveryHistoryForm(), btnDeliveryHistory);
        }

        // =========================================================
        // DELIVERY ACTIONS
        // =========================================================

        private void btnSchedule_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new DeliveryScheduleForm(), btnDeliverySchedule);
        }

        private void btnUpdateStatus_Click(object? sender, EventArgs e)
        {
            if (dgvDeliveries.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a delivery record first.",
                    "Update Delivery Status",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (!dgvDeliveries.Columns.Contains("DeliveryId"))
            {
                MessageBox.Show(
                    "The selected delivery record does not contain a Delivery ID.",
                    "Update Delivery Status",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            object? idValue =
                dgvDeliveries.CurrentRow.Cells["DeliveryId"].Value;

            if (idValue == null ||
                idValue == DBNull.Value ||
                !int.TryParse(idValue.ToString(), out int deliveryId))
            {
                MessageBox.Show(
                    "Unable to identify the selected delivery.",
                    "Update Delivery Status",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string newStatus = Interaction.InputBox(
                "Enter the new delivery status:\n\n" +
                "Scheduled\n" +
                "Preparing\n" +
                "Out for Delivery\n" +
                "Delivered\n" +
                "Cancelled",
                "Update Delivery Status",
                "");

            newStatus = newStatus.Trim();

            if (string.IsNullOrWhiteSpace(newStatus))
                return;

            string[] validStatuses =
            {
                "Scheduled",
                "Preparing",
                "Out for Delivery",
                "Delivered",
                "Cancelled"
            };

            bool validStatus = false;

            foreach (string status in validStatuses)
            {
                if (string.Equals(
                    status,
                    newStatus,
                    StringComparison.OrdinalIgnoreCase))
                {
                    newStatus = status;
                    validStatus = true;
                    break;
                }
            }

            if (!validStatus)
            {
                MessageBox.Show(
                    "Invalid status. Please enter one of the listed statuses.",
                    "Invalid Status",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult confirmation = MessageBox.Show(
                "Update the selected delivery to '" + newStatus + "'?",
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
                    "Status updated from Delivery Dashboard.");

                MessageBox.Show(
                    "Delivery status updated successfully.",
                    "Delivery Dashboard",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDeliveries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update delivery status.\n\n" + ex.Message,
                    "Update Status Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}