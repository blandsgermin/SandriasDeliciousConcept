using System;
using System.Data;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Delivery
{
    public partial class DeliveryPersonnelForm : Form
    {
        private readonly DeliveryService _deliveryService;
        private DataTable? _personnelTable;

        public DeliveryPersonnelForm()
        {
            InitializeComponent();

            _deliveryService = new DeliveryService();

            txtSearch.TextChanged += txtSearch_TextChanged;
            btnRefresh.Click += btnRefresh_Click;

            LoadPersonnel();
        }

        private void LoadPersonnel()
        {
            try
            {
                _personnelTable = _deliveryService.GetDeliveryPersonnel();

                DisplayPersonnel(_personnelTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load delivery personnel.\n\n" + ex.Message,
                    "Delivery Personnel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                dgvPersonnel.DataSource = null;
                lblPersonnelCount.Text = "0 personnel";
            }
        }

        private void DisplayPersonnel(DataTable source)
        {
            DataTable filteredTable = source.Clone();

            string searchText = txtSearch.Text.Trim();

            foreach (DataRow row in source.Rows)
            {
                string userId = Convert.ToString(row["UserId"]) ?? string.Empty;
                string fullName = Convert.ToString(row["FullName"]) ?? string.Empty;
                string username = Convert.ToString(row["Username"]) ?? string.Empty;
                string role = Convert.ToString(row["Role"]) ?? string.Empty;

                bool matches =
                    searchText.Length == 0 ||
                    userId.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    fullName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    username.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    role.Contains(searchText, StringComparison.OrdinalIgnoreCase);

                if (matches)
                {
                    filteredTable.ImportRow(row);
                }
            }

            dgvPersonnel.DataSource = filteredTable;

            ConfigureGridColumns();

            lblPersonnelCount.Text =
                filteredTable.Rows.Count == 1
                    ? "1 personnel"
                    : $"{filteredTable.Rows.Count} personnel";
        }

        private void ConfigureGridColumns()
        {
            if (dgvPersonnel.Columns.Count == 0)
                return;

            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Hide any extra columns that shouldn't appear in the personnel table
            foreach (DataGridViewColumn col in dgvPersonnel.Columns)
            {
                if (col.Name != "UserId" &&
                    col.Name != "FullName" &&
                    col.Name != "Username" &&
                    col.Name != "Role")
                {
                    col.Visible = false;
                }
            }

            SetColumn("UserId", "PERSONNEL ID", 0, 15f);
            SetColumn("FullName", "FULL NAME", 1, 35f);
            SetColumn("Username", "USERNAME", 2, 25f);
            SetColumn("Role", "ROLE", 3, 25f);
        }

        private void SetColumn(string columnName, string headerText, int displayIndex, float fillWeight)
        {
            if (!dgvPersonnel.Columns.Contains(columnName))
                return;

            DataGridViewColumn col = dgvPersonnel.Columns[columnName];
            col.Visible = true;
            col.HeaderText = headerText;
            col.DisplayIndex = displayIndex;
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col.FillWeight = fillWeight;
            col.MinimumWidth = 100;
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            if (_personnelTable != null)
            {
                DisplayPersonnel(_personnelTable);
            }
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadPersonnel();
        }
    }
}