using System;
using System.Data;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Delivery
{
    public partial class DeliveryScheduleForm : Form
    {
        private readonly DeliveryService _deliveryService;
        private DataTable? _approvedRequests;
        private DataTable? _personnel;

        public DeliveryScheduleForm()
        {
            InitializeComponent();

            _deliveryService = new DeliveryService();

            LoadDropdownData();

            cmbApprovedRequest.SelectedIndexChanged += cmbApprovedRequest_SelectedIndexChanged;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void LoadDropdownData()
        {
            try
            {
                _approvedRequests = _deliveryService.GetApprovedRequests();
                _personnel = _deliveryService.GetDeliveryPersonnel();

                cmbApprovedRequest.DataSource = _approvedRequests;
                cmbApprovedRequest.DisplayMember = "RfNumber";
                cmbApprovedRequest.ValueMember = "RfId";
                cmbApprovedRequest.SelectedIndex = -1;

                cmbPersonnel.DataSource = _personnel;
                cmbPersonnel.DisplayMember = "FullName";
                cmbPersonnel.ValueMember = "UserId";
                cmbPersonnel.SelectedIndex = -1;

                lblRequestInfo.Text =
                    _approvedRequests.Rows.Count == 0
                        ? "No approved requests are currently available."
                        : $"{_approvedRequests.Rows.Count} approved request(s) available.";

                lblPersonnelInfo.Text =
                    _personnel.Rows.Count == 0
                        ? "No delivery personnel are available."
                        : $"{_personnel.Rows.Count} personnel available.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load scheduling information.\n\n" + ex.Message,
                    "Delivery Schedule",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                btnSave.Enabled = false;
            }
        }

        private void ClearForm()
        {
            cmbApprovedRequest.SelectedIndex = -1;
            cmbPersonnel.SelectedIndex = -1;
            txtVehicle.Clear();
            txtDeliveryAddress.Clear();
            txtRemarks.Clear();
            dtpScheduledDate.MinDate = DateTime.Now;
            dtpScheduledDate.Value = DateTime.Now.AddHours(1);
        }

        private void cmbApprovedRequest_SelectedIndexChanged(
            object? sender,
            EventArgs e)
        {
            if (cmbApprovedRequest.SelectedItem is not DataRowView selectedRequest)
                return;

            string venue =
                Convert.ToString(selectedRequest["Venue"]) ?? string.Empty;

            txtDeliveryAddress.Text = venue;
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (cmbApprovedRequest.SelectedValue == null ||
                cmbApprovedRequest.SelectedValue == DBNull.Value)
            {
                MessageBox.Show(
                    "Please select an approved request.",
                    "Delivery Schedule",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cmbPersonnel.SelectedValue == null ||
                cmbPersonnel.SelectedValue == DBNull.Value)
            {
                MessageBox.Show(
                    "Please assign delivery personnel.",
                    "Delivery Schedule",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDeliveryAddress.Text))
            {
                MessageBox.Show(
                    "Please enter the delivery address.",
                    "Delivery Schedule",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtDeliveryAddress.Focus();
                return;
            }

            if (dtpScheduledDate.Value < DateTime.Now)
            {
                MessageBox.Show(
                    "The scheduled delivery date and time cannot be in the past.",
                    "Delivery Schedule",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int rfId = Convert.ToInt32(cmbApprovedRequest.SelectedValue);
                int assignedUserId = Convert.ToInt32(cmbPersonnel.SelectedValue);

                string deliveryNumber =
                    "DLV-" + Guid.NewGuid().ToString("N")[..8].ToUpperInvariant();

                _deliveryService.ScheduleDelivery(
                    deliveryNumber,
                    rfId,
                    assignedUserId,
                    string.IsNullOrWhiteSpace(txtVehicle.Text)
                        ? null
                        : txtVehicle.Text.Trim(),
                    dtpScheduledDate.Value,
                    txtDeliveryAddress.Text.Trim(),
                    string.IsNullOrWhiteSpace(txtRemarks.Text)
                        ? null
                        : txtRemarks.Text.Trim(),
                    null);

                MessageBox.Show(
                    "Delivery scheduled successfully.\n\nDelivery Number: " + deliveryNumber,
                    "Delivery Schedule",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                if (TopLevel)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    ClearForm();
                    LoadDropdownData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to schedule delivery.\n\n" + ex.Message,
                    "Delivery Schedule",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            if (TopLevel)
            {
                Close();
            }
            else
            {
                ClearForm();
            }
        }
    }
}