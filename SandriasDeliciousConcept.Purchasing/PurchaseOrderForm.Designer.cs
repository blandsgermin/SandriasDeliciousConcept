using System.Drawing;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Purchasing
{
    partial class PurchaseOrderForm
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
        private Label label13;
        private Label label14;

        private Button btnDashboard;
        private Button btnSuppliers;
        private Button btnPurchaseRequest;
        private Button btnQuotations;
        private Button btnPurchaseOrder;
        private Button btnPurchaseHistory;

        private Button btnNewPurchaseOrder;
        private Button btnSelectQuotation;
        private Button btnPrintPurchaseOrder;
        private Button btnViewDetails;
        private Button btnEditPurchaseOrder;
        private Button btnSearch;

        private TextBox txtSearch;
        private DataGridView dgvPurchaseOrders;

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

            panel2 = new Panel();
            label13 = new Label();
            btnEditPurchaseOrder = new Button();
            btnViewDetails = new Button();
            btnPrintPurchaseOrder = new Button();
            btnSelectQuotation = new Button();
            btnNewPurchaseOrder = new Button();

            panel3 = new Panel();
            label14 = new Label();

            panel4 = new Panel();
            dgvPurchaseOrders = new DataGridView();
            btnSearch = new Button();

            panel7 = new Panel();
            label10 = new Label();
            label6 = new Label();

            label12 = new Label();
            txtSearch = new TextBox();
            label11 = new Label();

            panel8 = new Panel();
            label9 = new Label();
            label5 = new Label();

            panel6 = new Panel();
            label8 = new Label();
            label4 = new Label();

            panel5 = new Panel();
            label7 = new Label();
            label3 = new Label();

            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseOrders).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();

            // LEFT NAVIGATION

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

            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 198);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 7;
            label2.Text = "Delicious Concept";

            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 135);
            label1.Name = "label1";
            label1.Size = new Size(170, 50);
            label1.TabIndex = 6;
            label1.Text = "Sandrias";

            btnPurchaseHistory.FlatAppearance.BorderSize = 0;
            btnPurchaseHistory.FlatStyle = FlatStyle.Flat;
            btnPurchaseHistory.ForeColor = Color.White;
            btnPurchaseHistory.Location = new Point(3, 557);
            btnPurchaseHistory.Name = "btnPurchaseHistory";
            btnPurchaseHistory.Size = new Size(227, 45);
            btnPurchaseHistory.TabIndex = 5;
            btnPurchaseHistory.Text = "Purchase History";
            btnPurchaseHistory.UseVisualStyleBackColor = true;
            btnPurchaseHistory.Click += btnPurchaseHistory_Click;

            btnPurchaseOrder.BackColor = Color.Teal;
            btnPurchaseOrder.FlatAppearance.BorderSize = 0;
            btnPurchaseOrder.FlatStyle = FlatStyle.Flat;
            btnPurchaseOrder.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnPurchaseOrder.ForeColor = Color.White;
            btnPurchaseOrder.Location = new Point(0, 508);
            btnPurchaseOrder.Name = "btnPurchaseOrder";
            btnPurchaseOrder.Size = new Size(227, 45);
            btnPurchaseOrder.TabIndex = 4;
            btnPurchaseOrder.Text = "Purchase Order";
            btnPurchaseOrder.UseVisualStyleBackColor = false;
            btnPurchaseOrder.Click += btnPurchaseOrder_Click;

            btnQuotations.FlatAppearance.BorderSize = 0;
            btnQuotations.FlatStyle = FlatStyle.Flat;
            btnQuotations.ForeColor = Color.White;
            btnQuotations.Location = new Point(0, 458);
            btnQuotations.Name = "btnQuotations";
            btnQuotations.Size = new Size(227, 45);
            btnQuotations.TabIndex = 3;
            btnQuotations.Text = "Quotations";
            btnQuotations.UseVisualStyleBackColor = true;
            btnQuotations.Click += btnQuotations_Click;

            btnPurchaseRequest.FlatAppearance.BorderSize = 0;
            btnPurchaseRequest.FlatStyle = FlatStyle.Flat;
            btnPurchaseRequest.ForeColor = Color.White;
            btnPurchaseRequest.Location = new Point(3, 408);
            btnPurchaseRequest.Name = "btnPurchaseRequest";
            btnPurchaseRequest.Size = new Size(227, 45);
            btnPurchaseRequest.TabIndex = 2;
            btnPurchaseRequest.Text = "Purchase Request";
            btnPurchaseRequest.UseVisualStyleBackColor = true;
            btnPurchaseRequest.Click += btnPurchaseRequest_Click;

            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(0, 359);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(227, 45);
            btnSuppliers.TabIndex = 1;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;

            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 308);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(227, 45);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;

            // RIGHT QUICK ACTIONS

            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label13);
            panel2.Controls.Add(btnEditPurchaseOrder);
            panel2.Controls.Add(btnViewDetails);
            panel2.Controls.Add(btnPrintPurchaseOrder);
            panel2.Controls.Add(btnSelectQuotation);
            panel2.Controls.Add(btnNewPurchaseOrder);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(962, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 703);
            panel2.TabIndex = 1;

            label13.AutoSize = true;
            label13.BackColor = Color.Black;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(60, 66);
            label13.Name = "label13";
            label13.Size = new Size(98, 20);
            label13.TabIndex = 5;
            label13.Text = "Quick Action";

            btnEditPurchaseOrder.Location = new Point(29, 324);
            btnEditPurchaseOrder.Name = "btnEditPurchaseOrder";
            btnEditPurchaseOrder.Size = new Size(168, 44);
            btnEditPurchaseOrder.TabIndex = 4;
            btnEditPurchaseOrder.Text = "Edit Purchase Order";
            btnEditPurchaseOrder.UseVisualStyleBackColor = true;
            btnEditPurchaseOrder.Click += btnEditPurchaseOrder_Click;

            btnViewDetails.Location = new Point(29, 268);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(168, 46);
            btnViewDetails.TabIndex = 3;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;

            btnPrintPurchaseOrder.Location = new Point(29, 215);
            btnPrintPurchaseOrder.Name = "btnPrintPurchaseOrder";
            btnPrintPurchaseOrder.Size = new Size(168, 44);
            btnPrintPurchaseOrder.TabIndex = 2;
            btnPrintPurchaseOrder.Text = "Print Purchase Order";
            btnPrintPurchaseOrder.UseVisualStyleBackColor = true;
            btnPrintPurchaseOrder.Click += btnPrintPurchaseOrder_Click;

            btnSelectQuotation.Location = new Point(29, 158);
            btnSelectQuotation.Name = "btnSelectQuotation";
            btnSelectQuotation.Size = new Size(168, 44);
            btnSelectQuotation.TabIndex = 1;
            btnSelectQuotation.Text = "Select Quotation";
            btnSelectQuotation.UseVisualStyleBackColor = true;
            btnSelectQuotation.Click += btnSelectQuotation_Click;

            btnNewPurchaseOrder.Location = new Point(29, 105);
            btnNewPurchaseOrder.Name = "btnNewPurchaseOrder";
            btnNewPurchaseOrder.Size = new Size(168, 44);
            btnNewPurchaseOrder.TabIndex = 0;
            btnNewPurchaseOrder.Text = "New Purchase Order";
            btnNewPurchaseOrder.UseVisualStyleBackColor = true;
            btnNewPurchaseOrder.Click += btnNewPurchaseOrder_Click;

            // TOP HEADER

            panel3.Controls.Add(label14);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(230, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(732, 57);
            panel3.TabIndex = 2;

            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold);
            label14.ForeColor = Color.DarkSlateGray;
            label14.Location = new Point(0, 9);
            label14.Name = "label14";
            label14.Size = new Size(300, 45);
            label14.TabIndex = 0;
            label14.Text = "Purchase Order";

            // MAIN WORKSPACE

            panel4.BackColor = Color.White;
            panel4.Controls.Add(dgvPurchaseOrders);
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(230, 57);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(15);
            panel4.Size = new Size(732, 646);
            panel4.TabIndex = 3;

            // PURCHASE ORDER GRID

            dgvPurchaseOrders.AllowUserToAddRows = false;
            dgvPurchaseOrders.AllowUserToDeleteRows = false;
            dgvPurchaseOrders.AllowUserToResizeColumns = false;
            dgvPurchaseOrders.AllowUserToResizeRows = false;
            dgvPurchaseOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPurchaseOrders.BackgroundColor = Color.White;
            dgvPurchaseOrders.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchaseOrders.Location = new Point(21, 328);
            dgvPurchaseOrders.MultiSelect = false;
            dgvPurchaseOrders.Name = "dgvPurchaseOrders";
            dgvPurchaseOrders.ReadOnly = true;
            dgvPurchaseOrders.RowHeadersVisible = false;
            dgvPurchaseOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPurchaseOrders.Size = new Size(693, 282);
            dgvPurchaseOrders.TabIndex = 8;

            // SEARCH BUTTON

            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.Location = new Point(536, 276);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;

            // FOURTH SUMMARY CARD

            panel7.BackColor = Color.FromArgb(255, 244, 223);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label10);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(371, 117);
            panel7.Name = "panel7";
            panel7.Size = new Size(355, 105);
            panel7.TabIndex = 2;

            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label10.Location = new Point(4, 16);
            label10.Name = "label10";
            label10.Size = new Size(64, 50);
            label10.TabIndex = 1;
            label10.Text = "00";

            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(-1, 75);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 0;
            label6.Text = "Received";

            // SEARCH LABEL

            label12.AutoSize = true;
            label12.Location = new Point(11, 284);
            label12.Name = "label12";
            label12.Size = new Size(53, 20);
            label12.TabIndex = 6;
            label12.Text = "Search";

            // SEARCH TEXTBOX

            txtSearch.Location = new Point(70, 278);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search purchase orders...";
            txtSearch.Size = new Size(450, 27);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;

            // RECORD TITLE

            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label11.ForeColor = Color.DarkSlateGray;
            label11.Location = new Point(11, 233);
            label11.Name = "label11";
            label11.Size = new Size(220, 35);
            label11.TabIndex = 4;
            label11.Text = "Purchase Order Records";

            // THIRD SUMMARY CARD

            panel8.BackColor = Color.FromArgb(234, 242, 248);
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(6, 117);
            panel8.Name = "panel8";
            panel8.Size = new Size(360, 105);
            panel8.TabIndex = 3;

            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label9.Location = new Point(3, 16);
            label9.Name = "label9";
            label9.Size = new Size(64, 50);
            label9.TabIndex = 1;
            label9.Text = "00";

            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(-2, 75);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 0;
            label5.Text = "Approved";

            // SECOND SUMMARY CARD

            panel6.BackColor = Color.FromArgb(232, 245, 237);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(372, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(354, 105);
            panel6.TabIndex = 1;

            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label8.Location = new Point(4, 23);
            label8.Name = "label8";
            label8.Size = new Size(64, 50);
            label8.TabIndex = 1;
            label8.Text = "00";

            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(-1, 75);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 0;
            label4.Text = "Pending";

            // FIRST SUMMARY CARD

            panel5.BackColor = Color.FromArgb(240, 235, 248);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(6, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 105);
            panel5.TabIndex = 0;

            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label7.Location = new Point(3, 23);
            label7.Name = "label7";
            label7.Size = new Size(64, 50);
            label7.TabIndex = 1;
            label7.Text = "00";

            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(-1, 76);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 0;
            label3.Text = "Total Purchase Orders";

            // FORM SETTINGS

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 703);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PurchaseOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase Order";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseOrders).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}