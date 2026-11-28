
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Purchasing
{
    partial class PurchaseHistoryForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;

        private Label lblSandrias;
        private Label lblDeliciousConcept;
        private Label lblQuickActions;
        private Label lblPageTitle;
        private Label lblRecordsTitle;

        private Button btnDashboard;
        private Button btnSuppliers;
        private Button btnPurchaseRequest;
        private Button btnQuotations;
        private Button btnPurchaseOrder;
        private Button btnPurchaseHistory;

        private Button btnViewDetails;
        private Button btnPrintHistory;
        private Button btnExportHistory;
        private Button btnRefresh;
        private Button btnSearch;

        private Label lblTotalPurchases;
        private Label lblTotalPurchasesValue;
        private Label lblCompletedPurchases;
        private Label lblCompletedPurchasesValue;
        private Label lblPendingPurchases;
        private Label lblPendingPurchasesValue;
        private Label lblTotalAmount;
        private Label lblTotalAmountValue;

        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridView dgvPurchaseHistory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblSandrias = new Label();
            lblDeliciousConcept = new Label();
            btnDashboard = new Button();
            btnSuppliers = new Button();
            btnPurchaseRequest = new Button();
            btnQuotations = new Button();
            btnPurchaseOrder = new Button();
            btnPurchaseHistory = new Button();
            panel2 = new Panel();
            lblQuickActions = new Label();
            btnViewDetails = new Button();
            btnPrintHistory = new Button();
            btnExportHistory = new Button();
            btnRefresh = new Button();
            panel3 = new Panel();
            lblPageTitle = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            lblTotalPurchasesValue = new Label();
            lblTotalPurchases = new Label();
            panel6 = new Panel();
            lblCompletedPurchasesValue = new Label();
            lblCompletedPurchases = new Label();
            panel8 = new Panel();
            lblPendingPurchasesValue = new Label();
            lblPendingPurchases = new Label();
            panel7 = new Panel();
            lblTotalAmountValue = new Label();
            lblTotalAmount = new Label();
            lblRecordsTitle = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvPurchaseHistory = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseHistory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(lblSandrias);
            panel1.Controls.Add(lblDeliciousConcept);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnSuppliers);
            panel1.Controls.Add(btnPurchaseRequest);
            panel1.Controls.Add(btnQuotations);
            panel1.Controls.Add(btnPurchaseOrder);
            panel1.Controls.Add(btnPurchaseHistory);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 937);
            panel1.TabIndex = 3;
            // 
            // lblSandrias
            // 
            lblSandrias.AutoSize = true;
            lblSandrias.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSandrias.ForeColor = Color.White;
            lblSandrias.Location = new Point(47, 178);
            lblSandrias.Name = "lblSandrias";
            lblSandrias.Size = new Size(156, 46);
            lblSandrias.TabIndex = 0;
            lblSandrias.Text = "Sandrias";
            // 
            // lblDeliciousConcept
            // 
            lblDeliciousConcept.AutoSize = true;
            lblDeliciousConcept.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeliciousConcept.ForeColor = Color.White;
            lblDeliciousConcept.Location = new Point(47, 226);
            lblDeliciousConcept.Name = "lblDeliciousConcept";
            lblDeliciousConcept.Size = new Size(154, 25);
            lblDeliciousConcept.TabIndex = 1;
            lblDeliciousConcept.Text = "Delicious Concept";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.DarkSlateGray;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 308);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(264, 45);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackColor = Color.DarkSlateGray;
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(0, 359);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(264, 45);
            btnSuppliers.TabIndex = 3;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = false;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnPurchaseRequest
            // 
            btnPurchaseRequest.BackColor = Color.DarkSlateGray;
            btnPurchaseRequest.FlatAppearance.BorderSize = 0;
            btnPurchaseRequest.FlatStyle = FlatStyle.Flat;
            btnPurchaseRequest.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPurchaseRequest.ForeColor = Color.White;
            btnPurchaseRequest.Location = new Point(0, 408);
            btnPurchaseRequest.Name = "btnPurchaseRequest";
            btnPurchaseRequest.Size = new Size(264, 45);
            btnPurchaseRequest.TabIndex = 4;
            btnPurchaseRequest.Text = "Purchase Request";
            btnPurchaseRequest.UseVisualStyleBackColor = false;
            btnPurchaseRequest.Click += btnPurchaseRequest_Click;
            // 
            // btnQuotations
            // 
            btnQuotations.BackColor = Color.DarkSlateGray;
            btnQuotations.FlatAppearance.BorderSize = 0;
            btnQuotations.FlatStyle = FlatStyle.Flat;
            btnQuotations.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuotations.ForeColor = Color.White;
            btnQuotations.Location = new Point(0, 458);
            btnQuotations.Name = "btnQuotations";
            btnQuotations.Size = new Size(264, 45);
            btnQuotations.TabIndex = 5;
            btnQuotations.Text = "Quotations";
            btnQuotations.UseVisualStyleBackColor = false;
            btnQuotations.Click += btnQuotations_Click;
            // 
            // btnPurchaseOrder
            // 
            btnPurchaseOrder.BackColor = Color.DarkSlateGray;
            btnPurchaseOrder.FlatAppearance.BorderSize = 0;
            btnPurchaseOrder.FlatStyle = FlatStyle.Flat;
            btnPurchaseOrder.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPurchaseOrder.ForeColor = Color.White;
            btnPurchaseOrder.Location = new Point(0, 508);
            btnPurchaseOrder.Name = "btnPurchaseOrder";
            btnPurchaseOrder.Size = new Size(264, 45);
            btnPurchaseOrder.TabIndex = 6;
            btnPurchaseOrder.Text = "Purchase Order";
            btnPurchaseOrder.UseVisualStyleBackColor = false;
            btnPurchaseOrder.Click += btnPurchaseOrder_Click;
            // 
            // btnPurchaseHistory
            // 
            btnPurchaseHistory.BackColor = Color.Teal;
            btnPurchaseHistory.FlatAppearance.BorderSize = 0;
            btnPurchaseHistory.FlatStyle = FlatStyle.Flat;
            btnPurchaseHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPurchaseHistory.ForeColor = Color.White;
            btnPurchaseHistory.Location = new Point(0, 557);
            btnPurchaseHistory.Name = "btnPurchaseHistory";
            btnPurchaseHistory.Size = new Size(264, 45);
            btnPurchaseHistory.TabIndex = 7;
            btnPurchaseHistory.Text = "Purchase History";
            btnPurchaseHistory.UseVisualStyleBackColor = false;
            btnPurchaseHistory.Click += btnPurchaseHistory_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblQuickActions);
            panel2.Controls.Add(btnViewDetails);
            panel2.Controls.Add(btnPrintHistory);
            panel2.Controls.Add(btnExportHistory);
            panel2.Controls.Add(btnRefresh);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1100, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 937);
            panel2.TabIndex = 2;
            // 
            // lblQuickActions
            // 
            lblQuickActions.AutoSize = true;
            lblQuickActions.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblQuickActions.ForeColor = Color.White;
            lblQuickActions.Location = new Point(58, 167);
            lblQuickActions.Name = "lblQuickActions";
            lblQuickActions.Size = new Size(143, 28);
            lblQuickActions.TabIndex = 0;
            lblQuickActions.Text = "Quick Actions";
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.White;
            btnViewDetails.FlatAppearance.BorderSize = 0;
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewDetails.ForeColor = Color.Black;
            btnViewDetails.Location = new Point(44, 217);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(168, 44);
            btnViewDetails.TabIndex = 1;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // btnPrintHistory
            // 
            btnPrintHistory.BackColor = Color.White;
            btnPrintHistory.FlatAppearance.BorderSize = 0;
            btnPrintHistory.FlatStyle = FlatStyle.Flat;
            btnPrintHistory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrintHistory.ForeColor = Color.Black;
            btnPrintHistory.Location = new Point(44, 285);
            btnPrintHistory.Name = "btnPrintHistory";
            btnPrintHistory.Size = new Size(168, 44);
            btnPrintHistory.TabIndex = 2;
            btnPrintHistory.Text = "Print History";
            btnPrintHistory.UseVisualStyleBackColor = false;
            btnPrintHistory.Click += btnPrintHistory_Click;
            // 
            // btnExportHistory
            // 
            btnExportHistory.BackColor = Color.White;
            btnExportHistory.FlatAppearance.BorderSize = 0;
            btnExportHistory.FlatStyle = FlatStyle.Flat;
            btnExportHistory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportHistory.ForeColor = Color.Black;
            btnExportHistory.Location = new Point(44, 346);
            btnExportHistory.Name = "btnExportHistory";
            btnExportHistory.Size = new Size(168, 44);
            btnExportHistory.TabIndex = 3;
            btnExportHistory.Text = "Export History";
            btnExportHistory.UseVisualStyleBackColor = false;
            btnExportHistory.Click += btnExportHistory_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(44, 407);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(168, 44);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh Records";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblPageTitle);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(263, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(837, 76);
            panel3.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.DarkSlateGray;
            lblPageTitle.Location = new Point(0, 12);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(283, 45);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Purchase History";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(lblRecordsTitle);
            panel4.Controls.Add(lblSearch);
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(dgvPurchaseHistory);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(263, 76);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(17, 20, 17, 20);
            panel4.Size = new Size(837, 861);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(240, 235, 248);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblTotalPurchasesValue);
            panel5.Controls.Add(lblTotalPurchases);
            panel5.Location = new Point(7, 8);
            panel5.Name = "panel5";
            panel5.Size = new Size(411, 140);
            panel5.TabIndex = 0;
            // 
            // lblTotalPurchasesValue
            // 
            lblTotalPurchasesValue.AutoSize = true;
            lblTotalPurchasesValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalPurchasesValue.ForeColor = Color.DarkSlateGray;
            lblTotalPurchasesValue.Location = new Point(23, 20);
            lblTotalPurchasesValue.Name = "lblTotalPurchasesValue";
            lblTotalPurchasesValue.Size = new Size(43, 50);
            lblTotalPurchasesValue.TabIndex = 0;
            lblTotalPurchasesValue.Text = "0";
            // 
            // lblTotalPurchases
            // 
            lblTotalPurchases.AutoSize = true;
            lblTotalPurchases.Font = new Font("Segoe UI", 9F);
            lblTotalPurchases.ForeColor = Color.DimGray;
            lblTotalPurchases.Location = new Point(26, 91);
            lblTotalPurchases.Name = "lblTotalPurchases";
            lblTotalPurchases.Size = new Size(161, 20);
            lblTotalPurchases.TabIndex = 1;
            lblTotalPurchases.Text = "Total Purchase Records";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(232, 245, 237);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(lblCompletedPurchasesValue);
            panel6.Controls.Add(lblCompletedPurchases);
            panel6.Location = new Point(425, 8);
            panel6.Name = "panel6";
            panel6.Size = new Size(405, 140);
            panel6.TabIndex = 1;
            // 
            // lblCompletedPurchasesValue
            // 
            lblCompletedPurchasesValue.AutoSize = true;
            lblCompletedPurchasesValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblCompletedPurchasesValue.ForeColor = Color.DarkSlateGray;
            lblCompletedPurchasesValue.Location = new Point(23, 20);
            lblCompletedPurchasesValue.Name = "lblCompletedPurchasesValue";
            lblCompletedPurchasesValue.Size = new Size(43, 50);
            lblCompletedPurchasesValue.TabIndex = 0;
            lblCompletedPurchasesValue.Text = "0";
            // 
            // lblCompletedPurchases
            // 
            lblCompletedPurchases.AutoSize = true;
            lblCompletedPurchases.Font = new Font("Segoe UI", 9F);
            lblCompletedPurchases.ForeColor = Color.DimGray;
            lblCompletedPurchases.Location = new Point(26, 91);
            lblCompletedPurchases.Name = "lblCompletedPurchases";
            lblCompletedPurchases.Size = new Size(151, 20);
            lblCompletedPurchases.TabIndex = 1;
            lblCompletedPurchases.Text = "Completed Purchases";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(234, 242, 248);
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(lblPendingPurchasesValue);
            panel8.Controls.Add(lblPendingPurchases);
            panel8.Location = new Point(7, 156);
            panel8.Name = "panel8";
            panel8.Size = new Size(411, 140);
            panel8.TabIndex = 2;
            // 
            // lblPendingPurchasesValue
            // 
            lblPendingPurchasesValue.AutoSize = true;
            lblPendingPurchasesValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblPendingPurchasesValue.ForeColor = Color.DarkSlateGray;
            lblPendingPurchasesValue.Location = new Point(23, 20);
            lblPendingPurchasesValue.Name = "lblPendingPurchasesValue";
            lblPendingPurchasesValue.Size = new Size(43, 50);
            lblPendingPurchasesValue.TabIndex = 0;
            lblPendingPurchasesValue.Text = "0";
            // 
            // lblPendingPurchases
            // 
            lblPendingPurchases.AutoSize = true;
            lblPendingPurchases.Font = new Font("Segoe UI", 9F);
            lblPendingPurchases.ForeColor = Color.DimGray;
            lblPendingPurchases.Location = new Point(26, 91);
            lblPendingPurchases.Name = "lblPendingPurchases";
            lblPendingPurchases.Size = new Size(130, 20);
            lblPendingPurchases.TabIndex = 1;
            lblPendingPurchases.Text = "Pending Purchases";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 244, 223);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(lblTotalAmountValue);
            panel7.Controls.Add(lblTotalAmount);
            panel7.Location = new Point(424, 156);
            panel7.Name = "panel7";
            panel7.Size = new Size(406, 140);
            panel7.TabIndex = 3;
            // 
            // lblTotalAmountValue
            // 
            lblTotalAmountValue.AutoSize = true;
            lblTotalAmountValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalAmountValue.ForeColor = Color.DarkSlateGray;
            lblTotalAmountValue.Location = new Point(23, 20);
            lblTotalAmountValue.Name = "lblTotalAmountValue";
            lblTotalAmountValue.Size = new Size(119, 50);
            lblTotalAmountValue.TabIndex = 0;
            lblTotalAmountValue.Text = "₱0.00";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 9F);
            lblTotalAmount.ForeColor = Color.DimGray;
            lblTotalAmount.Location = new Point(26, 91);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(161, 20);
            lblTotalAmount.TabIndex = 1;
            lblTotalAmount.Text = "Total Purchase Amount";
            // 
            // lblRecordsTitle
            // 
            lblRecordsTitle.AutoSize = true;
            lblRecordsTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblRecordsTitle.ForeColor = Color.DarkSlateGray;
            lblRecordsTitle.Location = new Point(13, 311);
            lblRecordsTitle.Name = "lblRecordsTitle";
            lblRecordsTitle.Size = new Size(312, 35);
            lblRecordsTitle.TabIndex = 4;
            lblRecordsTitle.Text = "Purchase History Records";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F);
            lblSearch.Location = new Point(13, 379);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(56, 20);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(80, 371);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(514, 30);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkSlateGray;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(613, 368);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(107, 39);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvPurchaseHistory
            // 
            dgvPurchaseHistory.AllowUserToAddRows = false;
            dgvPurchaseHistory.AllowUserToDeleteRows = false;
            dgvPurchaseHistory.AllowUserToResizeRows = false;
            dgvPurchaseHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPurchaseHistory.BackgroundColor = Color.White;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPurchaseHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPurchaseHistory.ColumnHeadersHeight = 35;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvPurchaseHistory.DefaultCellStyle = dataGridViewCellStyle8;
            dgvPurchaseHistory.EnableHeadersVisualStyles = false;
            dgvPurchaseHistory.Location = new Point(24, 437);
            dgvPurchaseHistory.MultiSelect = false;
            dgvPurchaseHistory.Name = "dgvPurchaseHistory";
            dgvPurchaseHistory.ReadOnly = true;
            dgvPurchaseHistory.RowHeadersVisible = false;
            dgvPurchaseHistory.RowHeadersWidth = 51;
            dgvPurchaseHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPurchaseHistory.Size = new Size(793, 376);
            dgvPurchaseHistory.TabIndex = 8;
            // 
            // PurchaseHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1351, 937);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "PurchaseHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase History";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseHistory).EndInit();
            ResumeLayout(false);
        }
    }
}
