using System.Drawing;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Purchasing
{
    partial class QuotationsForm
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

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;

        private Button btnDashboard;
        private Button btnSuppliers;
        private Button btnPurchaseRequest;
        private Button btnQuotations;
        private Button btnPurchaseOrder;
        private Button btnPurchaseHistory;

        private Button btnNewQuotation;
        private Button btnSelectSupplier;
        private Button btnPrintQuotation;
        private Button btnViewDetails;
        private Button btnEditQuotation;
        private Button btnSearch;

        private TextBox txtSearch;
        private DataGridView dgvQuotations;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnPurchaseHistory = new Button();
            btnPurchaseOrder = new Button();
            btnQuotations = new Button();
            btnPurchaseRequest = new Button();
            btnSuppliers = new Button();
            btnDashboard = new Button();

            panel3 = new Panel();
            label14 = new Label();
            btnNewQuotation = new Button();
            btnSelectSupplier = new Button();

            panel4 = new Panel();
            tlpSummaryCards = new TableLayoutPanel();
            panel5 = new Panel();
            label7 = new Label();
            label3 = new Label();
            panel6 = new Panel();
            label8 = new Label();
            label4 = new Label();
            panel8 = new Panel();
            label9 = new Label();
            label5 = new Label();
            panel7 = new Panel();
            label10 = new Label();
            label6 = new Label();

            label11 = new Label();
            pnlToolbar = new Panel();
            label12 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnViewDetails = new Button();
            btnEditQuotation = new Button();
            btnPrintQuotation = new Button();
            dgvQuotations = new DataGridView();

            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tlpSummaryCards.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuotations).BeginInit();
            SuspendLayout();

            // 
            // panel1 - LEFT NAVIGATION
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnPurchaseHistory);
            panel1.Controls.Add(btnPurchaseOrder);
            panel1.Controls.Add(btnQuotations);
            panel1.Controls.Add(btnPurchaseRequest);
            panel1.Controls.Add(btnSuppliers);
            panel1.Controls.Add(btnDashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 703);
            panel1.TabIndex = 0;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 80);
            label1.Name = "label1";
            label1.Size = new Size(170, 50);
            label1.TabIndex = 6;
            label1.Text = "Sandrias";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(48, 132);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 7;
            label2.Text = "Delicious Concept";

            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 220);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(230, 45);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;

            // 
            // btnSuppliers
            // 
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(0, 270);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(230, 45);
            btnSuppliers.TabIndex = 1;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;

            // 
            // btnPurchaseRequest
            // 
            btnPurchaseRequest.FlatAppearance.BorderSize = 0;
            btnPurchaseRequest.FlatStyle = FlatStyle.Flat;
            btnPurchaseRequest.ForeColor = Color.White;
            btnPurchaseRequest.Location = new Point(0, 320);
            btnPurchaseRequest.Name = "btnPurchaseRequest";
            btnPurchaseRequest.Size = new Size(230, 45);
            btnPurchaseRequest.TabIndex = 2;
            btnPurchaseRequest.Text = "Purchase Request";
            btnPurchaseRequest.UseVisualStyleBackColor = true;
            btnPurchaseRequest.Click += btnPurchaseRequest_Click;

            // 
            // btnQuotations
            // 
            btnQuotations.BackColor = Color.Teal;
            btnQuotations.FlatAppearance.BorderSize = 0;
            btnQuotations.FlatStyle = FlatStyle.Flat;
            btnQuotations.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnQuotations.ForeColor = Color.White;
            btnQuotations.Location = new Point(0, 370);
            btnQuotations.Name = "btnQuotations";
            btnQuotations.Size = new Size(230, 45);
            btnQuotations.TabIndex = 3;
            btnQuotations.Text = "Quotations";
            btnQuotations.UseVisualStyleBackColor = false;
            btnQuotations.Click += btnQuotations_Click;

            // 
            // btnPurchaseOrder
            // 
            btnPurchaseOrder.FlatAppearance.BorderSize = 0;
            btnPurchaseOrder.FlatStyle = FlatStyle.Flat;
            btnPurchaseOrder.ForeColor = Color.White;
            btnPurchaseOrder.Location = new Point(0, 420);
            btnPurchaseOrder.Name = "btnPurchaseOrder";
            btnPurchaseOrder.Size = new Size(230, 45);
            btnPurchaseOrder.TabIndex = 4;
            btnPurchaseOrder.Text = "Purchase Order";
            btnPurchaseOrder.UseVisualStyleBackColor = true;
            btnPurchaseOrder.Click += btnPurchaseOrder_Click;

            // 
            // btnPurchaseHistory
            // 
            btnPurchaseHistory.FlatAppearance.BorderSize = 0;
            btnPurchaseHistory.FlatStyle = FlatStyle.Flat;
            btnPurchaseHistory.ForeColor = Color.White;
            btnPurchaseHistory.Location = new Point(0, 470);
            btnPurchaseHistory.Name = "btnPurchaseHistory";
            btnPurchaseHistory.Size = new Size(230, 45);
            btnPurchaseHistory.TabIndex = 5;
            btnPurchaseHistory.Text = "Purchase History";
            btnPurchaseHistory.UseVisualStyleBackColor = true;
            btnPurchaseHistory.Click += btnPurchaseHistory_Click;

            // 
            // panel3 - TOP HEADER WITH PRIMARY ACTIONS
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label14);
            panel3.Controls.Add(btnSelectSupplier);
            panel3.Controls.Add(btnNewQuotation);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(230, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 12, 20, 8);
            panel3.Size = new Size(952, 65);
            panel3.TabIndex = 1;

            // 
            // label14 - PAGE TITLE
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label14.ForeColor = Color.DarkSlateGray;
            label14.Location = new Point(20, 14);
            label14.Name = "label14";
            label14.Size = new Size(185, 41);
            label14.TabIndex = 0;
            label14.Text = "Quotations";

            // 
            // btnNewQuotation - PRIMARY ACTION (TOP-RIGHT)
            // 
            btnNewQuotation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewQuotation.BackColor = Color.Teal;
            btnNewQuotation.Cursor = Cursors.Hand;
            btnNewQuotation.FlatAppearance.BorderSize = 0;
            btnNewQuotation.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnNewQuotation.FlatStyle = FlatStyle.Flat;
            btnNewQuotation.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNewQuotation.ForeColor = Color.White;
            btnNewQuotation.Location = new Point(782, 14);
            btnNewQuotation.Name = "btnNewQuotation";
            btnNewQuotation.Size = new Size(150, 38);
            btnNewQuotation.TabIndex = 1;
            btnNewQuotation.Text = "+ New Quotation";
            btnNewQuotation.UseVisualStyleBackColor = false;
            btnNewQuotation.Click += btnNewQuotation_Click;

            // 
            // btnSelectSupplier - SECONDARY TOP ACTION
            // 
            btnSelectSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectSupplier.BackColor = Color.White;
            btnSelectSupplier.Cursor = Cursors.Hand;
            btnSelectSupplier.FlatAppearance.BorderColor = Color.Silver;
            btnSelectSupplier.FlatAppearance.BorderSize = 1;
            btnSelectSupplier.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 245, 245);
            btnSelectSupplier.FlatStyle = FlatStyle.Flat;
            btnSelectSupplier.Font = new Font("Segoe UI", 9.5F);
            btnSelectSupplier.ForeColor = Color.DarkSlateGray;
            btnSelectSupplier.Location = new Point(622, 14);
            btnSelectSupplier.Name = "btnSelectSupplier";
            btnSelectSupplier.Size = new Size(150, 38);
            btnSelectSupplier.TabIndex = 2;
            btnSelectSupplier.Text = "Select Supplier";
            btnSelectSupplier.UseVisualStyleBackColor = false;
            btnSelectSupplier.Click += btnSelectSupplier_Click;

            // 
            // panel4 - MAIN WORKSPACE
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(dgvQuotations);
            panel4.Controls.Add(pnlToolbar);
            panel4.Controls.Add(label11);
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

            // 
            // panel5 - TOTAL QUOTATIONS
            // 
            panel5.BackColor = Color.FromArgb(240, 235, 248);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0, 0, 8, 8);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(14, 10, 14, 10);
            panel5.Size = new Size(448, 97);
            panel5.TabIndex = 0;

            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(45, 45, 65);
            label7.Location = new Point(14, 10);
            label7.Name = "label7";
            label7.Size = new Size(64, 50);
            label7.TabIndex = 1;
            label7.Text = "00";

            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.5F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(16, 64);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 0;
            label3.Text = "Total Quotations";

            // 
            // panel6 - PENDING
            // 
            panel6.BackColor = Color.FromArgb(232, 245, 237);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(464, 0);
            panel6.Margin = new Padding(8, 0, 0, 8);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(14, 10, 14, 10);
            panel6.Size = new Size(448, 97);
            panel6.TabIndex = 1;

            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(30, 70, 50);
            label8.Location = new Point(14, 10);
            label8.Name = "label8";
            label8.Size = new Size(64, 50);
            label8.TabIndex = 1;
            label8.Text = "00";

            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(16, 64);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 0;
            label4.Text = "Pending";

            // 
            // panel8 - ACCEPTED
            // 
            panel8.BackColor = Color.FromArgb(234, 242, 248);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label5);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 113);
            panel8.Margin = new Padding(0, 8, 8, 0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(14, 10, 14, 10);
            panel8.Size = new Size(448, 97);
            panel8.TabIndex = 3;

            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(30, 55, 80);
            label9.Location = new Point(14, 10);
            label9.Name = "label9";
            label9.Size = new Size(64, 50);
            label9.TabIndex = 1;
            label9.Text = "00";

            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.5F);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(16, 64);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 0;
            label5.Text = "Accepted";

            // 
            // panel7 - REJECTED
            // 
            panel7.BackColor = Color.FromArgb(255, 244, 223);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(label6);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(464, 113);
            panel7.Margin = new Padding(8, 8, 0, 0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(14, 10, 14, 10);
            panel7.Size = new Size(448, 97);
            panel7.TabIndex = 2;

            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(95, 65, 20);
            label10.Location = new Point(14, 10);
            label10.Name = "label10";
            label10.Size = new Size(64, 50);
            label10.TabIndex = 1;
            label10.Text = "00";

            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.5F);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(16, 64);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 0;
            label6.Text = "Rejected";

            // 
            // label11 - QUOTATION RECORDS SECTION TITLE
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.ForeColor = Color.DarkSlateGray;
            label11.Location = new Point(20, 232);
            label11.Name = "label11";
            label11.Size = new Size(210, 32);
            label11.TabIndex = 1;
            label11.Text = "Quotation Records";

            // 
            // pnlToolbar - SEARCH + CONTEXTUAL TABLE ACTIONS
            // 
            pnlToolbar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlToolbar.Controls.Add(label12);
            pnlToolbar.Controls.Add(txtSearch);
            pnlToolbar.Controls.Add(btnSearch);
            pnlToolbar.Controls.Add(btnViewDetails);
            pnlToolbar.Controls.Add(btnEditQuotation);
            pnlToolbar.Controls.Add(btnPrintQuotation);
            pnlToolbar.Location = new Point(20, 270);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(912, 40);
            pnlToolbar.TabIndex = 2;

            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(0, 9);
            label12.Name = "label12";
            label12.Size = new Size(53, 20);
            label12.TabIndex = 0;
            label12.Text = "Search";

            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(60, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search quotations...";
            txtSearch.Size = new Size(310, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;

            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.WhiteSmoke;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.Silver;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(378, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;

            // 
            // btnViewDetails (Aligned Right in Toolbar)
            // 
            btnViewDetails.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewDetails.BackColor = Color.White;
            btnViewDetails.Cursor = Cursors.Hand;
            btnViewDetails.FlatAppearance.BorderColor = Color.Silver;
            btnViewDetails.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 245, 245);
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Font = new Font("Segoe UI", 9F);
            btnViewDetails.ForeColor = Color.DarkSlateGray;
            btnViewDetails.Location = new Point(550, 4);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(110, 32);
            btnViewDetails.TabIndex = 3;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;

            // 
            // btnEditQuotation (Aligned Right in Toolbar)
            // 
            btnEditQuotation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditQuotation.BackColor = Color.White;
            btnEditQuotation.Cursor = Cursors.Hand;
            btnEditQuotation.FlatAppearance.BorderColor = Color.Silver;
            btnEditQuotation.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 245, 245);
            btnEditQuotation.FlatStyle = FlatStyle.Flat;
            btnEditQuotation.Font = new Font("Segoe UI", 9F);
            btnEditQuotation.ForeColor = Color.DarkSlateGray;
            btnEditQuotation.Location = new Point(668, 4);
            btnEditQuotation.Name = "btnEditQuotation";
            btnEditQuotation.Size = new Size(116, 32);
            btnEditQuotation.TabIndex = 4;
            btnEditQuotation.Text = "Edit Quotation";
            btnEditQuotation.UseVisualStyleBackColor = false;
            btnEditQuotation.Click += btnEditQuotation_Click;

            // 
            // btnPrintQuotation (Aligned Right in Toolbar)
            // 
            btnPrintQuotation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrintQuotation.BackColor = Color.White;
            btnPrintQuotation.Cursor = Cursors.Hand;
            btnPrintQuotation.FlatAppearance.BorderColor = Color.Silver;
            btnPrintQuotation.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 245, 245);
            btnPrintQuotation.FlatStyle = FlatStyle.Flat;
            btnPrintQuotation.Font = new Font("Segoe UI", 9F);
            btnPrintQuotation.ForeColor = Color.DarkSlateGray;
            btnPrintQuotation.Location = new Point(792, 4);
            btnPrintQuotation.Name = "btnPrintQuotation";
            btnPrintQuotation.Size = new Size(120, 32);
            btnPrintQuotation.TabIndex = 5;
            btnPrintQuotation.Text = "Print Quotation";
            btnPrintQuotation.UseVisualStyleBackColor = false;
            btnPrintQuotation.Click += btnPrintQuotation_Click;

            // 
            // dgvQuotations - RESPONSIVE DATA TABLE
            // 
            dgvQuotations.AllowUserToAddRows = false;
            dgvQuotations.AllowUserToDeleteRows = false;
            dgvQuotations.AllowUserToResizeRows = false;
            dgvQuotations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvQuotations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuotations.BackgroundColor = Color.White;
            dgvQuotations.BorderStyle = BorderStyle.FixedSingle;
            dgvQuotations.ColumnHeadersHeight = 36;
            dgvQuotations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvQuotations.EnableHeadersVisualStyles = false;
            dgvQuotations.GridColor = Color.WhiteSmoke;
            dgvQuotations.Location = new Point(20, 318);
            dgvQuotations.MultiSelect = false;
            dgvQuotations.Name = "dgvQuotations";
            dgvQuotations.ReadOnly = true;
            dgvQuotations.RowHeadersVisible = false;
            dgvQuotations.RowTemplate.Height = 32;
            dgvQuotations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuotations.Size = new Size(912, 300);
            dgvQuotations.TabIndex = 3;

            // 
            // QuotationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 703);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MinimumSize = new Size(1024, 650);
            Name = "QuotationsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quotations";

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
            ((System.ComponentModel.ISupportInitialize)dgvQuotations).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}