
using System;
using System.Drawing;
using System.Windows.Forms;
using SandriasDeliciousConcept.Data;

namespace SandriasDeliciousConcept.Purchasing
{
    public partial class PurchasingDashboard : Form
    {
        // Panel where child forms will appear
        private Panel? contentHost;

        // Currently displayed child form
        private Form? activeChildForm;

        public PurchasingDashboard()
        {
            InitializeComponent();

            InitializeContentHost();

            Load += PurchasingDashboard_Load;
        }

        private void PurchasingDashboard_Load(object? sender, EventArgs e)
        {
            dgvInventoryOverview.AutoGenerateColumns = true;
            dgvRecentActivities.AutoGenerateColumns = true;
            dgvRequisitionMonitoring.AutoGenerateColumns = true;
        }

        private void InitializeContentHost()
        {
            contentHost = new Panel
            {
                Name = "contentHost",
                BackColor = Color.WhiteSmoke,
                Location = flowLayoutPanel1.Location,
                Size = flowLayoutPanel1.Size,
                Anchor = flowLayoutPanel1.Anchor
            };

            // Hide the original dashboard content
            flowLayoutPanel1.Visible = false;

            // Add the panel to the dashboard
            Controls.Add(contentHost);

            // Keep sidebar and header visible
            contentHost.BringToFront();
            panel1.BringToFront();
            panel2.BringToFront();
        }

        private void OpenChildForm(Form childForm)
        {
            if (contentHost == null)
                return;

            // Close previous child form
            if (activeChildForm != null)
            {
                activeChildForm.Close();
                activeChildForm.Dispose();
                activeChildForm = null;
            }

            contentHost.Controls.Clear();

            // Configure child form for embedding
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            contentHost.Controls.Add(childForm);

            activeChildForm = childForm;

            childForm.Show();
            childForm.BringToFront();
        }

        private void btnSuppliers_Click(object? sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();

            supplierForm.PrepareForDashboard();

            OpenChildForm(supplierForm);
        }

        private void btnPurchaseRequests_Click(object? sender, EventArgs e)
        {
        }

        private void btnQuotations_Click(object? sender, EventArgs e)
        {
        }

        private void btnPurchaseOrders_Click(object? sender, EventArgs e)
        {
        }

        private void btnPurchaseHistory_Click(object? sender, EventArgs e)
        {
        }
    }
}
