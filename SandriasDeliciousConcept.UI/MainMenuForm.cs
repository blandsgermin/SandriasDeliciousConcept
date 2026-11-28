
using System;
using System.Windows.Forms;
using SandriasDeliciousConcept.Contracts;
using SandriasDeliciousConcept.Requisition;
using SandriasDeliciousConcept.Delivery;
using SandriasDeliciousConcept.Purchasing;

namespace SandriasDeliciousConcept.UI;

public partial class MainMenuForm : Form
{
    private readonly CurrentUser? _user;
    private readonly AppServices _services;

    public bool LoggedOut { get; private set; }

    // ==========================================
    // CONSTRUCTOR: OPEN WITHOUT LOGIN
    // ==========================================

    public MainMenuForm(AppServices services)
    {
        InitializeComponent();

        _user = null;
        _services = services;

        lblWelcome.Text = "Welcome to Sandria's Commissary";
        lblRole.Text = "Role: Dashboard Access";

        btnRequisition.Enabled = true;
        btnInventory.Enabled = true;
        btnPurchasing.Enabled = true;
        btnDelivery.Enabled = true;
    }

    // ==========================================
    // CONSTRUCTOR: OPEN WITH LOGIN
    // ==========================================

    public MainMenuForm(CurrentUser user, AppServices services)
    {
        InitializeComponent();

        _user = user;
        _services = services;

        lblWelcome.Text = $"Welcome, {user.FullName}";
        lblRole.Text = $"Role: {user.Role}";

        bool owner = user.Role == "Owner";

        btnRequisition.Enabled = owner || user.Role == "Chef";
        btnInventory.Enabled = owner || user.Role == "InventoryClerk";
        btnPurchasing.Enabled = owner || user.Role == "Purchaser";
        btnDelivery.Enabled =
            owner || user.Role is "InventoryClerk" or "Purchaser";
    }

    // ==========================================
    // REQUISITION
    // ==========================================

    private void btnRequisition_Click(object? sender, EventArgs e)
    {
        if (_user == null)
        {
            MessageBox.Show(
                "Requisition requires a signed-in user.",
                "Login Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }

        using var form = new RequisitionListForm(
            _services.Requisition,
            _services.Catalog,
            _services.Dishes,
            _user);

        form.ShowDialog(this);
    }

    // ==========================================
    // INVENTORY
    // ==========================================

    private void btnInventory_Click(object? sender, EventArgs e)
    {
        MessageBox.Show(
            "The Inventory module is not connected yet.",
            "Inventory",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    // ==========================================
    // PURCHASING
    // ==========================================

    private void btnPurchasing_Click(object? sender, EventArgs e)
    {
        try
        {
            using var form = new PurchasingDashboard();
            form.ShowDialog(this);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Unable to open the Purchasing module.\n\n" + ex.Message,
                "Purchasing Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    // ==========================================
    // DELIVERY
    // ==========================================

    private void btnDelivery_Click(object? sender, EventArgs e)
    {
        try
        {
            using var form = new DeliveryDashboardForm();
            form.ShowDialog(this);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Unable to open the Delivery module.\n\n" + ex.Message,
                "Delivery Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    // ==========================================
    // LOGOUT
    // ==========================================

    private void btnLogout_Click(object? sender, EventArgs e)
    {
        LoggedOut = true;
        Close();
    }
}
