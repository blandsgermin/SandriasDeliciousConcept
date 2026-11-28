namespace SandriasDeliciousConcept.Delivery
{
    partial class DeliveryDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.TableLayoutPanel tlpSummaryCards;
        private System.Windows.Forms.Panel toolbarPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel navigationHost;

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnPersonnel;
        private System.Windows.Forms.Button btnApprovedRequests;
        private System.Windows.Forms.Button btnDeliverySchedule;
        private System.Windows.Forms.Button btnDeliveryRecords;
        private System.Windows.Forms.Button btnDeliveryHistory;

        private System.Windows.Forms.Panel cardScheduled;
        private System.Windows.Forms.Panel cardPreparing;
        private System.Windows.Forms.Panel cardOutForDelivery;
        private System.Windows.Forms.Panel cardDelivered;

        private System.Windows.Forms.Label lblScheduledTitle;
        private System.Windows.Forms.Label lblPreparingTitle;
        private System.Windows.Forms.Label lblOutForDeliveryTitle;
        private System.Windows.Forms.Label lblDeliveredTitle;

        private System.Windows.Forms.Label lblScheduled;
        private System.Windows.Forms.Label lblPreparing;
        private System.Windows.Forms.Label lblOutForDelivery;
        private System.Windows.Forms.Label lblDelivered;

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.DataGridView dgvDeliveries;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            sidebarPanel = new System.Windows.Forms.Panel();
            mainPanel = new System.Windows.Forms.Panel();
            headerPanel = new System.Windows.Forms.Panel();
            summaryPanel = new System.Windows.Forms.Panel();
            tlpSummaryCards = new System.Windows.Forms.TableLayoutPanel();
            toolbarPanel = new System.Windows.Forms.Panel();
            contentPanel = new System.Windows.Forms.Panel();
            navigationHost = new System.Windows.Forms.Panel();

            lblBrand = new System.Windows.Forms.Label();
            lblBrandSubtitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();

            btnDashboard = new System.Windows.Forms.Button();
            btnPersonnel = new System.Windows.Forms.Button();
            btnApprovedRequests = new System.Windows.Forms.Button();
            btnDeliverySchedule = new System.Windows.Forms.Button();
            btnDeliveryRecords = new System.Windows.Forms.Button();
            btnDeliveryHistory = new System.Windows.Forms.Button();

            cardScheduled = new System.Windows.Forms.Panel();
            cardPreparing = new System.Windows.Forms.Panel();
            cardOutForDelivery = new System.Windows.Forms.Panel();
            cardDelivered = new System.Windows.Forms.Panel();

            lblScheduledTitle = new System.Windows.Forms.Label();
            lblPreparingTitle = new System.Windows.Forms.Label();
            lblOutForDeliveryTitle = new System.Windows.Forms.Label();
            lblDeliveredTitle = new System.Windows.Forms.Label();

            lblScheduled = new System.Windows.Forms.Label();
            lblPreparing = new System.Windows.Forms.Label();
            lblOutForDelivery = new System.Windows.Forms.Label();
            lblDelivered = new System.Windows.Forms.Label();

            lblSearch = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            btnSchedule = new System.Windows.Forms.Button();
            btnUpdateStatus = new System.Windows.Forms.Button();
            dgvDeliveries = new System.Windows.Forms.DataGridView();

            sidebarPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            summaryPanel.SuspendLayout();
            tlpSummaryCards.SuspendLayout();
            toolbarPanel.SuspendLayout();
            contentPanel.SuspendLayout();

            cardScheduled.SuspendLayout();
            cardPreparing.SuspendLayout();
            cardOutForDelivery.SuspendLayout();
            cardDelivered.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)dgvDeliveries).BeginInit();

            SuspendLayout();

            // FORM
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1400, 850);
            MinimumSize = new System.Drawing.Size(1100, 700);
            Name = "DeliveryDashboardForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Delivery Dashboard";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;

            // SIDEBAR
            sidebarPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            sidebarPanel.Width = 230;
            sidebarPanel.Name = "sidebarPanel";

            // BRAND
            lblBrand.AutoSize = false;
            lblBrand.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            lblBrand.ForeColor = System.Drawing.Color.White;
            lblBrand.Location = new System.Drawing.Point(18, 30);
            lblBrand.Size = new System.Drawing.Size(200, 35);
            lblBrand.Text = "SANDRIA'S";
            lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            lblBrandSubtitle.AutoSize = false;
            lblBrandSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblBrandSubtitle.ForeColor = System.Drawing.Color.Gainsboro;
            lblBrandSubtitle.Location = new System.Drawing.Point(20, 66);
            lblBrandSubtitle.Size = new System.Drawing.Size(195, 25);
            lblBrandSubtitle.Text = "DELICIOUS CONCEPT";
            lblBrandSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // SIDEBAR BUTTONS
            ConfigureSidebarButton(btnDashboard, "Dashboard", 150);
            ConfigureSidebarButton(btnPersonnel, "Delivery Personnel", 205);
            ConfigureSidebarButton(btnApprovedRequests, "Approved Requests", 260);
            ConfigureSidebarButton(btnDeliverySchedule, "Delivery Schedule", 315);
            ConfigureSidebarButton(btnDeliveryRecords, "Delivery Records", 370);
            ConfigureSidebarButton(btnDeliveryHistory, "Delivery History", 425);

            btnDashboard.Click += btnDashboard_Click;
            btnPersonnel.Click += btnPersonnel_Click;
            btnApprovedRequests.Click += btnApprovedRequests_Click;
            btnDeliverySchedule.Click += btnDeliverySchedule_Click;
            btnDeliveryRecords.Click += btnDeliveryRecords_Click;
            btnDeliveryHistory.Click += btnDeliveryHistory_Click;

            sidebarPanel.Controls.Add(lblBrand);
            sidebarPanel.Controls.Add(lblBrandSubtitle);
            sidebarPanel.Controls.Add(btnDashboard);
            sidebarPanel.Controls.Add(btnPersonnel);
            sidebarPanel.Controls.Add(btnApprovedRequests);
            sidebarPanel.Controls.Add(btnDeliverySchedule);
            sidebarPanel.Controls.Add(btnDeliveryRecords);
            sidebarPanel.Controls.Add(btnDeliveryHistory);

            // MAIN PANEL
            mainPanel.BackColor = System.Drawing.Color.White;
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Name = "mainPanel";

            // HEADER
            headerPanel.BackColor = System.Drawing.Color.White;
            headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            headerPanel.Height = 80;
            headerPanel.Padding = new System.Windows.Forms.Padding(25, 10, 20, 10);
            headerPanel.Name = "headerPanel";

            lblTitle.AutoSize = false;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            lblTitle.Location = new System.Drawing.Point(20, 10);
            lblTitle.Size = new System.Drawing.Size(650, 35);
            lblTitle.Text = "Delivery Dashboard";

            lblSubtitle.AutoSize = false;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            lblSubtitle.Location = new System.Drawing.Point(22, 46);
            lblSubtitle.Size = new System.Drawing.Size(650, 22);
            lblSubtitle.Text = "Manage delivery schedules, personnel, and delivery records";

            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(lblSubtitle);

            // SUMMARY PANEL WITH RESPONSIVE 4-COLUMN TABLELAYOUTPANEL
            summaryPanel.BackColor = System.Drawing.Color.White;
            summaryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            summaryPanel.Height = 145;
            summaryPanel.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            summaryPanel.Name = "summaryPanel";

            tlpSummaryCards.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpSummaryCards.ColumnCount = 4;
            tlpSummaryCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpSummaryCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpSummaryCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpSummaryCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpSummaryCards.RowCount = 1;
            tlpSummaryCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpSummaryCards.Name = "tlpSummaryCards";

            ConfigureSummaryCard(
                cardScheduled, lblScheduledTitle, lblScheduled,
                "Scheduled", "00",
                System.Drawing.Color.FromArgb(225, 239, 239),
                new System.Windows.Forms.Padding(0, 0, 8, 0));

            ConfigureSummaryCard(
                cardPreparing, lblPreparingTitle, lblPreparing,
                "Preparing", "00",
                System.Drawing.Color.FromArgb(255, 244, 220),
                new System.Windows.Forms.Padding(8, 0, 8, 0));

            ConfigureSummaryCard(
                cardOutForDelivery, lblOutForDeliveryTitle, lblOutForDelivery,
                "Out for Delivery", "00",
                System.Drawing.Color.FromArgb(225, 235, 250),
                new System.Windows.Forms.Padding(8, 0, 8, 0));

            ConfigureSummaryCard(
                cardDelivered, lblDeliveredTitle, lblDelivered,
                "Delivered", "00",
                System.Drawing.Color.FromArgb(225, 242, 229),
                new System.Windows.Forms.Padding(8, 0, 0, 0));

            tlpSummaryCards.Controls.Add(cardScheduled, 0, 0);
            tlpSummaryCards.Controls.Add(cardPreparing, 1, 0);
            tlpSummaryCards.Controls.Add(cardOutForDelivery, 2, 0);
            tlpSummaryCards.Controls.Add(cardDelivered, 3, 0);

            summaryPanel.Controls.Add(tlpSummaryCards);

            // TOOLBAR
            toolbarPanel.BackColor = System.Drawing.Color.White;
            toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            toolbarPanel.Height = 62;
            toolbarPanel.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            toolbarPanel.Name = "toolbarPanel";

            lblSearch.AutoSize = false;
            lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            lblSearch.Location = new System.Drawing.Point(20, 17);
            lblSearch.Size = new System.Drawing.Size(60, 25);
            lblSearch.Text = "Search:";

            txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSearch.Location = new System.Drawing.Point(85, 14);
            txtSearch.Size = new System.Drawing.Size(290, 30);
            txtSearch.PlaceholderText = "Search deliveries...";
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Name = "txtSearch";
            txtSearch.TextChanged += txtSearch_TextChanged;

            btnSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Location = new System.Drawing.Point(383, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(90, 34);
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;

            ConfigureSecondaryToolbarButton(btnRefresh, "Refresh", 700, 110);
            ConfigureSecondaryToolbarButton(btnUpdateStatus, "Update Status", 820, 140);
            ConfigurePrimaryToolbarButton(btnSchedule, "+ Schedule Delivery", 970, 180);

            btnRefresh.Click += btnRefresh_Click;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            btnSchedule.Click += btnSchedule_Click;

            toolbarPanel.Controls.Add(lblSearch);
            toolbarPanel.Controls.Add(txtSearch);
            toolbarPanel.Controls.Add(btnSearch);
            toolbarPanel.Controls.Add(btnRefresh);
            toolbarPanel.Controls.Add(btnUpdateStatus);
            toolbarPanel.Controls.Add(btnSchedule);

            // CONTENT PANEL
            contentPanel.BackColor = System.Drawing.Color.White;
            contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            contentPanel.Padding = new System.Windows.Forms.Padding(20, 5, 20, 20);
            contentPanel.Name = "contentPanel";

            dgvDeliveries.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDeliveries.Name = "dgvDeliveries";
            dgvDeliveries.AutoGenerateColumns = true;
            dgvDeliveries.ReadOnly = true;
            dgvDeliveries.AllowUserToAddRows = false;
            dgvDeliveries.AllowUserToDeleteRows = false;
            dgvDeliveries.AllowUserToResizeRows = false;
            dgvDeliveries.MultiSelect = false;
            dgvDeliveries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDeliveries.RowHeadersVisible = false;
            dgvDeliveries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDeliveries.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            dgvDeliveries.BackgroundColor = System.Drawing.Color.White;
            dgvDeliveries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvDeliveries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDeliveries.GridColor = System.Drawing.Color.FromArgb(230, 235, 235);
            dgvDeliveries.EnableHeadersVisualStyles = false;

            dgvDeliveries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvDeliveries.ColumnHeadersHeight = 42;
            dgvDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDeliveries.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            dgvDeliveries.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvDeliveries.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvDeliveries.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvDeliveries.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);

            dgvDeliveries.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvDeliveries.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(45, 55, 55);
            dgvDeliveries.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvDeliveries.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(215, 235, 235);
            dgvDeliveries.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 60, 60);
            dgvDeliveries.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);

            dgvDeliveries.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(247, 250, 250);

            dgvDeliveries.RowTemplate.Height = 36;

            contentPanel.Controls.Add(dgvDeliveries);

            // NAVIGATION HOST
            navigationHost.BackColor = System.Drawing.Color.White;
            navigationHost.Dock = System.Windows.Forms.DockStyle.Fill;
            navigationHost.Name = "navigationHost";
            navigationHost.Visible = false;

            // DOCK ORDER: FILL CONTROLS FIRST, TOP CONTROLS LAST
            mainPanel.Controls.Add(navigationHost);
            mainPanel.Controls.Add(contentPanel);
            mainPanel.Controls.Add(toolbarPanel);
            mainPanel.Controls.Add(summaryPanel);
            mainPanel.Controls.Add(headerPanel);

            Controls.Add(mainPanel);
            Controls.Add(sidebarPanel);

            sidebarPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            summaryPanel.ResumeLayout(false);
            tlpSummaryCards.ResumeLayout(false);
            toolbarPanel.ResumeLayout(false);
            toolbarPanel.PerformLayout();
            contentPanel.ResumeLayout(false);

            cardScheduled.ResumeLayout(false);
            cardPreparing.ResumeLayout(false);
            cardOutForDelivery.ResumeLayout(false);
            cardDelivered.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)dgvDeliveries).EndInit();

            ResumeLayout(false);
        }

        private void ConfigureSidebarButton(
            System.Windows.Forms.Button button,
            string text,
            int top)
        {
            button.BackColor = System.Drawing.Color.DarkSlateGray;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(42, 91, 91);
            button.FlatAppearance.MouseDownBackColor =
                System.Drawing.Color.FromArgb(18, 52, 52);

            button.Font = new System.Drawing.Font(
                "Segoe UI", 10.5F, System.Drawing.FontStyle.Regular);

            button.ForeColor = System.Drawing.Color.White;
            button.Location = new System.Drawing.Point(0, top);
            button.Size = new System.Drawing.Size(230, 50);
            button.Text = text;
            button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            button.UseVisualStyleBackColor = false;
            button.Visible = true;
            button.Enabled = true;
        }

        private void ConfigurePrimaryToolbarButton(
            System.Windows.Forms.Button button,
            string text,
            int left,
            int width)
        {
            button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button.BackColor = System.Drawing.Color.Teal;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            button.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            button.ForeColor = System.Drawing.Color.White;
            button.Location = new System.Drawing.Point(left, 12);
            button.Size = new System.Drawing.Size(width, 36);
            button.Text = text;
            button.UseVisualStyleBackColor = false;
            button.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void ConfigureSecondaryToolbarButton(
            System.Windows.Forms.Button button,
            string text,
            int left,
            int width)
        {
            button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button.BackColor = System.Drawing.Color.White;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 245, 245);
            button.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            button.ForeColor = System.Drawing.Color.DarkSlateGray;
            button.Location = new System.Drawing.Point(left, 12);
            button.Size = new System.Drawing.Size(width, 36);
            button.Text = text;
            button.UseVisualStyleBackColor = false;
            button.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void ConfigureSummaryCard(
            System.Windows.Forms.Panel card,
            System.Windows.Forms.Label title,
            System.Windows.Forms.Label value,
            string titleText,
            string valueText,
            System.Drawing.Color background,
            System.Windows.Forms.Padding margin)
        {
            card.BackColor = background;
            card.Dock = System.Windows.Forms.DockStyle.Fill;
            card.Margin = margin;
            card.BorderStyle = System.Windows.Forms.BorderStyle.None;

            title.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            title.ForeColor = System.Drawing.Color.FromArgb(65, 80, 80);
            title.Location = new System.Drawing.Point(18, 15);
            title.Size = new System.Drawing.Size(215, 25);
            title.Text = titleText;

            value.Font = new System.Drawing.Font(
                "Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            value.ForeColor = System.Drawing.Color.FromArgb(30, 65, 65);
            value.Location = new System.Drawing.Point(18, 48);
            value.Size = new System.Drawing.Size(215, 50);
            value.Text = valueText;

            card.Controls.Add(title);
            card.Controls.Add(value);
        }
    }
}