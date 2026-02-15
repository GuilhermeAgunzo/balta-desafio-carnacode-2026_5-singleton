using Singleton.Configuration;

namespace Singleton.Services;

public class DatabaseService
{

    public DatabaseService()
    {

    }

    public void Connect()
    {
        var connectionString = ConfigurationManager.GetSetting("DatabaseConnection");
        Console.WriteLine($"[DatabaseService] Conectando ao banco: {connectionString}");
    }
}
