using SandriasDeliciousConcept.Data;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Purchasing
{
    public partial class SupplierForm : Form
    {
        private readonly SupplierRepository repository =
            new SupplierRepository();

        private int selectedSupplierId = 0;
        private bool isEditMode = false;
        private bool isDashboardMode = false;

        private DataTable supplierData = new DataTable();

        public SupplierForm()
        {
            InitializeComponent();

            StyleSupplierButtons();
            SetupSupplierGrid();
            SetupSearchFilter();
            SetFieldsReadOnly(true);

            if (System.ComponentModel.LicenseManager.UsageMode
                != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                LoadSuppliers();
            }
        }

        public void PrepareForDashboard()
        {
            if (isDashboardMode)
                return;

            isDashboardMode = true;

            panel1.Visible = false;
            panel2.Visible = true;

            foreach (Control control in Controls)
            {
                if (control == panel1)
                    continue;

                control.Left -= 230;
            }

            BackColor = Color.WhiteSmoke;

            PerformLayout();
        }

        private void StyleSupplierButtons()
        {
            Button[] buttons =
            {
                btnAdd,
                btnView,
                btnEdit,
                btnSave,
                btnStatus,
                btnSearch,
                btnRefresh
            };

            foreach (Button btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                btn.Font = new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

                btn.ForeColor = Color.White;
                btn.Cursor = Cursors.Hand;
                btn.Height = 35;
                btn.Width = 100;
                btn.UseVisualStyleBackColor = false;
            }

            btnAdd.BackColor = Color.SeaGreen;
            btnView.BackColor = Color.SteelBlue;
            btnEdit.BackColor = Color.DarkOrange;
            btnSave.BackColor = Color.RoyalBlue;
            btnStatus.BackColor = Color.Firebrick;
            btnSearch.BackColor = Color.DarkSlateGray;
            btnRefresh.BackColor = Color.DimGray;

            foreach (Button btn in buttons)
            {
                btn.FlatAppearance.MouseOverBackColor =
                    ControlPaint.Dark(btn.BackColor);

                btn.FlatAppearance.MouseDownBackColor =
                    ControlPaint.DarkDark(btn.BackColor);
            }
        }

        private void SetupSearchFilter()
        {
            cmbSearchFilter.Items.Clear();

            cmbSearchFilter.Items.AddRange(new string[]
            {
                "All Fields",
                "Supplier Name",
                "Contact Person",
                "Contact Number",
                "Email",
                "Status"
            });

            cmbSearchFilter.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbSearchFilter.SelectedIndex = 0;
        }

        private void SetupSupplierGrid()
        {
            dgvSuppliers.Columns.Clear();

            dgvSuppliers.Columns.Add("SupplierID", "Supplier ID");
            dgvSuppliers.Columns.Add("SupplierName", "Supplier Name");
            dgvSuppliers.Columns.Add("ContactPerson", "Contact Person");
            dgvSuppliers.Columns.Add("ContactNumber", "Contact Number");
            dgvSuppliers.Columns.Add("Email", "Email");
            dgvSuppliers.Columns.Add("Address", "Address");
            dgvSuppliers.Columns.Add("Status", "Status");

            foreach (DataGridViewColumn column in dgvSuppliers.Columns)
            {
                column.ReadOnly = true;
                column.AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvSuppliers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.ReadOnly = true;
        }

        private static string GetColumnValue(DataRow row, string columnName)
        {
            return row.Table.Columns.Contains(columnName)
                ? Convert.ToString(row[columnName]) ?? string.Empty
                : string.Empty;
        }

        private static string GetSupplierStatus(DataRow row)
        {
            if (row.Table.Columns.Contains("Status"))
                return Convert.ToString(row["Status"]) ?? "Active";

            if (row.Table.Columns.Contains("SupplierStatus"))
                return Convert.ToString(row["SupplierStatus"]) ?? "Active";

            if (row.Table.Columns.Contains("IsActive"))
            {
                object val = row["IsActive"];
                if (val != null && val != DBNull.Value && Convert.ToBoolean(val))
                    return "Active";

                return "Inactive";
            }

            return "Active";
        }

        private void LoadSuppliers()
        {
            try
            {
                supplierData = repository.GetAll();
                DisplaySuppliers(supplierData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load suppliers:\n" + ex.Message,
                    "Supplier Management",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DisplaySuppliers(DataTable suppliers)
        {
            dgvSuppliers.Rows.Clear();

            foreach (DataRow supplier in suppliers.Rows)
            {
                dgvSuppliers.Rows.Add(
                    GetColumnValue(supplier, "SupplierID"),
                    GetColumnValue(supplier, "SupplierName"),
                    GetColumnValue(supplier, "ContactPerson"),
                    GetColumnValue(supplier, "ContactNumber"),
                    GetColumnValue(supplier, "Email"),
                    GetColumnValue(supplier, "Address"),
                    GetSupplierStatus(supplier));
            }
        }

        private void SetFieldsReadOnly(bool readOnly)
        {
            txtSupplierName.ReadOnly = readOnly;
            txtContactPerson.ReadOnly = readOnly;
            txtContactNumber.ReadOnly = readOnly;
            txtEmail.ReadOnly = readOnly;
            txtAddress.ReadOnly = readOnly;
        }

        private void ClearFields()
        {
            txtSupplierName.Clear();
            txtContactPerson.Clear();
            txtContactNumber.Clear();
            txtEmail.Clear();
            txtAddress.Clear();

            selectedSupplierId = 0;
            isEditMode = false;
        }

        private bool GetSelectedSupplier()
        {
            if (dgvSuppliers.CurrentRow == null ||
                dgvSuppliers.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Please select a supplier first.",
                    "Supplier Management",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            selectedSupplierId = Convert.ToInt32(
                dgvSuppliers.CurrentRow.Cells["SupplierID"].Value);

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();

            SetFieldsReadOnly(false);

            isEditMode = false;

            txtSupplierName.Focus();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (!GetSelectedSupplier())
                return;

            try
            {
                DataTable supplier =
                    repository.GetById(selectedSupplierId);

                if (supplier.Rows.Count == 0)
                {
                    MessageBox.Show("Supplier not found.");
                    return;
                }

                DataRow row = supplier.Rows[0];

                txtSupplierName.Text = GetColumnValue(row, "SupplierName");
                txtContactPerson.Text = GetColumnValue(row, "ContactPerson");
                txtContactNumber.Text = GetColumnValue(row, "ContactNumber");
                txtEmail.Text = GetColumnValue(row, "Email");
                txtAddress.Text = GetColumnValue(row, "Address");

                SetFieldsReadOnly(true);

                isEditMode = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to view supplier:\n" + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!GetSelectedSupplier())
                return;

            try
            {
                DataTable supplier =
                    repository.GetById(selectedSupplierId);

                if (supplier.Rows.Count == 0)
                {
                    MessageBox.Show("Supplier not found.");
                    return;
                }

                DataRow row = supplier.Rows[0];

                txtSupplierName.Text = GetColumnValue(row, "SupplierName");
                txtContactPerson.Text = GetColumnValue(row, "ContactPerson");
                txtContactNumber.Text = GetColumnValue(row, "ContactNumber");
                txtEmail.Text = GetColumnValue(row, "Email");
                txtAddress.Text = GetColumnValue(row, "Address");

                SetFieldsReadOnly(false);

                isEditMode = true;

                txtSupplierName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to edit supplier:\n" + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show(
                    "Supplier Name is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSupplierName.Focus();
                return;
            }

            try
            {
                if (isEditMode && selectedSupplierId > 0)
                {
                    repository.Update(
                        selectedSupplierId,
                        txtSupplierName.Text.Trim(),
                        txtContactPerson.Text.Trim(),
                        txtContactNumber.Text.Trim(),
                        txtEmail.Text.Trim(),
                        txtAddress.Text.Trim());

                    MessageBox.Show(
                        "Supplier updated successfully!");
                }
                else
                {
                    int newSupplierId = repository.Add(
                        txtSupplierName.Text.Trim(),
                        txtContactPerson.Text.Trim(),
                        txtContactNumber.Text.Trim(),
                        txtEmail.Text.Trim(),
                        txtAddress.Text.Trim());

                    MessageBox.Show(
                        "Supplier added successfully!\nSupplier ID: " +
                        newSupplierId);
                }

                ClearFields();
                SetFieldsReadOnly(true);
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to save supplier:\n" + ex.Message,
                    "Supplier Management",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (!GetSelectedSupplier())
                return;

            try
            {
                DataTable supplier =
                    repository.GetById(selectedSupplierId);

                if (supplier.Rows.Count == 0)
                {
                    MessageBox.Show("Supplier not found.");
                    return;
                }

                string currentStatus = GetSupplierStatus(supplier.Rows[0]);

                string newStatus = currentStatus.Equals(
                    "Active",
                    StringComparison.OrdinalIgnoreCase)
                    ? "Inactive"
                    : "Active";

                DialogResult result = MessageBox.Show(
                    $"Change this supplier's status to {newStatus}?",
                    "Confirm Status Change",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                repository.SetStatus(
                    selectedSupplierId,
                    newStatus);

                MessageBox.Show(
                    "Supplier status updated successfully!");

                ClearFields();
                SetFieldsReadOnly(true);
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to change supplier status:\n" +
                    ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                DisplaySuppliers(supplierData);
                return;
            }

            string filter = cmbSearchFilter.Text;

            DataTable filteredData = supplierData.Clone();

            foreach (DataRow row in supplierData.Rows)
            {
                bool matches = filter switch
                {
                    "Supplier Name" => GetColumnValue(row, "SupplierName")
                        .Contains(keyword, StringComparison.OrdinalIgnoreCase),
                    "Contact Person" => GetColumnValue(row, "ContactPerson")
                        .Contains(keyword, StringComparison.OrdinalIgnoreCase),
                    "Contact Number" => GetColumnValue(row, "ContactNumber")
                        .Contains(keyword, StringComparison.OrdinalIgnoreCase),
                    "Email" => GetColumnValue(row, "Email")
                        .Contains(keyword, StringComparison.OrdinalIgnoreCase),
                    "Status" => GetSupplierStatus(row)
                        .Contains(keyword, StringComparison.OrdinalIgnoreCase),
                    _ => GetColumnValue(row, "SupplierName").Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                         GetColumnValue(row, "ContactPerson").Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                         GetColumnValue(row, "ContactNumber").Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                         GetColumnValue(row, "Email").Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                         GetSupplierStatus(row).Contains(keyword, StringComparison.OrdinalIgnoreCase)
                };

                if (matches)
                    filteredData.ImportRow(row);
            }

            DisplaySuppliers(filteredData);

            if (filteredData.Rows.Count == 0)
            {
                MessageBox.Show("No matching suppliers found.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            ClearFields();
            SetFieldsReadOnly(true);

            LoadSuppliers();

            MessageBox.Show(
                "Supplier list refreshed successfully.",
                "Supplier Management",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void cmbSearchFilter_SelectedIndexChanged(object sender, EventArgs e) { }
        private void btnAdd_Click_1(object sender, EventArgs e) { btnAdd_Click(sender, e); }
        private void txtSearch_TextChanged(object sender, EventArgs e) { }
        private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtSupplierName_TextChanged(object sender, EventArgs e) { }
        private void btnSuppliers_Click(object sender, EventArgs e) { }
        private void btnDashboard_Click(object sender, EventArgs e) { }
        private void btnPurchaseRequest_Click(object sender, EventArgs e) { }
        private void btnQuotations_Click(object sender, EventArgs e) { }
        private void btnPurchaseOrder_Click(object sender, EventArgs e) { }
        private void btnPurchaseHistory_Click(object sender, EventArgs e) { }
    }
}