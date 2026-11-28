using System;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Purchasing
{
    public partial class PurchaseOrderForm : Form
    {
        public PurchaseOrderForm()
        {
            InitializeComponent();
        }

        public void PrepareForDashboard()
        {
            panel1.Visible = false;

            panel2.Visible = true;
            panel2.Dock = DockStyle.Right;

            panel3.Dock = DockStyle.Top;
            panel4.Dock = DockStyle.Fill;

            PerformLayout();
        }

        // NAVIGATION
        // Navigation is handled by the main Purchasing Dashboard.

        private void btnDashboard_Click(object? sender, EventArgs e) { }
        private void btnSuppliers_Click(object? sender, EventArgs e) { }
        private void btnPurchaseRequest_Click(object? sender, EventArgs e) { }
        private void btnQuotations_Click(object? sender, EventArgs e) { }
        private void btnPurchaseOrder_Click(object? sender, EventArgs e) { }
        private void btnPurchaseHistory_Click(object? sender, EventArgs e) { }

        // QUICK ACTIONS

        private void btnNewPurchaseOrder_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("New Purchase Order form will be implemented next.");
        }

        private void btnSelectQuotation_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Quotation selection will be implemented next.");
        }

        private void btnPrintPurchaseOrder_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Purchase Order printing will be implemented next.");
        }

        private void btnViewDetails_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Purchase Order details will be implemented next.");
        }

        private void btnEditPurchaseOrder_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Purchase Order editing will be implemented next.");
        }

        // SEARCH

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "Purchase Order search will be connected to the database.",
                "Search Purchase Orders",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            // Search functionality will be connected to the repository.
        }
    }
}
