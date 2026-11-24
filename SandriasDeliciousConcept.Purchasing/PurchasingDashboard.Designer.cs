using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SandriasDeliciousConcept.Purchasing
{
    partial class PurchasingDashboard : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            pnlInventoryShortages = new Panel();
            label6 = new Label();
            label11 = new Label();
            pnlPendingRequisitions = new Panel();
            label10 = new Label();
            label5 = new Label();
            pnlActivePO = new Panel();
            label12 = new Label();
            label7 = new Label();
            pnlAwaitingDeliveries = new Panel();
            label13 = new Label();
            label8 = new Label();
            label9 = new Label();
            dgvInventoryOverview = new DataGridView();
            label14 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequisitionMonitoring).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentActivities).BeginInit();
            pnlInventoryShortages.SuspendLayout();
            pnlPendingRequisitions.SuspendLayout();
            pnlActivePO.SuspendLayout();
            pnlAwaitingDeliveries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryOverview).BeginInit();
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 996);
            panel1.TabIndex = 0;
            // 
            // btnPurchaseHistory
            // 
            btnPurchaseHistory.FlatAppearance.BorderSize = 0;
            btnPurchaseHistory.FlatStyle = FlatStyle.Flat;
            btnPurchaseHistory.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnPurchaseHistory.ForeColor = Color.White;
            btnPurchaseHistory.Location = new Point(0, 559);
            btnPurchaseHistory.Margin = new Padding(3, 2, 3, 2);
            btnPurchaseHistory.Name = "btnPurchaseHistory";
            btnPurchaseHistory.Size = new Size(227, 45);
            btnPurchaseHistory.TabIndex = 7;
            btnPurchaseHistory.Text = "Purchase History";
            btnPurchaseHistory.UseVisualStyleBackColor = true;
            // 
            // btnPurchaseOrders
            // 
            btnPurchaseOrders.FlatAppearance.BorderSize = 0;
            btnPurchaseOrders.FlatStyle = FlatStyle.Flat;
            btnPurchaseOrders.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnPurchaseOrders.ForeColor = Color.White;
            btnPurchaseOrders.Location = new Point(0, 508);
            btnPurchaseOrders.Margin = new Padding(3, 2, 3, 2);
            btnPurchaseOrders.Name = "btnPurchaseOrders";
            btnPurchaseOrders.Size = new Size(227, 45);
            btnPurchaseOrders.TabIndex = 6;
            btnPurchaseOrders.Text = "Purchase Order";
            btnPurchaseOrders.UseVisualStyleBackColor = true;
            // 
            // btnQuotations
            // 
            btnQuotations.FlatAppearance.BorderSize = 0;
            btnQuotations.FlatStyle = FlatStyle.Flat;
            btnQuotations.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnQuotations.ForeColor = Color.White;
            btnQuotations.Location = new Point(0, 458);
            btnQuotations.Margin = new Padding(3, 2, 3, 2);
            btnQuotations.Name = "btnQuotations";
            btnQuotations.Size = new Size(227, 45);
            btnQuotations.TabIndex = 5;
            btnQuotations.Text = "Quotations";
            btnQuotations.UseVisualStyleBackColor = true;
            // 
            // btnPurchaseRequests
            // 
            btnPurchaseRequests.FlatAppearance.BorderSize = 0;
            btnPurchaseRequests.FlatStyle = FlatStyle.Flat;
            btnPurchaseRequests.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnPurchaseRequests.ForeColor = Color.White;
            btnPurchaseRequests.Location = new Point(3, 408);
            btnPurchaseRequests.Margin = new Padding(3, 2, 3, 2);
            btnPurchaseRequests.Name = "btnPurchaseRequests";
            btnPurchaseRequests.Size = new Size(227, 45);
            btnPurchaseRequests.TabIndex = 4;
            btnPurchaseRequests.Text = "Purchase Request";
            btnPurchaseRequests.UseVisualStyleBackColor = true;
            // 
            // btnSuppliers
            // 
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(0, 358);
            btnSuppliers.Margin = new Padding(3, 2, 3, 2);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(227, 45);
            btnSuppliers.TabIndex = 3;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Teal;
            btnDashboard.BackgroundImageLayout = ImageLayout.None;
            btnDashboard.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 308);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(227, 45);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 198);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Delicious Concept";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 135);
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
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1337, 75);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(15, 49);
            label4.Name = "label4";
            label4.Size = new Size(388, 20);
            label4.TabIndex = 1;
            label4.Text = "Monitor purchasing, inventory, requisitions and deliveries.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(6, 2);
            label3.Name = "label3";
            label3.Size = new Size(188, 45);
            label3.TabIndex = 0;
            label3.Text = "Dashboard";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(dgvRequisitionMonitoring);
            flowLayoutPanel1.Controls.Add(label16);
            flowLayoutPanel1.Controls.Add(dgvRecentActivities);
            flowLayoutPanel1.Controls.Add(label15);
            flowLayoutPanel1.Controls.Add(pnlInventoryShortages);
            flowLayoutPanel1.Controls.Add(pnlPendingRequisitions);
            flowLayoutPanel1.Controls.Add(pnlActivePO);
            flowLayoutPanel1.Controls.Add(pnlAwaitingDeliveries);
            flowLayoutPanel1.Controls.Add(label9);
            flowLayoutPanel1.Controls.Add(dgvInventoryOverview);
            flowLayoutPanel1.Controls.Add(label14);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 15F, FontStyle.Bold);
            flowLayoutPanel1.ForeColor = Color.DarkSlateGray;
            flowLayoutPanel1.Location = new Point(230, 75);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 25, 20, 25);
            flowLayoutPanel1.Size = new Size(1337, 921);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // dgvRequisitionMonitoring
            // 
            dgvRequisitionMonitoring.AllowUserToAddRows = false;
            dgvRequisitionMonitoring.AllowUserToDeleteRows = false;
            dgvRequisitionMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequisitionMonitoring.BackgroundColor = Color.White;
            dgvRequisitionMonitoring.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequisitionMonitoring.Location = new Point(23, 1096);
            dgvRequisitionMonitoring.Margin = new Padding(3, 4, 3, 4);
            dgvRequisitionMonitoring.Name = "dgvRequisitionMonitoring";
            dgvRequisitionMonitoring.ReadOnly = true;
            dgvRequisitionMonitoring.RowHeadersVisible = false;
            dgvRequisitionMonitoring.RowHeadersWidth = 51;
            dgvRequisitionMonitoring.RowTemplate.Height = 24;
            dgvRequisitionMonitoring.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequisitionMonitoring.Size = new Size(898, 272);
            dgvRequisitionMonitoring.TabIndex = 11;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(23, 1049);
            label16.Name = "label16";
            label16.Size = new Size(249, 35);
            label16.TabIndex = 10;
            label16.Text = "Request Monitoring";
            // 
            // dgvRecentActivities
            // 
            dgvRecentActivities.AllowUserToAddRows = false;
            dgvRecentActivities.AllowUserToDeleteRows = false;
            dgvRecentActivities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentActivities.BackgroundColor = Color.White;
            dgvRecentActivities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentActivities.Location = new Point(18, 568);
            dgvRecentActivities.Margin = new Padding(3, 4, 3, 4);
            dgvRecentActivities.Name = "dgvRecentActivities";
            dgvRecentActivities.ReadOnly = true;
            dgvRecentActivities.RowHeadersVisible = false;
            dgvRecentActivities.RowHeadersWidth = 51;
            dgvRecentActivities.RowTemplate.Height = 24;
            dgvRecentActivities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentActivities.Size = new Size(903, 235);
            dgvRecentActivities.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(17, 520);
            label15.Name = "label15";
            label15.Size = new Size(328, 35);
            label15.TabIndex = 7;
            label15.Text = "Recent Purchasing Activity";
            // 
            // pnlInventoryShortages
            // 
            pnlInventoryShortages.BorderStyle = BorderStyle.FixedSingle;
            pnlInventoryShortages.Controls.Add(label6);
            pnlInventoryShortages.Controls.Add(label11);
            pnlInventoryShortages.Location = new Point(19, 28);
            pnlInventoryShortages.Margin = new Padding(3, 2, 3, 2);
            pnlInventoryShortages.Name = "pnlInventoryShortages";
            pnlInventoryShortages.Size = new Size(220, 130);
            pnlInventoryShortages.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 9);
            label6.Name = "label6";
            label6.Size = new Size(172, 23);
            label6.TabIndex = 0;
            label6.Text = "Inventory Shortages";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 25F, FontStyle.Bold);
            label11.Location = new Point(72, 38);
            label11.Name = "label11";
            label11.Size = new Size(73, 57);
            label11.TabIndex = 1;
            label11.Text = "05";
            // 
            // pnlPendingRequisitions
            // 
            pnlPendingRequisitions.BorderStyle = BorderStyle.FixedSingle;
            pnlPendingRequisitions.Controls.Add(label10);
            pnlPendingRequisitions.Controls.Add(label5);
            pnlPendingRequisitions.Location = new Point(245, 28);
            pnlPendingRequisitions.Margin = new Padding(3, 2, 3, 2);
            pnlPendingRequisitions.Name = "pnlPendingRequisitions";
            pnlPendingRequisitions.Size = new Size(220, 130);
            pnlPendingRequisitions.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(84, 48);
            label10.Name = "label10";
            label10.Size = new Size(73, 57);
            label10.TabIndex = 1;
            label10.Text = "08";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 9);
            label5.Name = "label5";
            label5.Size = new Size(177, 23);
            label5.TabIndex = 0;
            label5.Text = "Pending Requisitions";
            // 
            // pnlActivePO
            // 
            pnlActivePO.BorderStyle = BorderStyle.FixedSingle;
            pnlActivePO.Controls.Add(label12);
            pnlActivePO.Controls.Add(label7);
            pnlActivePO.Location = new Point(471, 28);
            pnlActivePO.Margin = new Padding(3, 2, 3, 2);
            pnlActivePO.Name = "pnlActivePO";
            pnlActivePO.Size = new Size(220, 130);
            pnlActivePO.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 25F, FontStyle.Bold);
            label12.Location = new Point(73, 52);
            label12.Name = "label12";
            label12.Size = new Size(73, 57);
            label12.TabIndex = 1;
            label12.Text = "06";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 9);
            label7.Name = "label7";
            label7.Size = new Size(194, 23);
            label7.TabIndex = 0;
            label7.Text = "Active Purchase Orders";
            // 
            // pnlAwaitingDeliveries
            // 
            pnlAwaitingDeliveries.BorderStyle = BorderStyle.FixedSingle;
            pnlAwaitingDeliveries.Controls.Add(label13);
            pnlAwaitingDeliveries.Controls.Add(label8);
            pnlAwaitingDeliveries.Location = new Point(697, 28);
            pnlAwaitingDeliveries.Margin = new Padding(3, 2, 3, 2);
            pnlAwaitingDeliveries.Name = "pnlAwaitingDeliveries";
            pnlAwaitingDeliveries.Size = new Size(220, 130);
            pnlAwaitingDeliveries.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 25F, FontStyle.Bold);
            label13.Location = new Point(72, 52);
            label13.Name = "label13";
            label13.Size = new Size(73, 57);
            label13.TabIndex = 1;
            label13.Text = "03";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 9);
            label8.Name = "label8";
            label8.Size = new Size(166, 23);
            label8.TabIndex = 0;
            label8.Text = "Awaiting Deliveries";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(17, 169);
            label9.Name = "label9";
            label9.Size = new Size(250, 35);
            label9.TabIndex = 4;
            label9.Text = "Inventory Overview";
            // 
            // dgvInventoryOverview
            // 
            dgvInventoryOverview.AllowUserToAddRows = false;
            dgvInventoryOverview.AllowUserToDeleteRows = false;
            dgvInventoryOverview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventoryOverview.BackgroundColor = Color.White;
            dgvInventoryOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventoryOverview.Location = new Point(18, 215);
            dgvInventoryOverview.Margin = new Padding(3, 2, 3, 2);
            dgvInventoryOverview.MultiSelect = false;
            dgvInventoryOverview.Name = "dgvInventoryOverview";
            dgvInventoryOverview.ReadOnly = true;
            dgvInventoryOverview.RowHeadersVisible = false;
            dgvInventoryOverview.RowHeadersWidth = 51;
            dgvInventoryOverview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventoryOverview.Size = new Size(903, 240);
            dgvInventoryOverview.TabIndex = 5;
            // 
            // label14
            // 
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(100, 29);
            label14.TabIndex = 9;
            // 
            // PurchasingDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1567, 996);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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
            pnlInventoryShortages.ResumeLayout(false);
            pnlInventoryShortages.PerformLayout();
            pnlPendingRequisitions.ResumeLayout(false);
            pnlPendingRequisitions.PerformLayout();
            pnlActivePO.ResumeLayout(false);
            pnlActivePO.PerformLayout();
            pnlAwaitingDeliveries.ResumeLayout(false);
            pnlAwaitingDeliveries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryOverview).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel flowLayoutPanel1;
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