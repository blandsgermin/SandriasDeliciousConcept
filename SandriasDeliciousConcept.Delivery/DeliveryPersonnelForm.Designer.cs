
namespace SandriasDeliciousConcept.Delivery
{
    partial class DeliveryPersonnelForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Panel pnlGridHeader;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.Label lblPersonnelCount;

        private System.Windows.Forms.DataGridView dgvPersonnel;

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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlToolbar = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            pnlGridHeader = new Panel();
            lblGridTitle = new Label();
            lblPersonnelCount = new Label();
            dgvPersonnel = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlGridHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonnel).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(29, 20, 29, 13);
            pnlHeader.Size = new Size(1122, 133);
            pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(35, 55, 65);
            lblTitle.Location = new Point(29, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(319, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Delivery Personnel";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(32, 83);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(419, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "View and search personnel assigned to delivery operations.";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(lblSearch);
            pnlToolbar.Controls.Add(txtSearch);
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 133);
            pnlToolbar.Margin = new Padding(3, 4, 3, 4);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(29, 20, 29, 13);
            pnlToolbar.Size = new Size(1122, 100);
            pnlToolbar.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(65, 75, 80);
            lblSearch.Location = new Point(29, 36);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(59, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(103, 29);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(343, 30);
            txtSearch.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(0, 137, 123);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(466, 21);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 45);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pnlGridHeader
            // 
            pnlGridHeader.BackColor = Color.White;
            pnlGridHeader.Controls.Add(lblGridTitle);
            pnlGridHeader.Controls.Add(lblPersonnelCount);
            pnlGridHeader.Dock = DockStyle.Top;
            pnlGridHeader.Location = new Point(0, 233);
            pnlGridHeader.Margin = new Padding(3, 4, 3, 4);
            pnlGridHeader.Name = "pnlGridHeader";
            pnlGridHeader.Padding = new Padding(29, 13, 29, 7);
            pnlGridHeader.Size = new Size(1122, 73);
            pnlGridHeader.TabIndex = 1;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.FromArgb(35, 55, 65);
            lblGridTitle.Location = new Point(29, 20);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(135, 25);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "Personnel List";
            // 
            // lblPersonnelCount
            // 
            lblPersonnelCount.AutoSize = true;
            lblPersonnelCount.Font = new Font("Segoe UI", 9F);
            lblPersonnelCount.ForeColor = Color.Gray;
            lblPersonnelCount.Location = new Point(206, 23);
            lblPersonnelCount.Name = "lblPersonnelCount";
            lblPersonnelCount.Size = new Size(86, 20);
            lblPersonnelCount.TabIndex = 1;
            lblPersonnelCount.Text = "0 personnel";
            // 
            // dgvPersonnel
            // 
            dgvPersonnel.AllowUserToAddRows = false;
            dgvPersonnel.AllowUserToDeleteRows = false;
            dgvPersonnel.AllowUserToResizeRows = false;
            dgvPersonnel.BackgroundColor = Color.White;
            dgvPersonnel.BorderStyle = BorderStyle.None;
            dgvPersonnel.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPersonnel.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 105, 92);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 105, 92);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPersonnel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPersonnel.ColumnHeadersHeight = 45;
            dgvPersonnel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(50, 60, 65);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(220, 240, 237);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 50, 55);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPersonnel.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPersonnel.Dock = DockStyle.Fill;
            dgvPersonnel.EnableHeadersVisualStyles = false;
            dgvPersonnel.GridColor = Color.FromArgb(235, 238, 240);
            dgvPersonnel.Location = new Point(0, 306);
            dgvPersonnel.Margin = new Padding(3, 4, 3, 4);
            dgvPersonnel.MultiSelect = false;
            dgvPersonnel.Name = "dgvPersonnel";
            dgvPersonnel.ReadOnly = true;
            dgvPersonnel.RowHeadersVisible = false;
            dgvPersonnel.RowHeadersWidth = 51;
            dgvPersonnel.RowTemplate.Height = 42;
            dgvPersonnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonnel.Size = new Size(1122, 498);
            dgvPersonnel.TabIndex = 0;
            // 
            // DeliveryPersonnelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 248);
            ClientSize = new Size(1122, 804);
            Controls.Add(dgvPersonnel);
            Controls.Add(pnlGridHeader);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DeliveryPersonnelForm";
            Text = "Delivery Personnel";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlGridHeader.ResumeLayout(false);
            pnlGridHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonnel).EndInit();
            ResumeLayout(false);
        }
    }
}
