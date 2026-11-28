using System.Data;
using Microsoft.Data.SqlClient;
using SandriasDeliciousConcept.Contracts;
using SandriasDeliciousConcept.Data;

namespace SandriasDeliciousConcept.Inventory;

public class InventoryService : IInventoryService
{
    private static SqlConnection Open()
    {
        var conn = new SqlConnection(DatabaseInitializer.AppConnection);
        conn.Open();
        return conn;
    }

    private static SqlCommand Proc(SqlConnection conn, string name, SqlTransaction? tx = null) =>
        new(name, conn, tx) { CommandType = CommandType.StoredProcedure };

    // The same item can appear on two lines of one requisition, so add the lines up first.
    private static IEnumerable<(int ItemId, decimal Quantity)> Totals(IEnumerable<RequisitionItemDto> items) =>
        items.GroupBy(i => i.ItemId)
             .OrderBy(g => g.Key)
             .Select(g => (g.Key, g.Sum(i => i.Quantity)));

    // ---------- IInventoryService (used by other modules) ----------

    public IReadOnlyList<StockCheckResult> CheckAvailability(IEnumerable<RequisitionItemDto> items)
    {
        var available = GetStock().Rows.Cast<DataRow>()
            .ToDictionary(r => (int)r["ItemId"], r => (decimal)r["Available"]);

        return Totals(items)
            .Select(t => new StockCheckResult(t.ItemId, t.Quantity, available.GetValueOrDefault(t.ItemId)))
            .ToList();
    }

    // All lines are reserved, or none of them.
    public void Reserve(int rfId, IEnumerable<RequisitionItemDto> items)
    {
        using var conn = Open();
        using var tx = conn.BeginTransaction();
        foreach (var (itemId, quantity) in Totals(items))
        {
            using var cmd = Proc(conn, "dbo.usp_Inventory_Reserve", tx);
            cmd.Parameters.AddWithValue("@RfId", rfId);
            cmd.Parameters.AddWithValue("@ItemId", itemId);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.ExecuteNonQuery();
        }
        tx.Commit();   // if anything above throws, disposing tx rolls back
    }

    public void Deduct(int rfId) => Deduct(rfId, "System");

    // ---------- Used by the Inventory screen and Program.cs ----------

    public void Deduct(int rfId, string performedBy) =>
        Run("dbo.usp_Inventory_Deduct", ("@RfId", rfId), ("@PerformedBy", performedBy));

    public bool IsReserved(int rfId)
    {
        using var conn = Open();
        using var cmd = Proc(conn, "dbo.usp_Inventory_IsReserved");
        cmd.Parameters.AddWithValue("@RfId", rfId);
        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
    }

    // Returns the shortages. An empty list means the stock is now reserved.
    public IReadOnlyList<StockCheckResult> TryReserve(int rfId, IReadOnlyList<RequisitionItemDto> items)
    {
        if (IsReserved(rfId)) return Array.Empty<StockCheckResult>();

        var shortages = CheckAvailability(items).Where(r => r.Shortage > 0).ToList();
        if (shortages.Count == 0) Reserve(rfId, items);
        return shortages;
    }

    public DataTable GetStock() => Query("dbo.usp_Inventory_GetStock");
    public DataTable GetMovements() => Query("dbo.usp_Inventory_GetMovements");

    public void Receive(int itemId, decimal quantity, string performedBy, string remarks) =>
        Run("dbo.usp_Inventory_Receive", ("@ItemId", itemId), ("@Quantity", quantity),
            ("@PerformedBy", performedBy), ("@Remarks", remarks));

    public void Adjust(int itemId, decimal newOnHand, string performedBy, string remarks) =>
        Run("dbo.usp_Inventory_Adjust", ("@ItemId", itemId), ("@NewOnHand", newOnHand),
            ("@PerformedBy", performedBy), ("@Remarks", remarks));

    public void SetReorderLevel(int itemId, decimal level) =>
        Run("dbo.usp_Inventory_SetReorderLevel", ("@ItemId", itemId), ("@ReorderLevel", level));

    private static DataTable Query(string proc)
    {
        using var conn = Open();
        using var cmd = Proc(conn, proc);
        using var reader = cmd.ExecuteReader();
        var table = new DataTable();
        table.Load(reader);
        return table;
    }

    private static void Run(string proc, params (string Name, object Value)[] args)
    {
        using var conn = Open();
        using var cmd = Proc(conn, proc);
        foreach (var (name, value) in args) cmd.Parameters.AddWithValue(name, value);
        cmd.ExecuteNonQuery();
    }
}
