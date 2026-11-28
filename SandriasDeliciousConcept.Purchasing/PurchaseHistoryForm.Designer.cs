using System;
using System.Drawing;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Purchasing
{
    partial class PurchaseHistoryForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tlpSummaryCards;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel pnlToolbar;

        private Label lblSandrias;
        private Label lblDeliciousConcept;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();

            panel1 = new Panel();
            lblSandrias = new Label();
            lblDeliciousConcept = new Label();
            btnDashboard = new Button();
            btnSuppliers = new Button();
            btnPurchaseRequest = new Button();
            btnQuotations = new Button();
            btnPurchaseOrder = new Button();
            btnPurchaseHistory = new Button();

            panel3 = new Panel();
            lblPageTitle = new Label();
            btnExportHistory = new Button();
            btnRefresh = new Button();

            panel4 = new Panel();
            tlpSummaryCards = new TableLayoutPanel();
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
            pnlToolbar = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnViewDetails = new Button();
            btnPrintHistory = new Button();
            dgvPurchaseHistory = new DataGridView();

            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tlpSummaryCards.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseHistory).BeginInit();
            SuspendLayout();

            // 
            // panel1 - LEFT NAVIGATION
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
            panel1.Size = new Size(230, 703);
            panel1.TabIndex = 0;

            lblSandrias.AutoSize = true;
            lblSandrias.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblSandrias.ForeColor = Color.White;
            lblSandrias.Location = new Point(30, 80);
            lblSandrias.Name = "lblSandrias";
            lblSandrias.Size = new Size(170, 50);
            lblSandrias.TabIndex = 0;
            lblSandrias.Text = "Sandrias";

            lblDeliciousConcept.AutoSize = true;
            lblDeliciousConcept.Font = new Font("Segoe UI", 10F);
            lblDeliciousConcept.ForeColor = Color.Gainsboro;
            lblDeliciousConcept.Location = new Point(48, 132);
            lblDeliciousConcept.Name = "lblDeliciousConcept";
            lblDeliciousConcept.Size = new Size(129, 23);
            lblDeliciousConcept.TabIndex = 1;
            lblDeliciousConcept.Text = "Delicious Concept";

            btnDashboard.BackColor = Color.DarkSlateGray;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 220);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(230, 45);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;

            btnSuppliers.BackColor = Color.DarkSlateGray;
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Segoe UI", 10F);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(0, 270);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(230, 45);
            btnSuppliers.TabIndex = 3;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = false;
            btnSuppliers.Click += btnSuppliers_Click;

            btnPurchaseRequest.BackColor = Color.DarkSlateGray;
            btnPurchaseRequest.FlatAppearance.BorderSize = 0;
            btnPurchaseRequest.FlatStyle = FlatStyle.Flat;
            btnPurchaseRequest.Font = new Font("Segoe UI", 10F);
            btnPurchaseRequest.ForeColor = Color.White;
            btnPurchaseRequest.Location = new Point(0, 320);
            btnPurchaseRequest.Name = "btnPurchaseRequest";
            btnPurchaseRequest.Size = new Size(230, 45);
            btnPurchaseRequest.TabIndex = 4;
            btnPurchaseRequest.Text = "Purchase Request";
            btnPurchaseRequest.UseVisualStyleBackColor = false;
            btnPurchaseRequest.Click += btnPurchaseRequest_Click;

            btnQuotations.BackColor = Color.DarkSlateGray;
            btnQuotations.FlatAppearance.BorderSize = 0;
            btnQuotations.FlatStyle = FlatStyle.Flat;
            btnQuotations.Font = new Font("Segoe UI", 10F);
            btnQuotations.ForeColor = Color.White;
            btnQuotations.Location = new Point(0, 370);
            btnQuotations.Name = "btnQuotations";
            btnQuotations.Size = new Size(230, 45);
            btnQuotations.TabIndex = 5;
            btnQuotations.Text = "Quotations";
            btnQuotations.UseVisualStyleBackColor = false;
            btnQuotations.Click += btnQuotations_Click;

            btnPurchaseOrder.BackColor = Color.DarkSlateGray;
            btnPurchaseOrder.FlatAppearance.BorderSize = 0;
            btnPurchaseOrder.FlatStyle = FlatStyle.Flat;
            btnPurchaseOrder.Font = new Font("Segoe UI", 10F);
            btnPurchaseOrder.ForeColor = Color.White;
            btnPurchaseOrder.Location = new Point(0, 420);
            btnPurchaseOrder.Name = "btnPurchaseOrder";
            btnPurchaseOrder.Size = new Size(230, 45);
            btnPurchaseOrder.TabIndex = 6;
            btnPurchaseOrder.Text = "Purchase Order";
            btnPurchaseOrder.UseVisualStyleBackColor = false;
            btnPurchaseOrder.Click += btnPurchaseOrder_Click;

            btnPurchaseHistory.BackColor = Color.Teal;
            btnPurchaseHistory.FlatAppearance.BorderSize = 0;
            btnPurchaseHistory.FlatStyle = FlatStyle.Flat;
            btnPurchaseHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPurchaseHistory.ForeColor = Color.White;
            btnPurchaseHistory.Location = new Point(0, 470);
            btnPurchaseHistory.Name = "btnPurchaseHistory";
            btnPurchaseHistory.Size = new Size(230, 45);
            btnPurchaseHistory.TabIndex = 7;
            btnPurchaseHistory.Text = "Purchase History";
            btnPurchaseHistory.UseVisualStyleBackColor = false;
            btnPurchaseHistory.Click += btnPurchaseHistory_Click;

            // 
            // panel3 - TOP HEADER WITH PRIMARY ACTIONS
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblPageTitle);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(btnExportHistory);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(230, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 12, 20, 8);
            panel3.Size = new Size(952, 65);
            panel3.TabIndex = 1;

            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.DarkSlateGray;
            lblPageTitle.Location = new Point(20, 14);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(255, 41);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Purchase History";

            btnExportHistory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportHistory.BackColor = Color.Teal;
            btnExportHistory.Cursor = Cursors.Hand;
            btnExportHistory.FlatAppearance.BorderSize = 0;
            btnExportHistory.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnExportHistory.FlatStyle = FlatStyle.Flat;
            btnExportHistory.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnExportHistory.ForeColor = Color.White;
            btnExportHistory.Location = new Point(782, 14);
            btnExportHistory.Name = "btnExportHistory";
            btnExportHistory.Size = new Size(150, 38);
            btnExportHistory.TabIndex = 1;
            btnExportHistory.Text = "Export History";
            btnExportHistory.UseVisualStyleBackColor = false;
            btnExportHistory.Click += btnExportHistory_Click;

            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.White;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.Silver;
            btnRefresh.FlatAppearance.BorderSize = 1;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 245, 245);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.5F);
            btnRefresh.ForeColor = Color.DarkSlateGray;
            btnRefresh.Location = new Point(622, 14);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 38);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh Records";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;

            // 
            // panel4 - MAIN WORKSPACE
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(dgvPurchaseHistory);
            panel4.Controls.Add(pnlToolbar);
            panel4.Controls.Add(lblRecordsTitle);
            panel4.Controls.Add(tlpSummaryCards);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(230, 65);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 5, 20, 20);
            panel4.Size = new Size(952, 638);
            panel4.TabIndex = 2;

            // 
            // tlpSummaryCards - RESPONSIVE 2x2 KPI GRID
            // 
            tlpSummaryCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpSummaryCards.ColumnCount = 2;
            tlpSummaryCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSummaryCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSummaryCards.Controls.Add(panel5, 0, 0);
            tlpSummaryCards.Controls.Add(panel6, 1, 0);
            tlpSummaryCards.Controls.Add(panel8, 0, 1);
            tlpSummaryCards.Controls.Add(panel7, 1, 1);
            tlpSummaryCards.Location = new Point(20, 5);
            tlpSummaryCards.Name = "tlpSummaryCards";
            tlpSummaryCards.RowCount = 2;
            tlpSummaryCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSummaryCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSummaryCards.Size = new Size(912, 210);
            tlpSummaryCards.TabIndex = 0;

            // panel5 - TOTAL PURCHASE RECORDS
            panel5.BackColor = Color.FromArgb(240, 235, 248);
            panel5.Controls.Add(lblTotalPurchasesValue);
            panel5.Controls.Add(lblTotalPurchases);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0, 0, 8, 8);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(14, 10, 14, 10);
            panel5.Size = new Size(448, 97);
            panel5.TabIndex = 0;

            lblTotalPurchasesValue.AutoSize = true;
            lblTotalPurchasesValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalPurchasesValue.ForeColor = Color.FromArgb(45, 45, 65);
            lblTotalPurchasesValue.Location = new Point(14, 10);
            lblTotalPurchasesValue.Name = "lblTotalPurchasesValue";
            lblTotalPurchasesValue.Size = new Size(43, 50);
            lblTotalPurchasesValue.TabIndex = 0;
            lblTotalPurchasesValue.Text = "0";

            lblTotalPurchases.AutoSize = true;
            lblTotalPurchases.Font = new Font("Segoe UI", 9.5F);
            lblTotalPurchases.ForeColor = Color.DimGray;
            lblTotalPurchases.Location = new Point(16, 64);
            lblTotalPurchases.Name = "lblTotalPurchases";
            lblTotalPurchases.Size = new Size(165, 21);
            lblTotalPurchases.TabIndex = 1;
            lblTotalPurchases.Text = "Total Purchase Records";

            // panel6 - COMPLETED PURCHASES
            panel6.BackColor = Color.FromArgb(232, 245, 237);
            panel6.Controls.Add(lblCompletedPurchasesValue);
            panel6.Controls.Add(lblCompletedPurchases);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(464, 0);
            panel6.Margin = new Padding(8, 0, 0, 8);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(14, 10, 14, 10);
            panel6.Size = new Size(448, 97);
            panel6.TabIndex = 1;

            lblCompletedPurchasesValue.AutoSize = true;
            lblCompletedPurchasesValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblCompletedPurchasesValue.ForeColor = Color.FromArgb(30, 70, 50);
            lblCompletedPurchasesValue.Location = new Point(14, 10);
            lblCompletedPurchasesValue.Name = "lblCompletedPurchasesValue";
            lblCompletedPurchasesValue.Size = new Size(43, 50);
            lblCompletedPurchasesValue.TabIndex = 0;
            lblCompletedPurchasesValue.Text = "0";

            lblCompletedPurchases.AutoSize = true;
            lblCompletedPurchases.Font = new Font("Segoe UI", 9.5F);
            lblCompletedPurchases.ForeColor = Color.DimGray;
            lblCompletedPurchases.Location = new Point(16, 64);
            lblCompletedPurchases.Name = "lblCompletedPurchases";
            lblCompletedPurchases.Size = new Size(155, 21);
            lblCompletedPurchases.TabIndex = 1;
            lblCompletedPurchases.Text = "Completed Purchases";

            // panel8 - PENDING PURCHASES
            panel8.BackColor = Color.FromArgb(234, 242, 248);
            panel8.Controls.Add(lblPendingPurchasesValue);
            panel8.Controls.Add(lblPendingPurchases);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 113);
            panel8.Margin = new Padding(0, 8, 8, 0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(14, 10, 14, 10);
            panel8.Size = new Size(448, 97);
            panel8.TabIndex = 2;

            lblPendingPurchasesValue.AutoSize = true;
            lblPendingPurchasesValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblPendingPurchasesValue.ForeColor = Color.FromArgb(30, 55, 80);
            lblPendingPurchasesValue.Location = new Point(14, 10);
            lblPendingPurchasesValue.Name = "lblPendingPurchasesValue";
            lblPendingPurchasesValue.Size = new Size(43, 50);
            lblPendingPurchasesValue.TabIndex = 0;
            lblPendingPurchasesValue.Text = "0";

            lblPendingPurchases.AutoSize = true;
            lblPendingPurchases.Font = new Font("Segoe UI", 9.5F);
            lblPendingPurchases.ForeColor = Color.DimGray;
            lblPendingPurchases.Location = new Point(16, 64);
            lblPendingPurchases.Name = "lblPendingPurchases";
            lblPendingPurchases.Size = new Size(135, 21);
            lblPendingPurchases.TabIndex = 1;
            lblPendingPurchases.Text = "Pending Purchases";

            // panel7 - TOTAL PURCHASE AMOUNT
            panel7.BackColor = Color.FromArgb(255, 244, 223);
            panel7.Controls.Add(lblTotalAmountValue);
            panel7.Controls.Add(lblTotalAmount);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(464, 113);
            panel7.Margin = new Padding(8, 8, 0, 0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(14, 10, 14, 10);
            panel7.Size = new Size(448, 97);
            panel7.TabIndex = 3;

            lblTotalAmountValue.AutoSize = true;
            lblTotalAmountValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalAmountValue.ForeColor = Color.FromArgb(95, 65, 20);
            lblTotalAmountValue.Location = new Point(14, 10);
            lblTotalAmountValue.Name = "lblTotalAmountValue";
            lblTotalAmountValue.Size = new Size(119, 50);
            lblTotalAmountValue.TabIndex = 0;
            lblTotalAmountValue.Text = "₱0.00";

            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 9.5F);
            lblTotalAmount.ForeColor = Color.DimGray;
            lblTotalAmount.Location = new Point(16, 64);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(165, 21);
            lblTotalAmount.TabIndex = 1;
            lblTotalAmount.Text = "Total Purchase Amount";

            // lblRecordsTitle
            lblRecordsTitle.AutoSize = true;
            lblRecordsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblRecordsTitle.ForeColor = Color.DarkSlateGray;
            lblRecordsTitle.Location = new Point(20, 232);
            lblRecordsTitle.Name = "lblRecordsTitle";
            lblRecordsTitle.Size = new Size(275, 32);
            lblRecordsTitle.TabIndex = 1;
            lblRecordsTitle.Text = "Purchase History Records";

            // 
            // pnlToolbar - SEARCH + CONTEXTUAL TABLE ACTIONS
            // 
            pnlToolbar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlToolbar.Controls.Add(lblSearch);
            pnlToolbar.Controls.Add(txtSearch);
            pnlToolbar.Controls.Add(btnSearch);
            pnlToolbar.Controls.Add(btnViewDetails);
            pnlToolbar.Controls.Add(btnPrintHistory);
            pnlToolbar.Location = new Point(20, 270);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(912, 40);
            pnlToolbar.TabIndex = 2;

            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F);
            lblSearch.Location = new Point(0, 9);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(56, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";

            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(62, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search purchase history...";
            txtSearch.Size = new Size(340, 29);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;

            btnSearch.BackColor = Color.DarkSlateGray;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(410, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 31);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;

            btnViewDetails.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewDetails.BackColor = Color.White;
            btnViewDetails.Cursor = Cursors.Hand;
            btnViewDetails.FlatAppearance.BorderColor = Color.Silver;
            btnViewDetails.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 245, 245);
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Font = new Font("Segoe UI", 9F);
            btnViewDetails.ForeColor = Color.DarkSlateGray;
            btnViewDetails.Location = new Point(664, 4);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(116, 32);
            btnViewDetails.TabIndex = 3;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;

            btnPrintHistory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrintHistory.BackColor = Color.White;
            btnPrintHistory.Cursor = Cursors.Hand;
            btnPrintHistory.FlatAppearance.BorderColor = Color.Silver;
            btnPrintHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 245, 245);
            btnPrintHistory.FlatStyle = FlatStyle.Flat;
            btnPrintHistory.Font = new Font("Segoe UI", 9F);
            btnPrintHistory.ForeColor = Color.DarkSlateGray;
            btnPrintHistory.Location = new Point(788, 4);
            btnPrintHistory.Name = "btnPrintHistory";
            btnPrintHistory.Size = new Size(124, 32);
            btnPrintHistory.TabIndex = 4;
            btnPrintHistory.Text = "Print History";
            btnPrintHistory.UseVisualStyleBackColor = false;
            btnPrintHistory.Click += btnPrintHistory_Click;

            // 
            // dgvPurchaseHistory
            // 
            dgvPurchaseHistory.AllowUserToAddRows = false;
            dgvPurchaseHistory.AllowUserToDeleteRows = false;
            dgvPurchaseHistory.AllowUserToResizeRows = false;
            dgvPurchaseHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPurchaseHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPurchaseHistory.BackgroundColor = Color.White;
            dgvPurchaseHistory.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 248, 248);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(245, 248, 248);
            dataGridViewCellStyle1.SelectionForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPurchaseHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPurchaseHistory.ColumnHeadersHeight = 36;
            dgvPurchaseHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(220, 242, 242);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPurchaseHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPurchaseHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 252, 252);
            dgvPurchaseHistory.EnableHeadersVisualStyles = false;
            dgvPurchaseHistory.GridColor = Color.WhiteSmoke;
            dgvPurchaseHistory.Location = new Point(20, 318);
            dgvPurchaseHistory.MultiSelect = false;
            dgvPurchaseHistory.Name = "dgvPurchaseHistory";
            dgvPurchaseHistory.ReadOnly = true;
            dgvPurchaseHistory.RowHeadersVisible = false;
            dgvPurchaseHistory.RowTemplate.Height = 32;
            dgvPurchaseHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPurchaseHistory.Size = new Size(912, 300);
            dgvPurchaseHistory.TabIndex = 3;

            // 
            // PurchaseHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 703);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MinimumSize = new Size(1024, 650);
            Name = "PurchaseHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase History";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tlpSummaryCards.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseHistory).EndInit();
            ResumeLayout(false);
        }
    }
}