
using System;
using System.Windows.Forms;
using SandriasDeliciousConcept.Contracts;
using SandriasDeliciousConcept.Data;
using SandriasDeliciousConcept.Requisition;

namespace SandriasDeliciousConcept.UI;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        try
        {
            DatabaseInitializer.EnsureCreated();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Could not set up the database:\n\n" + ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return;
        }

        var bus = new EventBus();

        var services = new AppServices
        {
            Bus = bus,
            Users = new SqlUserService(),
            Catalog = new SqlItemCatalog(),
            Dishes = new SqlDishCatalog(),
            Requisition = new RequisitionService(bus)
        };

        using var menu = new MainMenuForm(services);

        Application.Run(menu);
    }
}
