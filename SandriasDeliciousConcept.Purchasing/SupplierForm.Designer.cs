namespace SandriasDeliciousConcept.Purchasing
{
    partial class SupplierForm
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
            dgvSuppliers = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnView = new Button();
            btnStatus = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            grpSupplierDetails = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtContactNumber = new TextBox();
            txtContactPerson = new TextBox();
            txtSupplierName = new TextBox();
            cmbSearchFilter = new ComboBox();
            btnSave = new Button();
            btnRefresh = new Button();
            panel1 = new Panel();
            label8 = new Label();
            btnPurchaseHistory = new Button();
            btnPurchaseOrder = new Button();
            btnQuotations = new Button();
            btnPurchaseRequest = new Button();
            btnSuppliers = new Button();
            btnDashboard = new Button();
            label7 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            grpSupplierDetails.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.AllowUserToDeleteRows = false;
            dgvSuppliers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.BackgroundColor = Color.White;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(242, 334);
            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.Size = new Size(714, 302);
            dgvSuppliers.TabIndex = 0;
            dgvSuppliers.CellContentClick += dgvSuppliers_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(785, 89);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(785, 124);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(785, 159);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 3;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnStatus
            // 
            btnStatus.Location = new Point(785, 194);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(94, 29);
            btnStatus.TabIndex = 4;
            btnStatus.Text = "Status";
            btnStatus.UseVisualStyleBackColor = true;
            btnStatus.Click += btnStatus_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(755, 287);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(286, 290);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search supplier name...";
            txtSearch.Size = new Size(310, 27);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 296);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 7;
            label1.Text = "Search";
            // 
            // grpSupplierDetails
            // 
            grpSupplierDetails.Controls.Add(label6);
            grpSupplierDetails.Controls.Add(label5);
            grpSupplierDetails.Controls.Add(label4);
            grpSupplierDetails.Controls.Add(label3);
            grpSupplierDetails.Controls.Add(label2);
            grpSupplierDetails.Controls.Add(txtAddress);
            grpSupplierDetails.Controls.Add(txtEmail);
            grpSupplierDetails.Controls.Add(txtContactNumber);
            grpSupplierDetails.Controls.Add(txtContactPerson);
            grpSupplierDetails.Controls.Add(txtSupplierName);
            grpSupplierDetails.Location = new Point(344, 80);
            grpSupplierDetails.Name = "grpSupplierDetails";
            grpSupplierDetails.Size = new Size(405, 193);
            grpSupplierDetails.TabIndex = 8;
            grpSupplierDetails.TabStop = false;
            grpSupplierDetails.Text = "Supplier Information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 166);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 9;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 129);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 96);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 7;
            label4.Text = "Contact Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 63);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 6;
            label3.Text = "Contact Person";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 5;
            label2.Text = "Supplier Name";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(126, 159);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(263, 27);
            txtAddress.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(126, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(126, 89);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(263, 27);
            txtContactNumber.TabIndex = 2;
            // 
            // txtContactPerson
            // 
            txtContactPerson.Location = new Point(126, 56);
            txtContactPerson.Name = "txtContactPerson";
            txtContactPerson.Size = new Size(263, 27);
            txtContactPerson.TabIndex = 1;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(126, 23);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(263, 27);
            txtSupplierName.TabIndex = 0;
            txtSupplierName.TextChanged += txtSupplierName_TextChanged;
            // 
            // cmbSearchFilter
            // 
            cmbSearchFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchFilter.FormattingEnabled = true;
            cmbSearchFilter.Location = new Point(602, 289);
            cmbSearchFilter.Name = "cmbSearchFilter";
            cmbSearchFilter.Size = new Size(147, 28);
            cmbSearchFilter.TabIndex = 9;
            cmbSearchFilter.SelectedIndexChanged += cmbSearchFilter_SelectedIndexChanged;
            cmbSearchFilter.Click += cmbSearchFilter_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(785, 229);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(855, 288);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnPurchaseHistory);
            panel1.Controls.Add(btnPurchaseOrder);
            panel1.Controls.Add(btnQuotations);
            panel1.Controls.Add(btnPurchaseRequest);
            panel1.Controls.Add(btnSuppliers);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 661);
            panel1.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(50, 198);
            label8.Name = "label8";
            label8.Size = new Size(129, 20);
            label8.TabIndex = 7;
            label8.Text = "Delicious Concept";
            // 
            // btnPurchaseHistory
            // 
            btnPurchaseHistory.FlatAppearance.BorderSize = 0;
            btnPurchaseHistory.FlatStyle = FlatStyle.Flat;
            btnPurchaseHistory.ForeColor = Color.White;
            btnPurchaseHistory.Location = new Point(0, 559);
            btnPurchaseHistory.Name = "btnPurchaseHistory";
            btnPurchaseHistory.Size = new Size(227, 45);
            btnPurchaseHistory.TabIndex = 6;
            btnPurchaseHistory.Text = "Purchase History";
            btnPurchaseHistory.UseVisualStyleBackColor = true;
            btnPurchaseHistory.Click += btnPurchaseHistory_Click;
            // 
            // btnPurchaseOrder
            // 
            btnPurchaseOrder.FlatAppearance.BorderSize = 0;
            btnPurchaseOrder.FlatStyle = FlatStyle.Flat;
            btnPurchaseOrder.ForeColor = Color.White;
            btnPurchaseOrder.Location = new Point(0, 508);
            btnPurchaseOrder.Name = "btnPurchaseOrder";
            btnPurchaseOrder.Size = new Size(227, 45);
            btnPurchaseOrder.TabIndex = 5;
            btnPurchaseOrder.Text = "Purchase Order";
            btnPurchaseOrder.UseVisualStyleBackColor = true;
            btnPurchaseOrder.Click += btnPurchaseOrder_Click;
            // 
            // btnQuotations
            // 
            btnQuotations.FlatAppearance.BorderSize = 0;
            btnQuotations.FlatStyle = FlatStyle.Flat;
            btnQuotations.ForeColor = Color.White;
            btnQuotations.Location = new Point(0, 458);
            btnQuotations.Name = "btnQuotations";
            btnQuotations.Size = new Size(227, 45);
            btnQuotations.TabIndex = 4;
            btnQuotations.Text = "Quotations";
            btnQuotations.UseVisualStyleBackColor = true;
            btnQuotations.Click += btnQuotations_Click;
            // 
            // btnPurchaseRequest
            // 
            btnPurchaseRequest.FlatAppearance.BorderSize = 0;
            btnPurchaseRequest.FlatStyle = FlatStyle.Flat;
            btnPurchaseRequest.ForeColor = Color.White;
            btnPurchaseRequest.Location = new Point(3, 408);
            btnPurchaseRequest.Name = "btnPurchaseRequest";
            btnPurchaseRequest.Size = new Size(227, 45);
            btnPurchaseRequest.TabIndex = 3;
            btnPurchaseRequest.Text = "Purchase Request";
            btnPurchaseRequest.UseVisualStyleBackColor = true;
            btnPurchaseRequest.Click += btnPurchaseRequest_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackColor = Color.Teal;
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(0, 358);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(227, 45);
            btnSuppliers.TabIndex = 2;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = false;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 308);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(227, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(30, 135);
            label7.Name = "label7";
            label7.Size = new Size(170, 50);
            label7.TabIndex = 0;
            label7.Text = "Sandrias";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label9);
            panel2.ForeColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(227, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(755, 58);
            panel2.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(237, 45);
            label9.TabIndex = 0;
            label9.Text = "Supplier Form";
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 662);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnRefresh);
            Controls.Add(btnSave);
            Controls.Add(cmbSearchFilter);
            Controls.Add(grpSupplierDetails);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnStatus);
            Controls.Add(btnView);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvSuppliers);
            Name = "SupplierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supplier Management";
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            grpSupplierDetails.ResumeLayout(false);
            grpSupplierDetails.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSuppliers;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnView;
        private Button btnStatus;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private GroupBox grpSupplierDetails;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtContactNumber;
        private TextBox txtContactPerson;
        private TextBox txtSupplierName;
        private Label label6;
        private ComboBox cmbSearchFilter;
        private Button btnSave;
        private Button btnRefresh;
        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private Button btnDashboard;
        private Button btnSuppliers;
        private Button btnPurchaseRequest;
        private Button btnQuotations;
        private Button btnPurchaseHistory;
        private Button btnPurchaseOrder;
        private Label label8;
        private Label label9;
    }
}