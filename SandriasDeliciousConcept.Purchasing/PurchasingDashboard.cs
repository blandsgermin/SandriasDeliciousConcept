using System;
using System.Drawing;
using System.Windows.Forms;

namespace SandriasDeliciousConcept.Purchasing
{
    public partial class PurchasingDashboard : Form
    {
        private Panel? contentHost;
        private Form? activeChildForm;

        private const int SidebarWidth = 230;
        private const int HeaderHeight = 75;

        private readonly Color NormalNavigationColor = Color.DarkSlateGray;
        private readonly Color SelectedNavigationColor = Color.Teal;

        public PurchasingDashboard()
        {
            InitializeComponent();

            InitializeDashboardLayout();
            InitializeContentHost();

            Load += PurchasingDashboard_Load;
            Resize += PurchasingDashboard_Resize;
        }

        private void InitializeDashboardLayout()
        {
            panel1.Dock = DockStyle.None;
            panel2.Dock = DockStyle.None;
            flowLayoutPanel1.Dock = DockStyle.None;

            LayoutDashboardAreas();
        }

        private void LayoutDashboardAreas()
        {
            int width = ClientSize.Width;
            int height = ClientSize.Height;

            panel1.SetBounds(0, 0, SidebarWidth, height);

            panel2.SetBounds(
                SidebarWidth,
                0,
                Math.Max(0, width - SidebarWidth),
                HeaderHeight);

            flowLayoutPanel1.SetBounds(
                SidebarWidth,
                HeaderHeight,
                Math.Max(0, width - SidebarWidth),
                Math.Max(0, height - HeaderHeight));

            if (contentHost != null)
            {
                contentHost.SetBounds(
                    SidebarWidth,
                    HeaderHeight,
                    Math.Max(0, width - SidebarWidth),
                    Math.Max(0, height - HeaderHeight));
            }

            panel1.BringToFront();
            panel2.BringToFront();
        }

        private void PurchasingDashboard_Resize(
            object? sender,
            EventArgs e)
        {
            LayoutDashboardAreas();
        }

        private void InitializeContentHost()
        {
            contentHost = new Panel
            {
                Name = "contentHost",
                BackColor = Color.WhiteSmoke,
                Visible = false
            };

            Controls.Add(contentHost);

            LayoutDashboardAreas();
        }

        private void PurchasingDashboard_Load(
            object? sender,
            EventArgs e)
        {
            dgvInventoryOverview.AutoGenerateColumns = true;
            dgvRecentActivities.AutoGenerateColumns = true;
            dgvRequisitionMonitoring.AutoGenerateColumns = true;

            ShowDashboard();
        }

        private void SetActiveNavigationButton(Button selectedButton)
        {
            Button[] navigationButtons =
            {
                btnDashboard,
                btnSuppliers,
                btnPurchaseRequests,
                btnQuotations,
                btnPurchaseOrders,
                btnPurchaseHistory
            };

            foreach (Button button in navigationButtons)
            {
                button.BackColor = NormalNavigationColor;
                button.ForeColor = Color.White;
            }

            selectedButton.BackColor = SelectedNavigationColor;
            selectedButton.ForeColor = Color.White;

            selectedButton.Invalidate();
        }

        private void OpenChildForm(Form childForm)
        {
            if (contentHost == null)
            {
                childForm.Dispose();
                return;
            }

            CloseActiveChildForm();

            flowLayoutPanel1.Visible = false;

            contentHost.Controls.Clear();
            contentHost.Visible = true;

            LayoutDashboardAreas();
            contentHost.BringToFront();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            contentHost.Controls.Add(childForm);
            activeChildForm = childForm;

            childForm.Show();
            childForm.BringToFront();

            panel2.BringToFront();
            panel1.BringToFront();
        }

        private void CloseActiveChildForm()
        {
            if (activeChildForm != null)
            {
                Form oldForm = activeChildForm;
                activeChildForm = null;

                oldForm.Close();
                oldForm.Dispose();
            }

            contentHost?.Controls.Clear();
        }

        private void ShowDashboard()
        {
            CloseActiveChildForm();

            if (contentHost != null)
                contentHost.Visible = false;

            flowLayoutPanel1.Visible = true;

            LayoutDashboardAreas();

            flowLayoutPanel1.BringToFront();
            panel2.BringToFront();
            panel1.BringToFront();

            SetActiveNavigationButton(btnDashboard);
        }

        private void btnDashboard_Click(
            object? sender,
            EventArgs e)
        {
            ShowDashboard();
        }

        private void btnSuppliers_Click(
            object? sender,
            EventArgs e)
        {
            try
            {
                SupplierForm form = new SupplierForm();
                form.PrepareForDashboard();

                OpenChildForm(form);
                SetActiveNavigationButton(btnSuppliers);
            }
            catch (Exception ex)
            {
                ShowNavigationError("Suppliers", ex);
            }
        }

        private void btnPurchaseRequests_Click(
            object? sender,
            EventArgs e)
        {
            try
            {
                PurchaseRequest form = new PurchaseRequest();
                form.PrepareForDashboard();

                OpenChildForm(form);
                SetActiveNavigationButton(btnPurchaseRequests);
            }
            catch (Exception ex)
            {
                ShowNavigationError("Purchase Requests", ex);
            }
        }

        private void btnQuotations_Click(
            object? sender,
            EventArgs e)
        {
            try
            {
                QuotationsForm form = new QuotationsForm();
                form.PrepareForDashboard();

                OpenChildForm(form);
                SetActiveNavigationButton(btnQuotations);
            }
            catch (Exception ex)
            {
                ShowNavigationError("Quotations", ex);
            }
        }

        private void btnPurchaseOrders_Click(
            object? sender,
            EventArgs e)
        {
            try
            {
                PurchaseOrderForm form = new PurchaseOrderForm();
                form.PrepareForDashboard();

                OpenChildForm(form);
                SetActiveNavigationButton(btnPurchaseOrders);
            }
            catch (Exception ex)
            {
                ShowNavigationError("Purchase Orders", ex);
            }
        }

        private void btnPurchaseHistory_Click(
            object? sender,
            EventArgs e)
        {
            try
            {
                PurchaseHistoryForm form = new PurchaseHistoryForm();
                form.PrepareForDashboard();

                OpenChildForm(form);
                SetActiveNavigationButton(btnPurchaseHistory);
            }
            catch (Exception ex)
            {
                ShowNavigationError("Purchase History", ex);
            }
        }

        private void ShowNavigationError(
            string screen,
            Exception ex)
        {
            MessageBox.Show(
                "Unable to open " + screen + ".\n\n" + ex.Message,
                "Purchasing Navigation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            CloseActiveChildForm();
            base.OnFormClosed(e);
        }
    }
}
