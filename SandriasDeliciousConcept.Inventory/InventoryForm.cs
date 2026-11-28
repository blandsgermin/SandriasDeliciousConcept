using System.Data;
using SandriasDeliciousConcept.Contracts;

namespace SandriasDeliciousConcept.Inventory;

// The layout is built in code, so there is no Designer file for this form.
public class InventoryForm : Form
{
    private readonly InventoryService _inventory;
    private readonly IRequisitionService _requisitions;
    private readonly CurrentUser _user;

    private readonly DataGridView _stock = NewGrid();
    private readonly DataGridView _requests = NewGrid();
    private readonly DataGridView _history = NewGrid();
    private readonly TextBox _search = new() { Width = 160, PlaceholderText = "Search item" };
    private readonly CheckBox _lowOnly = new() { Text = "Low stock only", AutoSize = true };
    private readonly NumericUpDown _quantity = new() { DecimalPlaces = 2, Maximum = 100000, Width = 90 };
    private readonly TextBox _remarks = new() { Width = 200, PlaceholderText = "Remarks / reason" };

    public InventoryForm(InventoryService inventory, IRequisitionService requisitions, CurrentUser user)
    {
        _inventory = inventory; _requisitions = requisitions; _user = user;

        Text = $"Inventory - {user.FullName} ({user.Role})";
        ClientSize = new Size(1000, 600);
        StartPosition = FormStartPosition.CenterParent;

        var tabs = new TabControl { Dock = DockStyle.Fill };
        tabs.TabPages.Add(Page("Stock", _stock,
            _search, _lowOnly,
            new Label { Text = "Quantity:", AutoSize = true, Margin = new Padding(16, 8, 4, 0) }, _quantity, _remarks,
            NewButton("Receive", Receive),
            NewButton("Set counted stock", Adjust),
            NewButton("Set reorder level", SetReorderLevel)));
        tabs.TabPages.Add(Page("Requisitions", _requests,
            NewButton("Reserve stock", ReserveSelected),
            NewButton("Issue stock", IssueSelected),
            NewButton("Refresh", LoadAll)));
        tabs.TabPages.Add(Page("History", _history));
        Controls.Add(tabs);

        _search.TextChanged += (_, _) => ApplyFilter();
        _lowOnly.CheckedChanged += (_, _) => ApplyFilter();
        _stock.DataBindingComplete += (_, _) => HighlightLowStock();
        _requests.DataBindingComplete += (_, _) =>
        {
            if (_requests.Columns.Contains("RfId")) _requests.Columns["RfId"]!.Visible = false;
        };
        Load += (_, _) => Try(LoadAll);
    }

    // ---------- Layout helpers ----------

    private static DataGridView NewGrid() => new()
    {
        Dock = DockStyle.Fill,
        ReadOnly = true,
        AllowUserToAddRows = false,
        AllowUserToDeleteRows = false,
        MultiSelect = false,
        SelectionMode = DataGridViewSelectionMode.FullRowSelect,
        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    };

    private Button NewButton(string text, Action action)
    {
        var button = new Button { Text = text, AutoSize = true };
        button.Click += (_, _) => Try(action);
        return button;
    }

    private static TabPage Page(string title, DataGridView grid, params Control[] toolbar)
    {
        var page = new TabPage(title);
        page.Controls.Add(grid);   // add the Fill control first so the toolbar docks above it
        if (toolbar.Length > 0)
        {
            var panel = new FlowLayoutPanel { Dock = DockStyle.Top, AutoSize = true, Padding = new Padding(8) };
            panel.Controls.AddRange(toolbar);
            page.Controls.Add(panel);
        }
        return page;
    }

    // ---------- Data ----------

    private void LoadAll()
    {
        int? selected = _stock.CurrentRow?.Cells["ItemId"].Value as int?;

        _stock.DataSource = _inventory.GetStock();
        _stock.Columns["ItemId"]!.Visible = false;
        ApplyFilter();
        foreach (DataGridViewRow row in _stock.Rows)
            if (row.Cells["ItemId"].Value as int? == selected) { _stock.CurrentCell = row.Cells["ItemName"]; break; }

        _requests.DataSource = _requisitions.GetAll()
            .Where(r => r.Status is RequisitionStatus.Approved or RequisitionStatus.PendingFulfillment)
            .Select(r => new
            {
                r.RfId,
                RF = r.RfNumber,
                Customer = r.CustomerName,
                Required = r.RequiredDate?.ToString("yyyy-MM-dd"),
                Status = r.Status.ToString(),
                Stock = _inventory.IsReserved(r.RfId) ? "Reserved" : "Not reserved"
            }).ToList();

        _history.DataSource = _inventory.GetMovements();
    }

    private void ApplyFilter()
    {
        if (_stock.DataSource is not DataTable table) return;
        // Escape the characters that have a special meaning in a RowFilter LIKE pattern.
        var text = string.Concat(_search.Text.Select(c => c switch
        {
            '\'' => "''",
            '[' or ']' or '*' or '%' => $"[{c}]",
            _ => c.ToString()
        }));
        var filter = $"ItemName LIKE '%{text}%'";
        if (_lowOnly.Checked) filter += " AND ReorderLevel > 0 AND Available <= ReorderLevel";
        table.DefaultView.RowFilter = filter;
    }

    private void HighlightLowStock()
    {
        foreach (DataGridViewRow row in _stock.Rows)
        {
            bool low = row.Cells["ReorderLevel"].Value is decimal level && level > 0
                       && row.Cells["Available"].Value is decimal available && available <= level;
            row.DefaultCellStyle.BackColor = low ? Color.MistyRose : Color.Empty;
        }
    }

    // ---------- Stock actions ----------

    private (int Id, string Name)? SelectedItem()
    {
        if (_stock.CurrentRow?.Cells["ItemId"].Value is int id)
            return (id, (string)_stock.CurrentRow.Cells["ItemName"].Value);
        Warn("Select an item first.");
        return null;
    }

    private void Receive()
    {
        if (SelectedItem() is not { } item) return;
        if (_quantity.Value <= 0) { Warn("Enter the quantity received."); return; }
        if (!Confirm($"Receive {_quantity.Value} of {item.Name}?")) return;
        _inventory.Receive(item.Id, _quantity.Value, _user.FullName, _remarks.Text.Trim());
        Done();
    }

    private void Adjust()
    {
        if (SelectedItem() is not { } item) return;
        if (_remarks.Text.Trim().Length == 0) { Warn("Enter the reason for the adjustment."); return; }
        if (!Confirm($"Set the stock of {item.Name} to {_quantity.Value}?")) return;
        _inventory.Adjust(item.Id, _quantity.Value, _user.FullName, _remarks.Text.Trim());
        Done();
    }

    private void SetReorderLevel()
    {
        if (SelectedItem() is not { } item) return;
        if (!Confirm($"Set the reorder level of {item.Name} to {_quantity.Value}?")) return;
        _inventory.SetReorderLevel(item.Id, _quantity.Value);
        Done();
    }

    private void Done()
    {
        _quantity.Value = 0;
        _remarks.Clear();
        LoadAll();
    }

    // ---------- Requisition actions ----------

    private int? SelectedRfId()
    {
        if (_requests.CurrentRow?.Cells["RfId"].Value is int id) return id;
        Warn("Select a requisition first.");
        return null;
    }

    private void ReserveSelected()
    {
        if (SelectedRfId() is not int id) return;
        var rf = _requisitions.GetById(id);
        if (rf is null) return;

        var shortages = _inventory.TryReserve(id, rf.Items);
        if (shortages.Count > 0)
        {
            _requisitions.SetStatus(id, RequisitionStatus.PendingFulfillment);
            var names = rf.Items.DistinctBy(i => i.ItemId).ToDictionary(i => i.ItemId);
            Warn("Not enough stock:\n" + string.Join("\n", shortages.Select(s =>
                $"- {names[s.ItemId].ItemName}: short by {s.Shortage} {names[s.ItemId].Unit}")));
        }
        else
        {
            _requisitions.SetStatus(id, RequisitionStatus.Approved);
        }
        LoadAll();
    }

    private void IssueSelected()
    {
        if (SelectedRfId() is not int id) return;
        if (!Confirm("Issue the reserved stock for this requisition?")) return;
        _inventory.Deduct(id, _user.FullName);
        _requisitions.SetStatus(id, RequisitionStatus.Fulfilled);
        LoadAll();
    }

    // ---------- Messages ----------

    private void Try(Action action)
    {
        try { action(); }
        catch (Exception ex) { Warn(ex.Message); }
    }

    private static bool Confirm(string message) =>
        MessageBox.Show(message, "Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

    private static void Warn(string message) =>
        MessageBox.Show(message, "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
