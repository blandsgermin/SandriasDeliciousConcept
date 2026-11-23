using System;
using System.Data;
using System.Windows.Forms;
using SandriasDeliciousConcept.Data;
using Microsoft.Data.SqlClient;

namespace SandriasDeliciousConcept.Purchasing
{
    public partial class PurchasingDashboard : Form
    {
        public PurchasingDashboard()
        {
            InitializeComponent();

            Load += PurchasingDashboard_Load;
        }

        private void PurchasingDashboard_Load(object sender, EventArgs e)
        {
            dgvInventoryOverview.AutoGenerateColumns = true;
            dgvRecentActivities.AutoGenerateColumns = true;
            dgvRequisitionMonitoring.AutoGenerateColumns = true;
        }

        private void PurchasingDashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            using (SupplierForm supplierForm = new SupplierForm())
            {
                supplierForm.ShowDialog(this);
            }
        }
            
        private void btnPurchaseRequests_Click(object sender, EventArgs e)
        {

        }

        private void btnQuotations_Click(object sender, EventArgs e)
        {

        }

        private void btnPurchaseOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnPurchaseHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
