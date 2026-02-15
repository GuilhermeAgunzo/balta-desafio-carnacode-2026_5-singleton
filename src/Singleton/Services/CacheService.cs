using Singleton.Configuration;

namespace Singleton.Services;

public class CacheService
{
    public void Connect()
    {
        var cacheServer = ConfigurationManager.GetSetting("CacheServer");
        Console.WriteLine($"[CacheService] Conectando ao cache: {cacheServer}");
    }
}
