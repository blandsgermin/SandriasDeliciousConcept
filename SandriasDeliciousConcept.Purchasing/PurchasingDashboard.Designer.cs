using System.Drawing;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Purchasing
{
    partial class PurchasingDashboard : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnPurchaseHistory = new Button();
            btnPurchaseOrders = new Button();
            btnQuotations = new Button();
            btnPurchaseRequests = new Button();
            btnSuppliers = new Button();
            btnDashboard = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            flowLayoutPanel1 = new Panel();
            dgvRequisitionMonitoring = new DataGridView();
            label16 = new Label();
            dgvRecentActivities = new DataGridView();
            label15 = new Label();
            dgvInventoryOverview = new DataGridView();
            label9 = new Label();
            tlpDashboardCards = new TableLayoutPanel();
            pnlInventoryShortages = new Panel();
            label11 = new Label();
            label6 = new Label();
            pnlPendingRequisitions = new Panel();
            label10 = new Label();
            label5 = new Label();
            pnlActivePO = new Panel();
            label12 = new Label();
            label7 = new Label();
            pnlAwaitingDeliveries = new Panel();
            label13 = new Label();
            label8 = new Label();
            label14 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequisitionMonitoring).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentActivities).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryOverview).BeginInit();
            tlpDashboardCards.SuspendLayout();
            pnlInventoryShortages.SuspendLayout();
            pnlPendingRequisitions.SuspendLayout();
            pnlActivePO.SuspendLayout();
            pnlAwaitingDeliveries.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(btnPurchaseHistory);
            panel1.Controls.Add(btnPurchaseOrders);
            panel1.Controls.Add(btnQuotations);
            panel1.Controls.Add(btnPurchaseRequests);
            panel1.Controls.Add(btnSuppliers);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 996);
            panel1.TabIndex = 0;
            // 
            // btnPurchaseHistory
            // 
            btnPurchaseHistory.FlatAppearance.BorderSize = 0;
            btnPurchaseHistory.FlatStyle = FlatStyle.Flat;
            btnPurchaseHistory.Font = new Font("Segoe UI", 10F);
            btnPurchaseHistory.ForeColor = Color.White;
            btnPurchaseHistory.Location = new Point(0, 470);
            btnPurchaseHistory.Name = "btnPurchaseHistory";
            btnPurchaseHistory.Size = new Size(230, 45);
            btnPurchaseHistory.TabIndex = 7;
            btnPurchaseHistory.Text = "Purchase History";
            btnPurchaseHistory.UseVisualStyleBackColor = true;
            btnPurchaseHistory.Click += btnPurchaseHistory_Click;
            // 
            // btnPurchaseOrders
            // 
            btnPurchaseOrders.FlatAppearance.BorderSize = 0;
            btnPurchaseOrders.FlatStyle = FlatStyle.Flat;
            btnPurchaseOrders.Font = new Font("Segoe UI", 10F);
            btnPurchaseOrders.ForeColor = Color.White;
            btnPurchaseOrders.Location = new Point(0, 420);
            btnPurchaseOrders.Name = "btnPurchaseOrders";
            btnPurchaseOrders.Size = new Size(230, 45);
            btnPurchaseOrders.TabIndex = 6;
            btnPurchaseOrders.Text = "Purchase Order";
            btnPurchaseOrders.UseVisualStyleBackColor = true;
            btnPurchaseOrders.Click += btnPurchaseOrders_Click;
            // 
            // btnQuotations
            // 
            btnQuotations.FlatAppearance.BorderSize = 0;
            btnQuotations.FlatStyle = FlatStyle.Flat;
            btnQuotations.Font = new Font("Segoe UI", 10F);
            btnQuotations.ForeColor = Color.White;
            btnQuotations.Location = new Point(0, 370);
            btnQuotations.Name = "btnQuotations";
            btnQuotations.Size = new Size(230, 45);
            btnQuotations.TabIndex = 5;
            btnQuotations.Text = "Quotations";
            btnQuotations.UseVisualStyleBackColor = true;
            btnQuotations.Click += btnQuotations_Click;
            // 
            // btnPurchaseRequests
            // 
            btnPurchaseRequests.FlatAppearance.BorderSize = 0;
            btnPurchaseRequests.FlatStyle = FlatStyle.Flat;
            btnPurchaseRequests.Font = new Font("Segoe UI", 10F);
            btnPurchaseRequests.ForeColor = Color.White;
            btnPurchaseRequests.Location = new Point(0, 320);
            btnPurchaseRequests.Name = "btnPurchaseRequests";
            btnPurchaseRequests.Size = new Size(230, 45);
            btnPurchaseRequests.TabIndex = 4;
            btnPurchaseRequests.Text = "Purchase Request";
            btnPurchaseRequests.UseVisualStyleBackColor = true;
            btnPurchaseRequests.Click += btnPurchaseRequests_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Segoe UI", 10F);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(0, 270);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(230, 45);
            btnSuppliers.TabIndex = 3;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.DarkSlateGray;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 220);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(230, 45);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(48, 132);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Delicious Concept";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 80);
            label1.Name = "label1";
            label1.Size = new Size(170, 50);
            label1.TabIndex = 0;
            label1.Text = "Sandrias";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(230, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1337, 75);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(22, 49);
            label4.Name = "label4";
            label4.Size = new Size(388, 20);
            label4.TabIndex = 1;
            label4.Text = "Monitor purchasing, inventory, requisitions and deliveries.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(20, 6);
            label3.Name = "label3";
            label3.Size = new Size(188, 45);
            label3.TabIndex = 0;
            label3.Text = "Dashboard";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(dgvRequisitionMonitoring);
            flowLayoutPanel1.Controls.Add(label16);
            flowLayoutPanel1.Controls.Add(dgvRecentActivities);
            flowLayoutPanel1.Controls.Add(label15);
            flowLayoutPanel1.Controls.Add(dgvInventoryOverview);
            flowLayoutPanel1.Controls.Add(label9);
            flowLayoutPanel1.Controls.Add(tlpDashboardCards);
            flowLayoutPanel1.Controls.Add(label14);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            flowLayoutPanel1.ForeColor = Color.DarkSlateGray;
            flowLayoutPanel1.Location = new Point(230, 75);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 15, 20, 25);
            flowLayoutPanel1.Size = new Size(1337, 921);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // dgvRequisitionMonitoring
            // 
            dgvRequisitionMonitoring.AllowUserToAddRows = false;
            dgvRequisitionMonitoring.AllowUserToDeleteRows = false;
            dgvRequisitionMonitoring.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvRequisitionMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequisitionMonitoring.BackgroundColor = Color.White;
            dgvRequisitionMonitoring.ColumnHeadersHeight = 36;
            dgvRequisitionMonitoring.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRequisitionMonitoring.EnableHeadersVisualStyles = false;
            dgvRequisitionMonitoring.GridColor = Color.WhiteSmoke;
            dgvRequisitionMonitoring.Location = new Point(20, 780);
            dgvRequisitionMonitoring.MultiSelect = false;
            dgvRequisitionMonitoring.Name = "dgvRequisitionMonitoring";
            dgvRequisitionMonitoring.ReadOnly = true;
            dgvRequisitionMonitoring.RowHeadersVisible = false;
            dgvRequisitionMonitoring.RowHeadersWidth = 51;
            dgvRequisitionMonitoring.RowTemplate.Height = 32;
            dgvRequisitionMonitoring.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequisitionMonitoring.Size = new Size(1297, 230);
            dgvRequisitionMonitoring.TabIndex = 11;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label16.Location = new Point(20, 740);
            label16.Name = "label16";
            label16.Size = new Size(243, 32);
            label16.TabIndex = 10;
            label16.Text = "Request Monitoring";
            // 
            // dgvRecentActivities
            // 
            dgvRecentActivities.AllowUserToAddRows = false;
            dgvRecentActivities.AllowUserToDeleteRows = false;
            dgvRecentActivities.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecentActivities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentActivities.BackgroundColor = Color.White;
            dgvRecentActivities.ColumnHeadersHeight = 36;
            dgvRecentActivities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecentActivities.EnableHeadersVisualStyles = false;
            dgvRecentActivities.GridColor = Color.WhiteSmoke;
            dgvRecentActivities.Location = new Point(20, 490);
            dgvRecentActivities.MultiSelect = false;
            dgvRecentActivities.Name = "dgvRecentActivities";
            dgvRecentActivities.ReadOnly = true;
            dgvRecentActivities.RowHeadersVisible = false;
            dgvRecentActivities.RowHeadersWidth = 51;
            dgvRecentActivities.RowTemplate.Height = 32;
            dgvRecentActivities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentActivities.Size = new Size(1297, 230);
            dgvRecentActivities.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label15.Location = new Point(20, 450);
            label15.Name = "label15";
            label15.Size = new Size(319, 32);
            label15.TabIndex = 7;
            label15.Text = "Recent Purchasing Activity";
            // 
            // dgvInventoryOverview
            // 
            dgvInventoryOverview.AllowUserToAddRows = false;
            dgvInventoryOverview.AllowUserToDeleteRows = false;
            dgvInventoryOverview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventoryOverview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventoryOverview.BackgroundColor = Color.White;
            dgvInventoryOverview.ColumnHeadersHeight = 36;
            dgvInventoryOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInventoryOverview.EnableHeadersVisualStyles = false;
            dgvInventoryOverview.GridColor = Color.WhiteSmoke;
            dgvInventoryOverview.Location = new Point(20, 200);
            dgvInventoryOverview.MultiSelect = false;
            dgvInventoryOverview.Name = "dgvInventoryOverview";
            dgvInventoryOverview.ReadOnly = true;
            dgvInventoryOverview.RowHeadersVisible = false;
            dgvInventoryOverview.RowHeadersWidth = 51;
            dgvInventoryOverview.RowTemplate.Height = 32;
            dgvInventoryOverview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventoryOverview.Size = new Size(1297, 230);
            dgvInventoryOverview.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label9.Location = new Point(20, 160);
            label9.Name = "label9";
            label9.Size = new Size(240, 32);
            label9.TabIndex = 4;
            label9.Text = "Inventory Overview";
            // 
            // tlpDashboardCards
            // 
            tlpDashboardCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpDashboardCards.ColumnCount = 4;
            tlpDashboardCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpDashboardCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpDashboardCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpDashboardCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpDashboardCards.Controls.Add(pnlInventoryShortages, 0, 0);
            tlpDashboardCards.Controls.Add(pnlPendingRequisitions, 1, 0);
            tlpDashboardCards.Controls.Add(pnlActivePO, 2, 0);
            tlpDashboardCards.Controls.Add(pnlAwaitingDeliveries, 3, 0);
            tlpDashboardCards.Location = new Point(20, 15);
            tlpDashboardCards.Name = "tlpDashboardCards";
            tlpDashboardCards.RowCount = 1;
            tlpDashboardCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDashboardCards.Size = new Size(1297, 125);
            tlpDashboardCards.TabIndex = 0;
            // 
            // pnlInventoryShortages
            // 
            pnlInventoryShortages.BackColor = Color.FromArgb(255, 244, 223);
            pnlInventoryShortages.Controls.Add(label11);
            pnlInventoryShortages.Controls.Add(label6);
            pnlInventoryShortages.Dock = DockStyle.Fill;
            pnlInventoryShortages.Location = new Point(0, 0);
            pnlInventoryShortages.Margin = new Padding(0, 0, 8, 0);
            pnlInventoryShortages.Name = "pnlInventoryShortages";
            pnlInventoryShortages.Padding = new Padding(14, 12, 14, 12);
            pnlInventoryShortages.Size = new Size(316, 125);
            pnlInventoryShortages.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(95, 65, 20);
            label11.Location = new Point(14, 14);
            label11.Name = "label11";
            label11.Size = new Size(69, 54);
            label11.TabIndex = 1;
            label11.Text = "05";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.5F);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(16, 78);
            label6.Name = "label6";
            label6.Size = new Size(150, 21);
            label6.TabIndex = 0;
            label6.Text = "Inventory Shortages";
            // 
            // pnlPendingRequisitions
            // 
            pnlPendingRequisitions.BackColor = Color.FromArgb(240, 235, 248);
            pnlPendingRequisitions.Controls.Add(label10);
            pnlPendingRequisitions.Controls.Add(label5);
            pnlPendingRequisitions.Dock = DockStyle.Fill;
            pnlPendingRequisitions.Location = new Point(332, 0);
            pnlPendingRequisitions.Margin = new Padding(8, 0, 8, 0);
            pnlPendingRequisitions.Name = "pnlPendingRequisitions";
            pnlPendingRequisitions.Padding = new Padding(14, 12, 14, 12);
            pnlPendingRequisitions.Size = new Size(308, 125);
            pnlPendingRequisitions.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(45, 45, 65);
            label10.Location = new Point(14, 14);
            label10.Name = "label10";
            label10.Size = new Size(69, 54);
            label10.TabIndex = 1;
            label10.Text = "08";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.5F);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(16, 78);
            label5.Name = "label5";
            label5.Size = new Size(155, 21);
            label5.TabIndex = 0;
            label5.Text = "Pending Requisitions";
            // 
            // pnlActivePO
            // 
            pnlActivePO.BackColor = Color.FromArgb(234, 242, 248);
            pnlActivePO.Controls.Add(label12);
            pnlActivePO.Controls.Add(label7);
            pnlActivePO.Dock = DockStyle.Fill;
            pnlActivePO.Location = new Point(656, 0);
            pnlActivePO.Margin = new Padding(8, 0, 8, 0);
            pnlActivePO.Name = "pnlActivePO";
            pnlActivePO.Padding = new Padding(14, 12, 14, 12);
            pnlActivePO.Size = new Size(308, 125);
            pnlActivePO.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(30, 55, 80);
            label12.Location = new Point(14, 14);
            label12.Name = "label12";
            label12.Size = new Size(69, 54);
            label12.TabIndex = 1;
            label12.Text = "06";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.5F);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(16, 78);
            label7.Name = "label7";
            label7.Size = new Size(171, 21);
            label7.TabIndex = 0;
            label7.Text = "Active Purchase Orders";
            // 
            // pnlAwaitingDeliveries
            // 
            pnlAwaitingDeliveries.BackColor = Color.FromArgb(232, 245, 237);
            pnlAwaitingDeliveries.Controls.Add(label13);
            pnlAwaitingDeliveries.Controls.Add(label8);
            pnlAwaitingDeliveries.Dock = DockStyle.Fill;
            pnlAwaitingDeliveries.Location = new Point(980, 0);
            pnlAwaitingDeliveries.Margin = new Padding(8, 0, 0, 0);
            pnlAwaitingDeliveries.Name = "pnlAwaitingDeliveries";
            pnlAwaitingDeliveries.Padding = new Padding(14, 12, 14, 12);
            pnlAwaitingDeliveries.Size = new Size(317, 125);
            pnlAwaitingDeliveries.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(30, 70, 50);
            label13.Location = new Point(14, 14);
            label13.Name = "label13";
            label13.Size = new Size(69, 54);
            label13.TabIndex = 1;
            label13.Text = "03";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.5F);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(16, 78);
            label8.Name = "label8";
            label8.Size = new Size(143, 21);
            label8.TabIndex = 0;
            label8.Text = "Awaiting Deliveries";
            // 
            // label14
            // 
            label14.Location = new Point(20, 1020);
            label14.Name = "label14";
            label14.Size = new Size(100, 20);
            label14.TabIndex = 9;
            // 
            // PurchasingDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1567, 996);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PurchasingDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchasing Dashboard";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequisitionMonitoring).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentActivities).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryOverview).EndInit();
            tlpDashboardCards.ResumeLayout(false);
            pnlInventoryShortages.ResumeLayout(false);
            pnlInventoryShortages.PerformLayout();
            pnlPendingRequisitions.ResumeLayout(false);
            pnlPendingRequisitions.PerformLayout();
            pnlActivePO.ResumeLayout(false);
            pnlActivePO.PerformLayout();
            pnlAwaitingDeliveries.ResumeLayout(false);
            pnlAwaitingDeliveries.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel flowLayoutPanel1;
        private TableLayoutPanel tlpDashboardCards;
        private Label label1;
        private Button btnSuppliers;
        private Button btnDashboard;
        private Label label2;
        private Button btnPurchaseHistory;
        private Button btnPurchaseOrders;
        private Button btnQuotations;
        private Button btnPurchaseRequests;
        private Label label4;
        private Label label3;
        private Panel pnlPendingRequisitions;
        private Label label5;
        private Panel pnlInventoryShortages;
        private Label label6;
        private Panel pnlActivePO;
        private Label label7;
        private Panel pnlAwaitingDeliveries;
        private Label label8;
        private Label label10;
        private Label label9;
        private DataGridView dgvInventoryOverview;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private DataGridView dgvRecentActivities;
        private DataGridView dgvRequisitionMonitoring;
        private Label label16;
    }
}