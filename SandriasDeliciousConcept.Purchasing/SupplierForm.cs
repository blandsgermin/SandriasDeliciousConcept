using SandriasDeliciousConcept.Data;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Purchasing
{
    public partial class SupplierForm : Form
    {
        private readonly SupplierRepository repository = new SupplierRepository();
        private int selectedSupplierId = 0;
        private bool isEditMode = false;
        private DataTable supplierData = new DataTable();

        public SupplierForm()
        {
            InitializeComponent();

            StyleSupplierButtons();
            SetupSupplierGrid();
            SetupSearchFilter();
            SetFieldsReadOnly(true);
            LoadSuppliers();
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
                    FontStyle.Bold
                );

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

            cmbSearchFilter.DropDownStyle = ComboBoxStyle.DropDownList;
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
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.ReadOnly = true;
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
                    supplier["SupplierID"],
                    supplier["SupplierName"],
                    supplier["ContactPerson"],
                    supplier["ContactNumber"],
                    supplier["Email"],
                    supplier["Address"],
                    supplier["Status"]
                );
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
                DataTable supplier = repository.GetById(selectedSupplierId);

                if (supplier.Rows.Count == 0)
                {
                    MessageBox.Show("Supplier not found.");
                    return;
                }

                DataRow row = supplier.Rows[0];

                txtSupplierName.Text = row["SupplierName"].ToString();
                txtContactPerson.Text = row["ContactPerson"].ToString();
                txtContactNumber.Text = row["ContactNumber"].ToString();
                txtEmail.Text = row["Email"].ToString();
                txtAddress.Text = row["Address"].ToString();

                SetFieldsReadOnly(true);

                isEditMode = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to view supplier:\n" + ex.Message);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!GetSelectedSupplier())
                return;

            try
            {
                DataTable supplier = repository.GetById(selectedSupplierId);

                if (supplier.Rows.Count == 0)
                {
                    MessageBox.Show("Supplier not found.");
                    return;
                }

                DataRow row = supplier.Rows[0];

                txtSupplierName.Text = row["SupplierName"].ToString();
                txtContactPerson.Text = row["ContactPerson"].ToString();
                txtContactNumber.Text = row["ContactNumber"].ToString();
                txtEmail.Text = row["Email"].ToString();
                txtAddress.Text = row["Address"].ToString();

                SetFieldsReadOnly(false);

                isEditMode = true;

                txtSupplierName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to edit supplier:\n" + ex.Message);
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
                        txtAddress.Text.Trim()
                    );

                    MessageBox.Show("Supplier updated successfully!");
                }
                else
                {
                    int newSupplierId = repository.Add(
                        txtSupplierName.Text.Trim(),
                        txtContactPerson.Text.Trim(),
                        txtContactNumber.Text.Trim(),
                        txtEmail.Text.Trim(),
                        txtAddress.Text.Trim()
                    );

                    MessageBox.Show(
                        "Supplier added successfully!\nSupplier ID: " + newSupplierId);
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
                DataTable supplier = repository.GetById(selectedSupplierId);

                if (supplier.Rows.Count == 0)
                {
                    MessageBox.Show("Supplier not found.");
                    return;
                }

                string currentStatus =
                    supplier.Rows[0]["Status"].ToString() ?? "";

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

                repository.SetStatus(selectedSupplierId, newStatus);

                MessageBox.Show("Supplier status updated successfully!");

                ClearFields();
                SetFieldsReadOnly(true);
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to change supplier status:\n" + ex.Message);
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

            string columnName = filter switch
            {
                "Supplier Name" => "SupplierName",
                "Contact Person" => "ContactPerson",
                "Contact Number" => "ContactNumber",
                "Email" => "Email",
                "Status" => "Status",
                _ => ""
            };

            DataTable filteredData = supplierData.Clone();

            foreach (DataRow row in supplierData.Rows)
            {
                bool matches = false;

                if (string.IsNullOrEmpty(columnName))
                {
                    string[] fields =
                    {
                        "SupplierName",
                        "ContactPerson",
                        "ContactNumber",
                        "Email",
                        "Status"
                    };

                    foreach (string field in fields)
                    {
                        if (row[field].ToString()!
                            .Contains(keyword, StringComparison.OrdinalIgnoreCase))
                        {
                            matches = true;
                            break;
                        }
                    }
                }
                else
                {
                    matches = row[columnName].ToString()!
                        .Contains(keyword, StringComparison.OrdinalIgnoreCase);
                }

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
        private void cmbSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
        }

        private void btnPurchaseRequest_Click(object sender, EventArgs e)
        {
        }

        private void btnQuotations_Click(object sender, EventArgs e)
        {
        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
        }

        private void btnPurchaseHistory_Click(object sender, EventArgs e)
        {
        }
    }
}
