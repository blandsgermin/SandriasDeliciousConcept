using System.Drawing;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Delivery
{
    partial class DeliveryHistoryForm
    {
        private System.ComponentModel.IContainer? components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbDelivery;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Panel pnlGridHeader;
        private System.Windows.Forms.Label lblHistoryInfo;
        private System.Windows.Forms.Label lblHistoryCount;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridView dgvHistory;

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
            cmbDelivery = new ComboBox();
            lblDelivery = new Label();
            pnlGridHeader = new Panel();
            lblHistoryInfo = new Label();
            lblHistoryCount = new Label();
            lblGridTitle = new Label();
            pnlGridContainer = new Panel();
            dgvHistory = new DataGridView();

            pnlHeader.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlGridHeader.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
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
            lblTitle.Size = new Size(255, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Delivery History";

            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(27, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(375, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Review the status changes of your delivery records.";

            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Controls.Add(cmbDelivery);
            pnlToolbar.Controls.Add(lblDelivery);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 85);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(25, 10, 25, 10);
            pnlToolbar.Size = new Size(1122, 58);
            pnlToolbar.TabIndex = 1;

            lblDelivery.AutoSize = true;
            lblDelivery.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDelivery.ForeColor = Color.DarkSlateGray;
            lblDelivery.Location = new Point(25, 18);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(115, 21);
            lblDelivery.TabIndex = 0;
            lblDelivery.Text = "Select Delivery:";

            cmbDelivery.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDelivery.Font = new Font("Segoe UI", 10F);
            cmbDelivery.FormattingEnabled = true;
            cmbDelivery.Location = new Point(148, 13);
            cmbDelivery.Name = "cmbDelivery";
            cmbDelivery.Size = new Size(360, 31);
            cmbDelivery.TabIndex = 1;

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

            // 
            // pnlGridHeader
            // 
            pnlGridHeader.BackColor = Color.White;
            pnlGridHeader.Controls.Add(lblHistoryInfo);
            pnlGridHeader.Controls.Add(lblHistoryCount);
            pnlGridHeader.Controls.Add(lblGridTitle);
            pnlGridHeader.Dock = DockStyle.Top;
            pnlGridHeader.Location = new Point(0, 143);
            pnlGridHeader.Name = "pnlGridHeader";
            pnlGridHeader.Padding = new Padding(25, 8, 25, 6);
            pnlGridHeader.Size = new Size(1122, 62);
            pnlGridHeader.TabIndex = 2;

            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.DarkSlateGray;
            lblGridTitle.Location = new Point(25, 8);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(155, 25);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "Status History";

            lblHistoryCount.AutoSize = true;
            lblHistoryCount.Font = new Font("Segoe UI", 9.5F);
            lblHistoryCount.ForeColor = Color.Gray;
            lblHistoryCount.Location = new Point(185, 12);
            lblHistoryCount.Name = "lblHistoryCount";
            lblHistoryCount.Size = new Size(125, 20);
            lblHistoryCount.TabIndex = 1;
            lblHistoryCount.Text = "0 history records";

            lblHistoryInfo.AutoSize = true;
            lblHistoryInfo.Font = new Font("Segoe UI", 9F);
            lblHistoryInfo.ForeColor = Color.DimGray;
            lblHistoryInfo.Location = new Point(25, 36);
            lblHistoryInfo.Name = "lblHistoryInfo";
            lblHistoryInfo.Size = new Size(275, 20);
            lblHistoryInfo.TabIndex = 2;
            lblHistoryInfo.Text = "Select a delivery to view its status history.";

            // 
            // pnlGridContainer
            // 
            pnlGridContainer.BackColor = Color.White;
            pnlGridContainer.Controls.Add(dgvHistory);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(0, 205);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(25, 4, 25, 25);
            pnlGridContainer.Size = new Size(1122, 599);
            pnlGridContainer.TabIndex = 3;

            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AllowUserToResizeRows = false;
            dgvHistory.AutoGenerateColumns = true;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.White;
            dgvHistory.BorderStyle = BorderStyle.FixedSingle;
            dgvHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHistory.ColumnHeadersHeight = 42;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.GridColor = Color.FromArgb(230, 235, 235);
            dgvHistory.Location = new Point(25, 4);
            dgvHistory.MultiSelect = false;
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowTemplate.Height = 38;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(1072, 570);
            dgvHistory.TabIndex = 0;

            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.DarkSlateGray;
            headerStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            headerStyle.ForeColor = Color.White;
            headerStyle.Padding = new Padding(8, 0, 8, 0);
            headerStyle.SelectionBackColor = Color.DarkSlateGray;
            headerStyle.SelectionForeColor = Color.White;
            dgvHistory.ColumnHeadersDefaultCellStyle = headerStyle;

            cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = Color.White;
            cellStyle.Font = new Font("Segoe UI", 9.5F);
            cellStyle.ForeColor = Color.FromArgb(45, 55, 55);
            cellStyle.Padding = new Padding(8, 4, 8, 4);
            cellStyle.SelectionBackColor = Color.FromArgb(215, 235, 235);
            cellStyle.SelectionForeColor = Color.FromArgb(30, 60, 60);
            dgvHistory.DefaultCellStyle = cellStyle;

            altCellStyle.BackColor = Color.FromArgb(247, 250, 250);
            dgvHistory.AlternatingRowsDefaultCellStyle = altCellStyle;

            // 
            // DeliveryHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1122, 804);
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlGridHeader);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(850, 500);
            Name = "DeliveryHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delivery History";

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlGridHeader.ResumeLayout(false);
            pnlGridHeader.PerformLayout();
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
        }
    }
}