using System.Drawing;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Delivery
{
    partial class DeliveryRecordsForm
    {
        private System.ComponentModel.IContainer? components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlGridHeader;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.TextBox txtStatusRemarks;
        private System.Windows.Forms.Label lblStatusRemarks;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle altCellStyle = new DataGridViewCellStyle();

            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlToolbar = new Panel();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            pnlGridHeader = new Panel();
            lblRecordCount = new Label();
            lblGridTitle = new Label();
            pnlGridContainer = new Panel();
            dgvRecords = new DataGridView();
            pnlStatus = new Panel();
            btnUpdateStatus = new Button();
            txtStatusRemarks = new TextBox();
            lblStatusRemarks = new Label();
            cmbStatus = new ComboBox();
            lblStatus = new Label();

            pnlHeader.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlGridHeader.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            pnlStatus.SuspendLayout();
            SuspendLayout();

            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(25, 14, 25, 8);
            pnlHeader.Size = new Size(1150, 85);
            pnlHeader.TabIndex = 0;

            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(25, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(260, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Delivery Records";

            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(27, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(380, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "View and manage scheduled and completed deliveries.";

            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Controls.Add(txtSearch);
            pnlToolbar.Controls.Add(lblSearch);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 85);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(25, 10, 25, 10);
            pnlToolbar.Size = new Size(1150, 58);
            pnlToolbar.TabIndex = 1;

            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.DarkSlateGray;
            lblSearch.Location = new Point(25, 18);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(59, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";

            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(92, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search delivery records...";
            txtSearch.Size = new Size(340, 30);
            txtSearch.TabIndex = 1;

            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.Teal;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1005, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 36);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;

            // 
            // pnlGridHeader
            // 
            pnlGridHeader.BackColor = Color.White;
            pnlGridHeader.Controls.Add(lblRecordCount);
            pnlGridHeader.Controls.Add(lblGridTitle);
            pnlGridHeader.Dock = DockStyle.Top;
            pnlGridHeader.Location = new Point(0, 143);
            pnlGridHeader.Name = "pnlGridHeader";
            pnlGridHeader.Padding = new Padding(25, 8, 25, 6);
            pnlGridHeader.Size = new Size(1150, 42);
            pnlGridHeader.TabIndex = 2;

            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.DarkSlateGray;
            lblGridTitle.Location = new Point(25, 10);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(195, 25);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "All Delivery Records";

            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Segoe UI", 9.5F);
            lblRecordCount.ForeColor = Color.Gray;
            lblRecordCount.Location = new Point(225, 14);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(135, 20);
            lblRecordCount.TabIndex = 1;
            lblRecordCount.Text = "0 delivery records";

            // 
            // pnlGridContainer
            // 
            pnlGridContainer.BackColor = Color.White;
            pnlGridContainer.Controls.Add(dgvRecords);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(0, 185);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(25, 4, 25, 16);
            pnlGridContainer.Size = new Size(1150, 420);
            pnlGridContainer.TabIndex = 3;

            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AllowUserToDeleteRows = false;
            dgvRecords.AllowUserToResizeRows = false;
            dgvRecords.AutoGenerateColumns = true;
            dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRecords.ScrollBars = ScrollBars.Both;
            dgvRecords.BackgroundColor = Color.White;
            dgvRecords.BorderStyle = BorderStyle.FixedSingle;
            dgvRecords.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRecords.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRecords.ColumnHeadersHeight = 42;
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecords.Dock = DockStyle.Fill;
            dgvRecords.EnableHeadersVisualStyles = false;
            dgvRecords.GridColor = Color.FromArgb(230, 235, 235);
            dgvRecords.Location = new Point(25, 4);
            dgvRecords.MultiSelect = false;
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.RowHeadersVisible = false;
            dgvRecords.RowTemplate.Height = 38;
            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecords.Size = new Size(1100, 400);
            dgvRecords.TabIndex = 0;

            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.DarkSlateGray;
            headerStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            headerStyle.ForeColor = Color.White;
            headerStyle.Padding = new Padding(8, 0, 8, 0);
            headerStyle.SelectionBackColor = Color.DarkSlateGray;
            headerStyle.SelectionForeColor = Color.White;
            dgvRecords.ColumnHeadersDefaultCellStyle = headerStyle;

            cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = Color.White;
            cellStyle.Font = new Font("Segoe UI", 9.5F);
            cellStyle.ForeColor = Color.FromArgb(45, 55, 55);
            cellStyle.Padding = new Padding(8, 4, 8, 4);
            cellStyle.SelectionBackColor = Color.FromArgb(215, 235, 235);
            cellStyle.SelectionForeColor = Color.FromArgb(30, 60, 60);
            dgvRecords.DefaultCellStyle = cellStyle;

            altCellStyle.BackColor = Color.FromArgb(247, 250, 250);
            dgvRecords.AlternatingRowsDefaultCellStyle = altCellStyle;

            // 
            // pnlStatus - RESPONSIVE BOTTOM STATUS BAR
            // 
            pnlStatus.BackColor = Color.FromArgb(248, 250, 250);
            pnlStatus.Controls.Add(btnUpdateStatus);
            pnlStatus.Controls.Add(txtStatusRemarks);
            pnlStatus.Controls.Add(lblStatusRemarks);
            pnlStatus.Controls.Add(cmbStatus);
            pnlStatus.Controls.Add(lblStatus);
            pnlStatus.Dock = DockStyle.Bottom;
            pnlStatus.Location = new Point(0, 605);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Padding = new Padding(25, 12, 25, 14);
            pnlStatus.Size = new Size(1150, 95);
            pnlStatus.TabIndex = 4;

            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStatus.ForeColor = Color.DarkSlateGray;
            lblStatus.Location = new Point(25, 14);
            lblStatus.Name = "lblStatus";
            lblStatus.Text = "New Delivery Status";

            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(25, 40);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(210, 31);
            cmbStatus.TabIndex = 1;

            lblStatusRemarks.AutoSize = true;
            lblStatusRemarks.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStatusRemarks.ForeColor = Color.DarkSlateGray;
            lblStatusRemarks.Location = new Point(255, 14);
            lblStatusRemarks.Name = "lblStatusRemarks";
            lblStatusRemarks.Text = "Remarks";

            txtStatusRemarks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatusRemarks.BorderStyle = BorderStyle.FixedSingle;
            txtStatusRemarks.Font = new Font("Segoe UI", 10F);
            txtStatusRemarks.Location = new Point(255, 40);
            txtStatusRemarks.Name = "txtStatusRemarks";
            txtStatusRemarks.PlaceholderText = "Optional status remarks...";
            txtStatusRemarks.Size = new Size(660, 30);
            txtStatusRemarks.TabIndex = 3;

            btnUpdateStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateStatus.BackColor = Color.Teal;
            btnUpdateStatus.Cursor = Cursors.Hand;
            btnUpdateStatus.FlatAppearance.BorderSize = 0;
            btnUpdateStatus.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnUpdateStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.Location = new Point(935, 36);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(190, 38);
            btnUpdateStatus.TabIndex = 4;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = false;

            // 
            // DeliveryRecordsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1150, 700);
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlStatus);
            Controls.Add(pnlGridHeader);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(900, 600);
            Name = "DeliveryRecordsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delivery Records";

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlGridHeader.ResumeLayout(false);
            pnlGridHeader.PerformLayout();
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            ResumeLayout(false);
        }
    }
}