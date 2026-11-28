using System.Drawing;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Delivery
{
    partial class ApprovedRequestsForm
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
        private System.Windows.Forms.Label lblRequestCount;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridView dgvApprovedRequests;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlToolbar = new Panel();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            pnlGridHeader = new Panel();
            lblRequestCount = new Label();
            lblGridTitle = new Label();
            pnlGridContainer = new Panel();
            dgvApprovedRequests = new DataGridView();

            pnlHeader.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlGridHeader.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApprovedRequests).BeginInit();
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
            pnlHeader.Size = new Size(1122, 85);
            pnlHeader.TabIndex = 0;

            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(25, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Approved Requests";

            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(27, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(410, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "View approved requisitions available for delivery scheduling.";

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
            pnlToolbar.Size = new Size(1122, 58);
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
            txtSearch.PlaceholderText = "Search approved requests...";
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
            btnRefresh.Location = new Point(977, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 36);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;

            // 
            // pnlGridHeader
            // 
            pnlGridHeader.BackColor = Color.White;
            pnlGridHeader.Controls.Add(lblRequestCount);
            pnlGridHeader.Controls.Add(lblGridTitle);
            pnlGridHeader.Dock = DockStyle.Top;
            pnlGridHeader.Location = new Point(0, 143);
            pnlGridHeader.Name = "pnlGridHeader";
            pnlGridHeader.Padding = new Padding(25, 8, 25, 6);
            pnlGridHeader.Size = new Size(1122, 42);
            pnlGridHeader.TabIndex = 2;

            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.DarkSlateGray;
            lblGridTitle.Location = new Point(25, 10);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(195, 25);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "Approved Requests List";

            lblRequestCount.AutoSize = true;
            lblRequestCount.Font = new Font("Segoe UI", 9.5F);
            lblRequestCount.ForeColor = Color.Gray;
            lblRequestCount.Location = new Point(225, 14);
            lblRequestCount.Name = "lblRequestCount";
            lblRequestCount.Size = new Size(140, 20);
            lblRequestCount.TabIndex = 1;
            lblRequestCount.Text = "0 approved requests";

            // 
            // pnlGridContainer
            // 
            pnlGridContainer.BackColor = Color.White;
            pnlGridContainer.Controls.Add(dgvApprovedRequests);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(0, 185);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(25, 4, 25, 25);
            pnlGridContainer.Size = new Size(1122, 619);
            pnlGridContainer.TabIndex = 3;

            // 
            // dgvApprovedRequests
            // 
            dgvApprovedRequests.AllowUserToAddRows = false;
            dgvApprovedRequests.AllowUserToDeleteRows = false;
            dgvApprovedRequests.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(247, 250, 250);
            dgvApprovedRequests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvApprovedRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApprovedRequests.BackgroundColor = Color.White;
            dgvApprovedRequests.BorderStyle = BorderStyle.FixedSingle;
            dgvApprovedRequests.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvApprovedRequests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvApprovedRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvApprovedRequests.ColumnHeadersHeight = 42;
            dgvApprovedRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(45, 55, 55);
            dataGridViewCellStyle3.Padding = new Padding(8, 4, 8, 4);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(215, 235, 235);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 60, 60);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvApprovedRequests.DefaultCellStyle = dataGridViewCellStyle3;
            dgvApprovedRequests.Dock = DockStyle.Fill;
            dgvApprovedRequests.EnableHeadersVisualStyles = false;
            dgvApprovedRequests.GridColor = Color.FromArgb(230, 235, 235);
            dgvApprovedRequests.Location = new Point(25, 4);
            dgvApprovedRequests.MultiSelect = false;
            dgvApprovedRequests.Name = "dgvApprovedRequests";
            dgvApprovedRequests.ReadOnly = true;
            dgvApprovedRequests.RowHeadersVisible = false;
            dgvApprovedRequests.RowTemplate.Height = 38;
            dgvApprovedRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApprovedRequests.Size = new Size(1072, 590);
            dgvApprovedRequests.TabIndex = 0;

            // 
            // ApprovedRequestsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1122, 804);
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlGridHeader);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            Name = "ApprovedRequestsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Approved Requests";

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlGridHeader.ResumeLayout(false);
            pnlGridHeader.PerformLayout();
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvApprovedRequests).EndInit();
            ResumeLayout(false);
        }
    }
}