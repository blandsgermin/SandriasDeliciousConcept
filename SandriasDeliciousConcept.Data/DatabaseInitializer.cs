using Microsoft.Data.SqlClient;

namespace SandriasDeliciousConcept.Data;

public static class DatabaseInitializer
{
    public const string DatabaseName = "SandriasCommissaryDB";

    public static string AppConnection
    {
        get
        {
            string server =
                Environment.GetEnvironmentVariable("SANDRIAS_SQL_SERVER")
                ?? @"(localdb)\MSSQLLocalDB";

            return new SqlConnectionStringBuilder
            {
                DataSource = server,
                InitialCatalog = DatabaseName,
                IntegratedSecurity = true,
                TrustServerCertificate = true
            }.ConnectionString;
        }
    }

    public static void EnsureCreated()
    {
        using var connection = new SqlConnection(AppConnection);
        connection.Open();
    }
}
