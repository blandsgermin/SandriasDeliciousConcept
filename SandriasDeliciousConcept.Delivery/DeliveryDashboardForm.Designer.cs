
namespace SandriasDeliciousConcept.Delivery
{
    partial class DeliveryDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Panel toolbarPanel;
        private System.Windows.Forms.Panel contentPanel;

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblGridTitle;

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

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnUpdateStatus;

        private System.Windows.Forms.DataGridView dgvDeliveries;

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
            sidebarPanel = new Panel();
            lblBrand = new Label();
            lblBrandSubtitle = new Label();
            btnDashboard = new Button();
            btnPersonnel = new Button();
            btnApprovedRequests = new Button();
            btnDeliverySchedule = new Button();
            btnDeliveryRecords = new Button();
            btnDeliveryHistory = new Button();
            mainPanel = new Panel();
            contentPanel = new Panel();
            dgvDeliveries = new DataGridView();
            lblGridTitle = new Label();
            toolbarPanel = new Panel();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            btnSchedule = new Button();
            btnUpdateStatus = new Button();
            summaryPanel = new Panel();
            cardScheduled = new Panel();
            lblScheduled = new Label();
            lblScheduledTitle = new Label();
            cardPreparing = new Panel();
            lblPreparing = new Label();
            lblPreparingTitle = new Label();
            cardOutForDelivery = new Panel();
            lblOutForDelivery = new Label();
            lblOutForDeliveryTitle = new Label();
            cardDelivered = new Panel();
            lblDelivered = new Label();
            lblDeliveredTitle = new Label();
            headerPanel = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            sidebarPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeliveries).BeginInit();
            toolbarPanel.SuspendLayout();
            summaryPanel.SuspendLayout();
            cardScheduled.SuspendLayout();
            cardPreparing.SuspendLayout();
            cardOutForDelivery.SuspendLayout();
            cardDelivered.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(46, 80, 80);
            sidebarPanel.Controls.Add(lblBrand);
            sidebarPanel.Controls.Add(lblBrandSubtitle);
            sidebarPanel.Controls.Add(btnDashboard);
            sidebarPanel.Controls.Add(btnPersonnel);
            sidebarPanel.Controls.Add(btnApprovedRequests);
            sidebarPanel.Controls.Add(btnDeliverySchedule);
            sidebarPanel.Controls.Add(btnDeliveryRecords);
            sidebarPanel.Controls.Add(btnDeliveryHistory);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(230, 800);
            sidebarPanel.TabIndex = 1;
            // 
            // lblBrand
            // 
            lblBrand.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(10, 125);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(210, 55);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Sandrias";
            lblBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBrandSubtitle
            // 
            lblBrandSubtitle.Font = new Font("Segoe UI", 11F);
            lblBrandSubtitle.ForeColor = Color.White;
            lblBrandSubtitle.Location = new Point(10, 185);
            lblBrandSubtitle.Name = "lblBrandSubtitle";
            lblBrandSubtitle.Size = new Size(210, 35);
            lblBrandSubtitle.TabIndex = 1;
            lblBrandSubtitle.Text = "Delicious Concept";
            lblBrandSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Teal;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 300);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(230, 50);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnPersonnel
            // 
            btnPersonnel.BackColor = Color.FromArgb(46, 80, 80);
            btnPersonnel.FlatAppearance.BorderSize = 0;
            btnPersonnel.FlatStyle = FlatStyle.Flat;
            btnPersonnel.Font = new Font("Segoe UI", 11F);
            btnPersonnel.ForeColor = Color.White;
            btnPersonnel.Location = new Point(0, 350);
            btnPersonnel.Name = "btnPersonnel";
            btnPersonnel.Size = new Size(230, 50);
            btnPersonnel.TabIndex = 3;
            btnPersonnel.Text = "Delivery Personnel";
            btnPersonnel.UseVisualStyleBackColor = false;
            btnPersonnel.Click += btnPersonnel_Click;
            // 
            // btnApprovedRequests
            // 
            btnApprovedRequests.BackColor = Color.FromArgb(46, 80, 80);
            btnApprovedRequests.FlatAppearance.BorderSize = 0;
            btnApprovedRequests.FlatStyle = FlatStyle.Flat;
            btnApprovedRequests.Font = new Font("Segoe UI", 11F);
            btnApprovedRequests.ForeColor = Color.White;
            btnApprovedRequests.Location = new Point(0, 400);
            btnApprovedRequests.Name = "btnApprovedRequests";
            btnApprovedRequests.Size = new Size(230, 50);
            btnApprovedRequests.TabIndex = 4;
            btnApprovedRequests.Text = "Approved Requests";
            btnApprovedRequests.UseVisualStyleBackColor = false;
            btnApprovedRequests.Click += btnApprovedRequests_Click;
            // 
            // btnDeliverySchedule
            // 
            btnDeliverySchedule.BackColor = Color.FromArgb(46, 80, 80);
            btnDeliverySchedule.FlatAppearance.BorderSize = 0;
            btnDeliverySchedule.FlatStyle = FlatStyle.Flat;
            btnDeliverySchedule.Font = new Font("Segoe UI", 11F);
            btnDeliverySchedule.ForeColor = Color.White;
            btnDeliverySchedule.Location = new Point(0, 450);
            btnDeliverySchedule.Name = "btnDeliverySchedule";
            btnDeliverySchedule.Size = new Size(230, 50);
            btnDeliverySchedule.TabIndex = 5;
            btnDeliverySchedule.Text = "Delivery Schedule";
            btnDeliverySchedule.UseVisualStyleBackColor = false;
            btnDeliverySchedule.Click += btnDeliverySchedule_Click;
            // 
            // btnDeliveryRecords
            // 
            btnDeliveryRecords.BackColor = Color.FromArgb(46, 80, 80);
            btnDeliveryRecords.FlatAppearance.BorderSize = 0;
            btnDeliveryRecords.FlatStyle = FlatStyle.Flat;
            btnDeliveryRecords.Font = new Font("Segoe UI", 11F);
            btnDeliveryRecords.ForeColor = Color.White;
            btnDeliveryRecords.Location = new Point(0, 500);
            btnDeliveryRecords.Name = "btnDeliveryRecords";
            btnDeliveryRecords.Size = new Size(230, 50);
            btnDeliveryRecords.TabIndex = 6;
            btnDeliveryRecords.Text = "Delivery Records";
            btnDeliveryRecords.UseVisualStyleBackColor = false;
            btnDeliveryRecords.Click += btnDeliveryRecords_Click;
            // 
            // btnDeliveryHistory
            // 
            btnDeliveryHistory.BackColor = Color.FromArgb(46, 80, 80);
            btnDeliveryHistory.FlatAppearance.BorderSize = 0;
            btnDeliveryHistory.FlatStyle = FlatStyle.Flat;
            btnDeliveryHistory.Font = new Font("Segoe UI", 11F);
            btnDeliveryHistory.ForeColor = Color.White;
            btnDeliveryHistory.Location = new Point(0, 550);
            btnDeliveryHistory.Name = "btnDeliveryHistory";
            btnDeliveryHistory.Size = new Size(230, 50);
            btnDeliveryHistory.TabIndex = 7;
            btnDeliveryHistory.Text = "Delivery History";
            btnDeliveryHistory.UseVisualStyleBackColor = false;
            btnDeliveryHistory.Click += btnDeliveryHistory_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(245, 245, 245);
            mainPanel.Controls.Add(contentPanel);
            mainPanel.Controls.Add(toolbarPanel);
            mainPanel.Controls.Add(summaryPanel);
            mainPanel.Controls.Add(headerPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(230, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1170, 800);
            mainPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(245, 245, 245);
            contentPanel.Controls.Add(dgvDeliveries);
            contentPanel.Controls.Add(lblGridTitle);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 295);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(18, 10, 18, 18);
            contentPanel.Size = new Size(1170, 505);
            contentPanel.TabIndex = 0;
            // 
            // dgvDeliveries
            // 
            dgvDeliveries.AllowUserToAddRows = false;
            dgvDeliveries.AllowUserToDeleteRows = false;
            dgvDeliveries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeliveries.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 80, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDeliveries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDeliveries.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDeliveries.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDeliveries.Dock = DockStyle.Fill;
            dgvDeliveries.EnableHeadersVisualStyles = false;
            dgvDeliveries.Location = new Point(18, 52);
            dgvDeliveries.MultiSelect = false;
            dgvDeliveries.Name = "dgvDeliveries";
            dgvDeliveries.ReadOnly = true;
            dgvDeliveries.RowHeadersVisible = false;
            dgvDeliveries.RowHeadersWidth = 51;
            dgvDeliveries.RowTemplate.Height = 35;
            dgvDeliveries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeliveries.Size = new Size(1134, 435);
            dgvDeliveries.TabIndex = 0;
            // 
            // lblGridTitle
            // 
            lblGridTitle.Dock = DockStyle.Top;
            lblGridTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.FromArgb(43, 83, 88);
            lblGridTitle.Location = new Point(18, 10);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(1134, 42);
            lblGridTitle.TabIndex = 1;
            lblGridTitle.Text = "Delivery Overview";
            lblGridTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolbarPanel
            // 
            toolbarPanel.BackColor = Color.White;
            toolbarPanel.Controls.Add(txtSearch);
            toolbarPanel.Controls.Add(btnRefresh);
            toolbarPanel.Controls.Add(btnSchedule);
            toolbarPanel.Controls.Add(btnUpdateStatus);
            toolbarPanel.Dock = DockStyle.Top;
            toolbarPanel.Location = new Point(0, 230);
            toolbarPanel.Name = "toolbarPanel";
            toolbarPanel.Size = new Size(1170, 65);
            toolbarPanel.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(20, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search delivery number...";
            txtSearch.Size = new Size(435, 30);
            txtSearch.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(43, 83, 88);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(462, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 38);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.BackColor = Color.FromArgb(35, 125, 85);
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSchedule.ForeColor = Color.White;
            btnSchedule.Location = new Point(578, 13);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(170, 38);
            btnSchedule.TabIndex = 2;
            btnSchedule.Text = "Schedule Delivery";
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.FromArgb(190, 115, 35);
            btnUpdateStatus.FlatAppearance.BorderSize = 0;
            btnUpdateStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.Location = new Point(755, 13);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(150, 38);
            btnUpdateStatus.TabIndex = 3;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // summaryPanel
            // 
            summaryPanel.BackColor = Color.FromArgb(245, 245, 245);
            summaryPanel.Controls.Add(cardScheduled);
            summaryPanel.Controls.Add(cardPreparing);
            summaryPanel.Controls.Add(cardOutForDelivery);
            summaryPanel.Controls.Add(cardDelivered);
            summaryPanel.Dock = DockStyle.Top;
            summaryPanel.Location = new Point(0, 75);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new Size(1170, 155);
            summaryPanel.TabIndex = 2;
            // 
            // cardScheduled
            // 
            cardScheduled.BackColor = Color.White;
            cardScheduled.BorderStyle = BorderStyle.FixedSingle;
            cardScheduled.Controls.Add(lblScheduled);
            cardScheduled.Controls.Add(lblScheduledTitle);
            cardScheduled.Location = new Point(20, 20);
            cardScheduled.Name = "cardScheduled";
            cardScheduled.Size = new Size(210, 115);
            cardScheduled.TabIndex = 0;
            // 
            // lblScheduled
            // 
            lblScheduled.Dock = DockStyle.Fill;
            lblScheduled.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblScheduled.ForeColor = Color.FromArgb(43, 83, 88);
            lblScheduled.Location = new Point(0, 42);
            lblScheduled.Name = "lblScheduled";
            lblScheduled.Size = new Size(208, 71);
            lblScheduled.TabIndex = 0;
            lblScheduled.Text = "00";
            lblScheduled.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScheduledTitle
            // 
            lblScheduledTitle.Dock = DockStyle.Top;
            lblScheduledTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblScheduledTitle.ForeColor = Color.FromArgb(43, 83, 88);
            lblScheduledTitle.Location = new Point(0, 0);
            lblScheduledTitle.Name = "lblScheduledTitle";
            lblScheduledTitle.Size = new Size(208, 42);
            lblScheduledTitle.TabIndex = 1;
            lblScheduledTitle.Text = "Scheduled Deliveries";
            lblScheduledTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardPreparing
            // 
            cardPreparing.BackColor = Color.White;
            cardPreparing.BorderStyle = BorderStyle.FixedSingle;
            cardPreparing.Controls.Add(lblPreparing);
            cardPreparing.Controls.Add(lblPreparingTitle);
            cardPreparing.Location = new Point(245, 20);
            cardPreparing.Name = "cardPreparing";
            cardPreparing.Size = new Size(210, 115);
            cardPreparing.TabIndex = 1;
            // 
            // lblPreparing
            // 
            lblPreparing.Dock = DockStyle.Fill;
            lblPreparing.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblPreparing.ForeColor = Color.DarkOrange;
            lblPreparing.Location = new Point(0, 42);
            lblPreparing.Name = "lblPreparing";
            lblPreparing.Size = new Size(208, 71);
            lblPreparing.TabIndex = 0;
            lblPreparing.Text = "00";
            lblPreparing.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPreparingTitle
            // 
            lblPreparingTitle.Dock = DockStyle.Top;
            lblPreparingTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPreparingTitle.ForeColor = Color.FromArgb(43, 83, 88);
            lblPreparingTitle.Location = new Point(0, 0);
            lblPreparingTitle.Name = "lblPreparingTitle";
            lblPreparingTitle.Size = new Size(208, 42);
            lblPreparingTitle.TabIndex = 1;
            lblPreparingTitle.Text = "Preparing";
            lblPreparingTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardOutForDelivery
            // 
            cardOutForDelivery.BackColor = Color.White;
            cardOutForDelivery.BorderStyle = BorderStyle.FixedSingle;
            cardOutForDelivery.Controls.Add(lblOutForDelivery);
            cardOutForDelivery.Controls.Add(lblOutForDeliveryTitle);
            cardOutForDelivery.Location = new Point(470, 20);
            cardOutForDelivery.Name = "cardOutForDelivery";
            cardOutForDelivery.Size = new Size(210, 115);
            cardOutForDelivery.TabIndex = 2;
            // 
            // lblOutForDelivery
            // 
            lblOutForDelivery.Dock = DockStyle.Fill;
            lblOutForDelivery.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblOutForDelivery.ForeColor = Color.DarkViolet;
            lblOutForDelivery.Location = new Point(0, 42);
            lblOutForDelivery.Name = "lblOutForDelivery";
            lblOutForDelivery.Size = new Size(208, 71);
            lblOutForDelivery.TabIndex = 0;
            lblOutForDelivery.Text = "00";
            lblOutForDelivery.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOutForDeliveryTitle
            // 
            lblOutForDeliveryTitle.Dock = DockStyle.Top;
            lblOutForDeliveryTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOutForDeliveryTitle.ForeColor = Color.FromArgb(43, 83, 88);
            lblOutForDeliveryTitle.Location = new Point(0, 0);
            lblOutForDeliveryTitle.Name = "lblOutForDeliveryTitle";
            lblOutForDeliveryTitle.Size = new Size(208, 42);
            lblOutForDeliveryTitle.TabIndex = 1;
            lblOutForDeliveryTitle.Text = "Out for Delivery";
            lblOutForDeliveryTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardDelivered
            // 
            cardDelivered.BackColor = Color.White;
            cardDelivered.BorderStyle = BorderStyle.FixedSingle;
            cardDelivered.Controls.Add(lblDelivered);
            cardDelivered.Controls.Add(lblDeliveredTitle);
            cardDelivered.Location = new Point(695, 20);
            cardDelivered.Name = "cardDelivered";
            cardDelivered.Size = new Size(210, 115);
            cardDelivered.TabIndex = 3;
            // 
            // lblDelivered
            // 
            lblDelivered.Dock = DockStyle.Fill;
            lblDelivered.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblDelivered.ForeColor = Color.ForestGreen;
            lblDelivered.Location = new Point(0, 42);
            lblDelivered.Name = "lblDelivered";
            lblDelivered.Size = new Size(208, 71);
            lblDelivered.TabIndex = 0;
            lblDelivered.Text = "00";
            lblDelivered.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDeliveredTitle
            // 
            lblDeliveredTitle.Dock = DockStyle.Top;
            lblDeliveredTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDeliveredTitle.ForeColor = Color.FromArgb(43, 83, 88);
            lblDeliveredTitle.Location = new Point(0, 0);
            lblDeliveredTitle.Name = "lblDeliveredTitle";
            lblDeliveredTitle.Size = new Size(208, 42);
            lblDeliveredTitle.TabIndex = 1;
            lblDeliveredTitle.Text = "Delivered";
            lblDeliveredTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(lblSubtitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1170, 75);
            headerPanel.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(43, 83, 88);
            lblTitle.Location = new Point(15, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 52);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 100, 100);
            lblSubtitle.Location = new Point(18, 48);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(463, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Monitor scheduled deliveries, personnel and delivery status.";
            // 
            // DeliveryDashboardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1400, 800);
            Controls.Add(mainPanel);
            Controls.Add(sidebarPanel);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1100, 650);
            Name = "DeliveryDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sandria's Delicious Concept - Delivery Dashboard";
            WindowState = FormWindowState.Maximized;
            sidebarPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDeliveries).EndInit();
            toolbarPanel.ResumeLayout(false);
            toolbarPanel.PerformLayout();
            summaryPanel.ResumeLayout(false);
            cardScheduled.ResumeLayout(false);
            cardPreparing.ResumeLayout(false);
            cardOutForDelivery.ResumeLayout(false);
            cardDelivered.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}
