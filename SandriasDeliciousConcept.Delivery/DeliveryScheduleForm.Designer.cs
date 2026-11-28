using System;
using System.Drawing;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Delivery
{
    partial class DeliveryScheduleForm
    {
        private System.ComponentModel.IContainer? components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TableLayoutPanel tlpFormGrid;
        private System.Windows.Forms.Panel pnlRequestCell;
        private System.Windows.Forms.Panel pnlPersonnelCell;
        private System.Windows.Forms.Panel pnlDateCell;
        private System.Windows.Forms.Panel pnlVehicleCell;
        private System.Windows.Forms.Panel pnlAddressCell;
        private System.Windows.Forms.Panel pnlRemarksCell;

        private System.Windows.Forms.Label lblRequestInfo;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.ComboBox cmbApprovedRequest;
        private System.Windows.Forms.Label lblPersonnelInfo;
        private System.Windows.Forms.Label lblPersonnel;
        private System.Windows.Forms.ComboBox cmbPersonnel;
        private System.Windows.Forms.Label lblScheduledDate;
        private System.Windows.Forms.DateTimePicker dtpScheduledDate;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.Label lblDeliveryAddress;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlContent = new Panel();
            tlpFormGrid = new TableLayoutPanel();
            pnlRequestCell = new Panel();
            pnlPersonnelCell = new Panel();
            pnlDateCell = new Panel();
            pnlVehicleCell = new Panel();
            pnlAddressCell = new Panel();
            pnlRemarksCell = new Panel();

            lblRequestInfo = new Label();
            lblRequest = new Label();
            cmbApprovedRequest = new ComboBox();
            lblPersonnelInfo = new Label();
            lblPersonnel = new Label();
            cmbPersonnel = new ComboBox();
            lblScheduledDate = new Label();
            dtpScheduledDate = new DateTimePicker();
            lblVehicle = new Label();
            txtVehicle = new TextBox();
            lblDeliveryAddress = new Label();
            txtDeliveryAddress = new TextBox();
            lblRemarks = new Label();
            txtRemarks = new TextBox();
            pnlButtons = new Panel();
            btnCancel = new Button();
            btnSave = new Button();

            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            tlpFormGrid.SuspendLayout();
            pnlRequestCell.SuspendLayout();
            pnlPersonnelCell.SuspendLayout();
            pnlDateCell.SuspendLayout();
            pnlVehicleCell.SuspendLayout();
            pnlAddressCell.SuspendLayout();
            pnlRemarksCell.SuspendLayout();
            pnlButtons.SuspendLayout();
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
            lblTitle.Size = new Size(275, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Schedule Delivery";

            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(27, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(360, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Assign personnel and schedule an approved request.";

            // 
            // pnlContent
            // 
            pnlContent.AutoScroll = true;
            pnlContent.BackColor = Color.White;
            pnlContent.Controls.Add(tlpFormGrid);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 85);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(25, 10, 25, 20);
            pnlContent.Size = new Size(1122, 644);
            pnlContent.TabIndex = 1;

            // 
            // tlpFormGrid - RESPONSIVE 2-COLUMN FORM GRID
            // 
            tlpFormGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpFormGrid.ColumnCount = 2;
            tlpFormGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFormGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFormGrid.Controls.Add(pnlRequestCell, 0, 0);
            tlpFormGrid.Controls.Add(pnlPersonnelCell, 1, 0);
            tlpFormGrid.Controls.Add(pnlDateCell, 0, 1);
            tlpFormGrid.Controls.Add(pnlVehicleCell, 1, 1);
            tlpFormGrid.Controls.Add(pnlAddressCell, 0, 2);
            tlpFormGrid.Controls.Add(pnlRemarksCell, 0, 3);
            tlpFormGrid.SetColumnSpan(pnlAddressCell, 2);
            tlpFormGrid.SetColumnSpan(pnlRemarksCell, 2);
            tlpFormGrid.Location = new Point(25, 10);
            tlpFormGrid.Name = "tlpFormGrid";
            tlpFormGrid.RowCount = 4;
            tlpFormGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tlpFormGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tlpFormGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tlpFormGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tlpFormGrid.Size = new Size(1072, 420);
            tlpFormGrid.TabIndex = 0;

            // Cell 1: Approved Request
            pnlRequestCell.Dock = DockStyle.Fill;
            pnlRequestCell.Padding = new Padding(0, 0, 14, 0);
            pnlRequestCell.Controls.Add(lblRequest);
            pnlRequestCell.Controls.Add(cmbApprovedRequest);
            pnlRequestCell.Controls.Add(lblRequestInfo);

            lblRequest.AutoSize = true;
            lblRequest.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRequest.ForeColor = Color.DarkSlateGray;
            lblRequest.Location = new Point(0, 4);
            lblRequest.Text = "Approved Request";

            cmbApprovedRequest.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbApprovedRequest.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbApprovedRequest.Font = new Font("Segoe UI", 10F);
            cmbApprovedRequest.FormattingEnabled = true;
            cmbApprovedRequest.Location = new Point(0, 30);
            cmbApprovedRequest.Name = "cmbApprovedRequest";
            cmbApprovedRequest.Size = new Size(522, 31);
            cmbApprovedRequest.TabIndex = 1;

            lblRequestInfo.AutoSize = true;
            lblRequestInfo.Font = new Font("Segoe UI", 8.5F);
            lblRequestInfo.ForeColor = Color.Gray;
            lblRequestInfo.Location = new Point(0, 66);
            lblRequestInfo.Name = "lblRequestInfo";
            lblRequestInfo.Text = "Loading approved requests...";

            // Cell 2: Assigned Personnel
            pnlPersonnelCell.Dock = DockStyle.Fill;
            pnlPersonnelCell.Padding = new Padding(14, 0, 0, 0);
            pnlPersonnelCell.Controls.Add(lblPersonnel);
            pnlPersonnelCell.Controls.Add(cmbPersonnel);
            pnlPersonnelCell.Controls.Add(lblPersonnelInfo);

            lblPersonnel.AutoSize = true;
            lblPersonnel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPersonnel.ForeColor = Color.DarkSlateGray;
            lblPersonnel.Location = new Point(14, 4);
            lblPersonnel.Text = "Assigned Personnel";

            cmbPersonnel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbPersonnel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonnel.Font = new Font("Segoe UI", 10F);
            cmbPersonnel.FormattingEnabled = true;
            cmbPersonnel.Location = new Point(14, 30);
            cmbPersonnel.Name = "cmbPersonnel";
            cmbPersonnel.Size = new Size(522, 31);
            cmbPersonnel.TabIndex = 4;

            lblPersonnelInfo.AutoSize = true;
            lblPersonnelInfo.Font = new Font("Segoe UI", 8.5F);
            lblPersonnelInfo.ForeColor = Color.Gray;
            lblPersonnelInfo.Location = new Point(14, 66);
            lblPersonnelInfo.Name = "lblPersonnelInfo";
            lblPersonnelInfo.Text = "Loading personnel...";

            // Cell 3: Scheduled Date & Time
            pnlDateCell.Dock = DockStyle.Fill;
            pnlDateCell.Padding = new Padding(0, 0, 14, 0);
            pnlDateCell.Controls.Add(lblScheduledDate);
            pnlDateCell.Controls.Add(dtpScheduledDate);

            lblScheduledDate.AutoSize = true;
            lblScheduledDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblScheduledDate.ForeColor = Color.DarkSlateGray;
            lblScheduledDate.Location = new Point(0, 4);
            lblScheduledDate.Text = "Scheduled Date && Time";

            dtpScheduledDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpScheduledDate.CustomFormat = "MMMM dd, yyyy   hh:mm tt";
            dtpScheduledDate.Font = new Font("Segoe UI", 10F);
            dtpScheduledDate.Format = DateTimePickerFormat.Custom;
            dtpScheduledDate.Location = new Point(0, 30);
            dtpScheduledDate.Name = "dtpScheduledDate";
            dtpScheduledDate.Size = new Size(522, 30);
            dtpScheduledDate.TabIndex = 7;
            dtpScheduledDate.MinDate = DateTime.Now;
            dtpScheduledDate.Value = DateTime.Now.AddHours(1);

            // Cell 4: Vehicle
            pnlVehicleCell.Dock = DockStyle.Fill;
            pnlVehicleCell.Padding = new Padding(14, 0, 0, 0);
            pnlVehicleCell.Controls.Add(lblVehicle);
            pnlVehicleCell.Controls.Add(txtVehicle);

            lblVehicle.AutoSize = true;
            lblVehicle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblVehicle.ForeColor = Color.DarkSlateGray;
            lblVehicle.Location = new Point(14, 4);
            lblVehicle.Text = "Vehicle";

            txtVehicle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtVehicle.BorderStyle = BorderStyle.FixedSingle;
            txtVehicle.Font = new Font("Segoe UI", 10F);
            txtVehicle.Location = new Point(14, 30);
            txtVehicle.Name = "txtVehicle";
            txtVehicle.PlaceholderText = "Enter vehicle details";
            txtVehicle.Size = new Size(522, 30);
            txtVehicle.TabIndex = 9;

            // Cell 5: Delivery Address (Full Width)
            pnlAddressCell.Dock = DockStyle.Fill;
            pnlAddressCell.Controls.Add(lblDeliveryAddress);
            pnlAddressCell.Controls.Add(txtDeliveryAddress);

            lblDeliveryAddress.AutoSize = true;
            lblDeliveryAddress.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDeliveryAddress.ForeColor = Color.DarkSlateGray;
            lblDeliveryAddress.Location = new Point(0, 4);
            lblDeliveryAddress.Text = "Delivery Address";

            txtDeliveryAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDeliveryAddress.BorderStyle = BorderStyle.FixedSingle;
            txtDeliveryAddress.Font = new Font("Segoe UI", 10F);
            txtDeliveryAddress.Location = new Point(0, 30);
            txtDeliveryAddress.Multiline = true;
            txtDeliveryAddress.Name = "txtDeliveryAddress";
            txtDeliveryAddress.ScrollBars = ScrollBars.Vertical;
            txtDeliveryAddress.Size = new Size(1072, 72);
            txtDeliveryAddress.TabIndex = 11;

            // Cell 6: Remarks (Full Width)
            pnlRemarksCell.Dock = DockStyle.Fill;
            pnlRemarksCell.Controls.Add(lblRemarks);
            pnlRemarksCell.Controls.Add(txtRemarks);

            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRemarks.ForeColor = Color.DarkSlateGray;
            lblRemarks.Location = new Point(0, 4);
            lblRemarks.Text = "Remarks";

            txtRemarks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRemarks.BorderStyle = BorderStyle.FixedSingle;
            txtRemarks.Font = new Font("Segoe UI", 10F);
            txtRemarks.Location = new Point(0, 30);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.ScrollBars = ScrollBars.Vertical;
            txtRemarks.Size = new Size(1072, 72);
            txtRemarks.TabIndex = 13;

            // 
            // pnlButtons - BOTTOM ACTION FOOTER
            // 
            pnlButtons.BackColor = Color.FromArgb(248, 250, 250);
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnSave);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 729);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(25, 16, 25, 16);
            pnlButtons.Size = new Size(1122, 75);
            pnlButtons.TabIndex = 2;

            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.Teal;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(907, 18);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(190, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "Schedule Delivery";
            btnSave.UseVisualStyleBackColor = false;

            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.Silver;
            btnCancel.FlatAppearance.BorderSize = 1;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 245, 245);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.ForeColor = Color.DarkSlateGray;
            btnCancel.Location = new Point(777, 18);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Clear";
            btnCancel.UseVisualStyleBackColor = false;

            // 
            // DeliveryScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1122, 804);
            Controls.Add(pnlContent);
            Controls.Add(pnlButtons);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(850, 650);
            Name = "DeliveryScheduleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schedule Delivery";

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            tlpFormGrid.ResumeLayout(false);
            pnlRequestCell.ResumeLayout(false);
            pnlRequestCell.PerformLayout();
            pnlPersonnelCell.ResumeLayout(false);
            pnlPersonnelCell.PerformLayout();
            pnlDateCell.ResumeLayout(false);
            pnlDateCell.PerformLayout();
            pnlVehicleCell.ResumeLayout(false);
            pnlVehicleCell.PerformLayout();
            pnlAddressCell.ResumeLayout(false);
            pnlAddressCell.PerformLayout();
            pnlRemarksCell.ResumeLayout(false);
            pnlRemarksCell.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}