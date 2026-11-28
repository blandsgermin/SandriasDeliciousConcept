using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Delivery
{
    public partial class DeliveryHistoryForm : Form
    {
        private readonly DeliveryService _deliveryService;
        private DataTable? _deliveryTable;

        public DeliveryHistoryForm()
        {
            InitializeComponent();

            _deliveryService = new DeliveryService();

            ConfigureGrid();
            LoadDeliveries();

            cmbDelivery.SelectedIndexChanged += cmbDelivery_SelectedIndexChanged;
            btnRefresh.Click += btnRefresh_Click;
        }

        private void LoadDeliveries()
        {
            try
            {
                _deliveryTable = _deliveryService.GetAllDeliveries();

                cmbDelivery.DataSource = null;
                cmbDelivery.DisplayMember = "DeliveryNumber";
                cmbDelivery.ValueMember = "DeliveryId";
                cmbDelivery.DataSource = _deliveryTable;
                cmbDelivery.SelectedIndex = -1;

                dgvHistory.DataSource = null;
                lblHistoryCount.Text = "0 history records";
                lblHistoryInfo.Text = _deliveryTable.Rows.Count == 0
                    ? "No delivery records are available."
                    : "Select a delivery to view its status history.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load delivery records.\n\n" + ex.Message,
                    "Delivery History",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                cmbDelivery.DataSource = null;
                dgvHistory.DataSource = null;
                lblHistoryCount.Text = "0 history records";
                lblHistoryInfo.Text = "Unable to load delivery records.";
            }
        }

        private void ConfigureGrid()
        {
            dgvHistory.AutoGenerateColumns = true;
            dgvHistory.ReadOnly = true;
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AllowUserToResizeRows = false;
            dgvHistory.MultiSelect = false;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.White;
            dgvHistory.BorderStyle = BorderStyle.FixedSingle;
            dgvHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.ColumnHeadersHeight = 42;
            dgvHistory.RowTemplate.Height = 38;

            dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistory.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvHistory.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvHistory.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(215, 235, 235);
            dgvHistory.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(30, 60, 60);
            dgvHistory.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(247, 250, 250);
        }

        private void cmbDelivery_SelectedIndexChanged(
            object? sender,
            EventArgs e)
        {
            if (cmbDelivery.SelectedValue == null ||
                cmbDelivery.SelectedValue == DBNull.Value ||
                cmbDelivery.SelectedValue is DataRowView)
            {
                dgvHistory.DataSource = null;
                lblHistoryCount.Text = "0 history records";
                lblHistoryInfo.Text = "Select a delivery to view its status history.";
                return;
            }

            if (!int.TryParse(
                Convert.ToString(cmbDelivery.SelectedValue),
                out int deliveryId))
            {
                return;
            }

            LoadHistory(deliveryId);
        }

        private void LoadHistory(int deliveryId)
        {
            try
            {
                DataTable history =
                    _deliveryService.GetDeliveryHistory(deliveryId);

                dgvHistory.DataSource = history;

                FormatHistoryGrid();

                lblHistoryCount.Text =
                    history.Rows.Count == 1
                        ? "1 history record"
                        : $"{history.Rows.Count} history records";

                lblHistoryInfo.Text =
                    history.Rows.Count == 0
                        ? "No status history is available for this delivery yet."
                        : "Status changes for the selected delivery.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load delivery history.\n\n" + ex.Message,
                    "Delivery History",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                dgvHistory.DataSource = null;
                lblHistoryCount.Text = "0 history records";
                lblHistoryInfo.Text = "Unable to load delivery history.";
            }
        }

        private void FormatHistoryGrid()
        {
            if (dgvHistory.Columns.Count == 0)
                return;

            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            SetColumnVisibility("HistoryId", false);
            SetColumnVisibility("DeliveryId", false);

            SetColumn("PreviousStatus", "PREVIOUS STATUS", 0, 16f);
            SetColumn("NewStatus", "NEW STATUS", 1, 16f);
            SetColumn("ChangedByName", "CHANGED BY", 2, 18f);
            SetColumn("ChangedAt", "DATE AND TIME", 3, 20f, "MMM dd, yyyy hh:mm tt");
            SetColumn("Remarks", "REMARKS", 4, 30f);
        }

        private void SetColumnVisibility(string name, bool visible)
        {
            if (dgvHistory.Columns.Contains(name))
            {
                DataGridViewColumn? column = dgvHistory.Columns[name];
                if (column != null)
                    column.Visible = visible;
            }
        }

        private void SetColumn(
            string name,
            string header,
            int displayIndex,
            float fillWeight,
            string? dateFormat = null)
        {
            if (!dgvHistory.Columns.Contains(name))
                return;

            DataGridViewColumn? column = dgvHistory.Columns[name];
            if (column == null)
                return;

            column.HeaderText = header;
            column.DisplayIndex = displayIndex;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column.FillWeight = fillWeight;
            column.MinimumWidth = 110;

            if (!string.IsNullOrEmpty(dateFormat))
            {
                column.DefaultCellStyle.Format = dateFormat;
            }
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            int? selectedDeliveryId = null;

            if (cmbDelivery.SelectedValue != null &&
                cmbDelivery.SelectedValue != DBNull.Value &&
                int.TryParse(
                    Convert.ToString(cmbDelivery.SelectedValue),
                    out int deliveryId))
            {
                selectedDeliveryId = deliveryId;
            }

            LoadDeliveries();

            if (selectedDeliveryId.HasValue && _deliveryTable != null)
            {
                foreach (DataRow row in _deliveryTable.Rows)
                {
                    if (Convert.ToInt32(row["DeliveryId"]) ==
                        selectedDeliveryId.Value)
                    {
                        cmbDelivery.SelectedValue = selectedDeliveryId.Value;
                        LoadHistory(selectedDeliveryId.Value);
                        break;
                    }
                }
            }
        }
    }
}