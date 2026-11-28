using System.Drawing;
using System.Windows.Forms;

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

        private System.Windows.Forms.Panel pnlGridContainer;
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
            pnlGridContainer = new Panel();
            dgvPersonnel = new DataGridView();

            pnlHeader.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlGridHeader.SuspendLayout();
            pnlGridContainer.SuspendLayout();
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
            lblTitle.Text = "Delivery Personnel";

            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(27, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(390, 21);
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
            txtSearch.PlaceholderText = "Search by ID, name, username, or role...";
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
            pnlGridHeader.Controls.Add(lblGridTitle);
            pnlGridHeader.Controls.Add(lblPersonnelCount);
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
            lblGridTitle.Size = new Size(135, 25);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "Personnel List";

            lblPersonnelCount.AutoSize = true;
            lblPersonnelCount.Font = new Font("Segoe UI", 9.5F);
            lblPersonnelCount.ForeColor = Color.Gray;
            lblPersonnelCount.Location = new Point(165, 14);
            lblPersonnelCount.Name = "lblPersonnelCount";
            lblPersonnelCount.Size = new Size(86, 20);
            lblPersonnelCount.TabIndex = 1;
            lblPersonnelCount.Text = "0 personnel";

            // 
            // pnlGridContainer
            // 
            pnlGridContainer.BackColor = Color.White;
            pnlGridContainer.Controls.Add(dgvPersonnel);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(0, 185);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(25, 4, 25, 25);
            pnlGridContainer.Size = new Size(1122, 619);
            pnlGridContainer.TabIndex = 3;

            // 
            // dgvPersonnel
            // 
            dgvPersonnel.AllowUserToAddRows = false;
            dgvPersonnel.AllowUserToDeleteRows = false;
            dgvPersonnel.AllowUserToResizeRows = false;
            dgvPersonnel.BackgroundColor = Color.White;
            dgvPersonnel.BorderStyle = BorderStyle.FixedSingle;
            dgvPersonnel.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPersonnel.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPersonnel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPersonnel.ColumnHeadersHeight = 42;
            dgvPersonnel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(45, 55, 55);
            dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(215, 235, 235);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 60, 60);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPersonnel.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPersonnel.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 250, 250);
            dgvPersonnel.Dock = DockStyle.Fill;
            dgvPersonnel.EnableHeadersVisualStyles = false;
            dgvPersonnel.GridColor = Color.FromArgb(230, 235, 235);
            dgvPersonnel.Location = new Point(25, 4);
            dgvPersonnel.MultiSelect = false;
            dgvPersonnel.Name = "dgvPersonnel";
            dgvPersonnel.ReadOnly = true;
            dgvPersonnel.RowHeadersVisible = false;
            dgvPersonnel.RowTemplate.Height = 38;
            dgvPersonnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonnel.Size = new Size(1072, 590);
            dgvPersonnel.TabIndex = 0;

            // 
            // DeliveryPersonnelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1122, 804);
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlGridHeader);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Name = "DeliveryPersonnelForm";
            Text = "Delivery Personnel";

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlGridHeader.ResumeLayout(false);
            pnlGridHeader.PerformLayout();
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonnel).EndInit();
            ResumeLayout(false);
        }
    }
}