
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
                bool matches =
                    searchText.Length == 0 ||
                    row["UserId"].ToString()!.Contains(
                        searchText,
                        StringComparison.OrdinalIgnoreCase) ||
                    row["FullName"].ToString()!.Contains(
                        searchText,
                        StringComparison.OrdinalIgnoreCase) ||
                    row["Username"].ToString()!.Contains(
                        searchText,
                        StringComparison.OrdinalIgnoreCase) ||
                    row["Role"].ToString()!.Contains(
                        searchText,
                        StringComparison.OrdinalIgnoreCase);

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

            if (dgvPersonnel.Columns.Contains("UserId"))
            {
                dgvPersonnel.Columns["UserId"].HeaderText = "PERSONNEL ID";
                dgvPersonnel.Columns["UserId"].DisplayIndex = 0;
                dgvPersonnel.Columns["UserId"].Width = 120;
            }

            if (dgvPersonnel.Columns.Contains("FullName"))
            {
                dgvPersonnel.Columns["FullName"].HeaderText = "FULL NAME";
                dgvPersonnel.Columns["FullName"].DisplayIndex = 1;
                dgvPersonnel.Columns["FullName"].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
            }

            if (dgvPersonnel.Columns.Contains("Username"))
            {
                dgvPersonnel.Columns["Username"].HeaderText = "USERNAME";
                dgvPersonnel.Columns["Username"].DisplayIndex = 2;
                dgvPersonnel.Columns["Username"].Width = 180;
            }

            if (dgvPersonnel.Columns.Contains("Role"))
            {
                dgvPersonnel.Columns["Role"].HeaderText = "ROLE";
                dgvPersonnel.Columns["Role"].DisplayIndex = 3;
                dgvPersonnel.Columns["Role"].Width = 160;
            }
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
