using System;
using System.Drawing;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Purchasing
{
    public partial class QuotationsForm : Form
    {
        public QuotationsForm()
        {
            InitializeComponent();

            Load += QuotationsForm_Load;
            dgvQuotations.SelectionChanged += DgvQuotations_SelectionChanged;
        }

        public void PrepareForDashboard()
        {
            panel1.Visible = false;

            panel3.Visible = true;
            panel3.Dock = DockStyle.Top;
            panel3.Height = 65;

            panel4.Dock = DockStyle.Fill;

            PerformLayout();
        }

        private void QuotationsForm_Load(object? sender, EventArgs e)
        {
            ConfigureGrid();
            UpdateRowActionButtons();
        }

        private void DgvQuotations_SelectionChanged(object? sender, EventArgs e)
        {
            UpdateRowActionButtons();
        }

        private void UpdateRowActionButtons()
        {
            bool hasSelection =
                dgvQuotations.CurrentRow != null &&
                dgvQuotations.SelectedRows.Count > 0;

            btnViewDetails.Enabled = hasSelection;
            btnEditQuotation.Enabled = hasSelection;
            btnPrintQuotation.Enabled = hasSelection;
        }

        private void ConfigureGrid()
        {
            dgvQuotations.ReadOnly = true;
            dgvQuotations.AllowUserToAddRows = false;
            dgvQuotations.AllowUserToDeleteRows = false;
            dgvQuotations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuotations.MultiSelect = false;
            dgvQuotations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvQuotations.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 248);
            dgvQuotations.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkSlateGray;
            dgvQuotations.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvQuotations.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 242, 242);
            dgvQuotations.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvQuotations.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 252, 252);
        }

        private void btnDashboard_Click(object? sender, EventArgs e) { }
        private void btnSuppliers_Click(object? sender, EventArgs e) { }
        private void btnPurchaseRequest_Click(object? sender, EventArgs e) { }
        private void btnQuotations_Click(object? sender, EventArgs e) { }
        private void btnPurchaseOrder_Click(object? sender, EventArgs e) { }
        private void btnPurchaseHistory_Click(object? sender, EventArgs e) { }

        private void btnNewQuotation_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("New Quotation form will be implemented next.");
        }

        private void btnSelectSupplier_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Supplier selection will be implemented next.");
        }

        private void btnPrintQuotation_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Quotation printing will be implemented next.");
        }

        private void btnViewDetails_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Quotation details will be implemented next.");
        }

        private void btnEditQuotation_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Quotation editing will be implemented next.");
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "Quotation search will be connected to the database.",
                "Search Quotations",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            // Search functionality will be connected to the repository.
        }
    }
}