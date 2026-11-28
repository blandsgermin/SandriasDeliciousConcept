
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Delivery
{
    public partial class DeliveryDashboardForm : Form
    {
        private readonly DeliveryService _deliveryService;
        private bool _isClearingSearch;

        private Panel? _navigationHost;
        private Form? _activeChildForm;

        public DeliveryDashboardForm()
        {
            InitializeComponent();

            _deliveryService = new DeliveryService();

            ConfigureDeliveryGrid();
            InitializeNavigationHost();

            // Dashboard buttons
            btnRefresh.Click += btnRefresh_Click;
            btnSchedule.Click += btnSchedule_Click;
            btnUpdateStatus.Click += btnUpdateStatus_Click;

            // Search
            txtSearch.TextChanged += txtSearch_TextChanged;

            // Sidebar navigation
            btnDashboard.Click += btnDashboard_Click;
            btnPersonnel.Click += btnPersonnel_Click;
            btnApprovedRequests.Click += btnApprovedRequests_Click;
            btnDeliverySchedule.Click += btnDeliverySchedule_Click;
            btnDeliveryRecords.Click += btnDeliveryRecords_Click;
            btnDeliveryHistory.Click += btnDeliveryHistory_Click;

            mainPanel.Resize += mainPanel_Resize;

            LoadDeliveries();
        }

        // ==========================================
        // NAVIGATION HOST
        // ==========================================

        private void InitializeNavigationHost()
        {
            _navigationHost = new Panel
            {
                Name = "navigationHost",
                BackColor = Color.White,
                Visible = false
            };

            mainPanel.Controls.Add(_navigationHost);

            LayoutNavigationHost();

            _navigationHost.BringToFront();

            headerPanel.BringToFront();
            sidebarPanel.BringToFront();
        }

        private void LayoutNavigationHost()
        {
            if (_navigationHost == null)
                return;

            int top = headerPanel.Bottom;

            _navigationHost.Location = new Point(0, top);

            _navigationHost.Size = new Size(
                mainPanel.ClientSize.Width,
                Math.Max(0, mainPanel.ClientSize.Height - top));
        }

        private void mainPanel_Resize(object? sender, EventArgs e)
        {
            LayoutNavigationHost();
        }

        // ==========================================
        // OPEN CHILD FORM
        // ==========================================

        private void OpenChildForm(Form childForm)
        {
            if (_navigationHost == null)
                return;

            CloseActiveChildForm();

            // Hide the dashboard content
            summaryPanel.Visible = false;
            toolbarPanel.Visible = false;
            contentPanel.Visible = false;

            _navigationHost.Controls.Clear();
            _navigationHost.Visible = true;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            _navigationHost.Controls.Add(childForm);

            _activeChildForm = childForm;

            childForm.Show();
            childForm.BringToFront();

            _navigationHost.BringToFront();
            headerPanel.BringToFront();
            sidebarPanel.BringToFront();
        }

        // ==========================================
        // CLOSE ACTIVE CHILD FORM
        // ==========================================

        private void CloseActiveChildForm()
        {
            if (_activeChildForm != null)
            {
                _navigationHost?.Controls.Remove(_activeChildForm);

                _activeChildForm.Close();
                _activeChildForm.Dispose();

                _activeChildForm = null;
            }

            _navigationHost?.Controls.Clear();
        }

        // ==========================================
        // SHOW DASHBOARD
        // ==========================================

        private void ShowDashboard()
        {
            CloseActiveChildForm();

            if (_navigationHost != null)
                _navigationHost.Visible = false;

            summaryPanel.Visible = true;
            toolbarPanel.Visible = true;
            contentPanel.Visible = true;

            headerPanel.BringToFront();
            sidebarPanel.BringToFront();

            _isClearingSearch = true;
            txtSearch.Clear();
            _isClearingSearch = false;

            LoadDeliveries();
        }

        // ==========================================
        // CONFIGURE DELIVERY GRID
        // ==========================================

        private void ConfigureDeliveryGrid()
        {
            dgvDeliveries.AutoGenerateColumns = true;
            dgvDeliveries.ReadOnly = true;
            dgvDeliveries.AllowUserToAddRows = false;
            dgvDeliveries.AllowUserToDeleteRows = false;
            dgvDeliveries.AllowUserToResizeRows = false;

            dgvDeliveries.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvDeliveries.MultiSelect = false;
            dgvDeliveries.RowHeadersVisible = false;

            dgvDeliveries.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvDeliveries.BackgroundColor = Color.White;
            dgvDeliveries.BorderStyle = BorderStyle.None;

            dgvDeliveries.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvDeliveries.EnableHeadersVisualStyles = false;

            dgvDeliveries.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(43, 91, 92);

            dgvDeliveries.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvDeliveries.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvDeliveries.ColumnHeadersHeight = 40;

            dgvDeliveries.DefaultCellStyle.Font =
                new Font("Segoe UI", 9F);

            dgvDeliveries.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(215, 235, 232);

            dgvDeliveries.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvDeliveries.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 249, 248);

            dgvDeliveries.RowTemplate.Height = 35;
        }

        // ==========================================
        // LOAD ALL DELIVERIES
        // ==========================================

        private void LoadDeliveries()
        {
            try
            {
                DataTable deliveries =
                    _deliveryService.GetAllDeliveries();

                dgvDeliveries.DataSource = deliveries;

                UpdateSummary(deliveries);
                FormatGridColumns();
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

        // ==========================================
        // FORMAT GRID COLUMNS
        // ==========================================

        private void FormatGridColumns()
        {
            SetColumnVisibility("DeliveryId", false);
            SetColumnVisibility("AssignedUserId", false);

            SetColumnHeader("DeliveryNumber", "Delivery Number");
            SetColumnHeader("RfId", "Request ID");
            SetColumnHeader("ScheduledDate", "Scheduled Date");
            SetColumnHeader("ActualDeliveryDate", "Actual Delivery");
            SetColumnHeader("DeliveryAddress", "Delivery Address");

            SetColumnFormat("ScheduledDate", "MMM dd, yyyy");
            SetColumnFormat("ActualDeliveryDate", "MMM dd, yyyy");
        }

        private void SetColumnVisibility(
            string columnName,
            bool visible)
        {
            DataGridViewColumn? column =
                dgvDeliveries.Columns[columnName];

            if (column != null)
                column.Visible = visible;
        }

        private void SetColumnHeader(
            string columnName,
            string header)
        {
            DataGridViewColumn? column =
                dgvDeliveries.Columns[columnName];

            if (column != null)
                column.HeaderText = header;
        }

        private void SetColumnFormat(
            string columnName,
            string format)
        {
            DataGridViewColumn? column =
                dgvDeliveries.Columns[columnName];

            if (column != null)
                column.DefaultCellStyle.Format = format;
        }

        // ==========================================
        // UPDATE SUMMARY CARDS
        // ==========================================

        private void UpdateSummary(DataTable deliveries)
        {
            int scheduledCount = 0;
            int preparingCount = 0;
            int outForDeliveryCount = 0;
            int deliveredCount = 0;

            foreach (DataRow row in deliveries.Rows)
            {
                string status = "";

                if (deliveries.Columns.Contains("Status") &&
                    row["Status"] != DBNull.Value)
                {
                    status = row["Status"].ToString() ?? "";
                }

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

        // ==========================================
        // SEARCH DELIVERIES
        // ==========================================

        private void txtSearch_TextChanged(
            object? sender,
            EventArgs e)
        {
            if (_isClearingSearch)
                return;

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

                dgvDeliveries.DataSource = results;

                UpdateSummary(results);
                FormatGridColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to search delivery records.\n\n" + ex.Message,
                    "Search Deliveries",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // REFRESH BUTTON
        // ==========================================

        private void btnRefresh_Click(
            object? sender,
            EventArgs e)
        {
            _isClearingSearch = true;
            txtSearch.Clear();
            _isClearingSearch = false;

            LoadDeliveries();
        }

        // ==========================================
        // SCHEDULE DELIVERY BUTTON
        // ==========================================

        private void btnSchedule_Click(
            object? sender,
            EventArgs e)
        {
            MessageBox.Show(
                "The Schedule Delivery form will be connected next.",
                "Schedule Delivery",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ==========================================
        // UPDATE STATUS BUTTON
        // ==========================================

        private void btnUpdateStatus_Click(
            object? sender,
            EventArgs e)
        {
            if (dgvDeliveries.CurrentRow == null ||
                dgvDeliveries.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Please select a delivery record first.",
                    "Update Delivery Status",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            MessageBox.Show(
                "The Update Delivery Status form will be connected next.",
                "Update Delivery Status",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ==========================================
        // SIDEBAR NAVIGATION
        // ==========================================

        private void btnDashboard_Click(
            object? sender,
            EventArgs e)
        {
            ShowDashboard();
        }

        private void btnPersonnel_Click(
            object? sender,
            EventArgs e)
        {
            OpenChildForm(new DeliveryPersonnelForm());
        }

        private void btnApprovedRequests_Click(
            object? sender,
            EventArgs e)
        {
            ShowNavigationMessage("Approved Requests");
        }

        private void btnDeliverySchedule_Click(
            object? sender,
            EventArgs e)
        {
            ShowNavigationMessage("Delivery Schedule");
        }

        private void btnDeliveryRecords_Click(
            object? sender,
            EventArgs e)
        {
            ShowNavigationMessage("Delivery Records");
        }

        private void btnDeliveryHistory_Click(
            object? sender,
            EventArgs e)
        {
            ShowNavigationMessage("Delivery History");
        }

        // ==========================================
        // NAVIGATION MESSAGE
        // ==========================================

        private void ShowNavigationMessage(string screenName)
        {
            MessageBox.Show(
                screenName + " screen will be connected next.",
                "Delivery Management",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
