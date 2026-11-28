using System;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Purchasing
{
    public partial class QuotationsForm : Form
    {
        public QuotationsForm()
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
