using System;
using System.Drawing;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Purchasing
{
    public partial class PurchaseOrderForm : Form
    {
        public PurchaseOrderForm()
        {
            InitializeComponent();

            Load += PurchaseOrderForm_Load;
            dgvPurchaseOrders.SelectionChanged += DgvPurchaseOrders_SelectionChanged;
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

        private void PurchaseOrderForm_Load(object? sender, EventArgs e)
        {
            ConfigureGrid();
            UpdateRowActionButtons();
        }

        private void DgvPurchaseOrders_SelectionChanged(object? sender, EventArgs e)
        {
            UpdateRowActionButtons();
        }

        private void UpdateRowActionButtons()
        {
            bool hasSelection =
                dgvPurchaseOrders.CurrentRow != null &&
                dgvPurchaseOrders.SelectedRows.Count > 0;

            btnViewDetails.Enabled = hasSelection;
            btnEditPurchaseOrder.Enabled = hasSelection;
            btnPrintPurchaseOrder.Enabled = hasSelection;
        }

        private void ConfigureGrid()
        {
            dgvPurchaseOrders.ReadOnly = true;
            dgvPurchaseOrders.AllowUserToAddRows = false;
            dgvPurchaseOrders.AllowUserToDeleteRows = false;
            dgvPurchaseOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPurchaseOrders.MultiSelect = false;
            dgvPurchaseOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvPurchaseOrders.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 248);
            dgvPurchaseOrders.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkSlateGray;
            dgvPurchaseOrders.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvPurchaseOrders.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 242, 242);
            dgvPurchaseOrders.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvPurchaseOrders.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 252, 252);
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