using System;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Purchasing
{
    public partial class PurchaseHistoryForm : Form
    {
        public PurchaseHistoryForm()
        {
            InitializeComponent();

            Load += PurchaseHistoryForm_Load;
            dgvPurchaseHistory.SelectionChanged += DgvPurchaseHistory_SelectionChanged;
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

        private void PurchaseHistoryForm_Load(object? sender, EventArgs e)
        {
            UpdateRowActionButtons();
        }

        private void DgvPurchaseHistory_SelectionChanged(object? sender, EventArgs e)
        {
            UpdateRowActionButtons();
        }

        private void UpdateRowActionButtons()
        {
            bool hasSelection =
                dgvPurchaseHistory.CurrentRow != null &&
                dgvPurchaseHistory.SelectedRows.Count > 0;

            btnViewDetails.Enabled = hasSelection;
            btnPrintHistory.Enabled = hasSelection;
        }

        // NAVIGATION
        // Navigation is handled by the main Purchasing Dashboard.

        private void btnDashboard_Click(object? sender, EventArgs e) { }
        private void btnSuppliers_Click(object? sender, EventArgs e) { }
        private void btnPurchaseRequest_Click(object? sender, EventArgs e) { }
        private void btnQuotations_Click(object? sender, EventArgs e) { }
        private void btnPurchaseOrder_Click(object? sender, EventArgs e) { }
        private void btnPurchaseHistory_Click(object? sender, EventArgs e) { }

        // ACTIONS

        private void btnViewDetails_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "Select a purchase history record to view its details.");
        }

        private void btnPrintHistory_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "Print Purchase History functionality will be connected here.");
        }

        private void btnExportHistory_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "Export Purchase History functionality will be connected here.");
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "Refresh Purchase History functionality will be connected here.");
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "Purchase History search functionality will be connected here.");
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            // Search filtering will be connected after the repository is inspected.
        }
    }
}