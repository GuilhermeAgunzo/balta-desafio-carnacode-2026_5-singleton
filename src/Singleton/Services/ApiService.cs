using Singleton.Configuration;

namespace Singleton.Services;

public class ApiService
{
    public void MakeRequest()
    {
        var apiKey = ConfigurationManager.GetSetting("ApiKey");
        Console.WriteLine($"[ApiService] Fazendo requisição com API Key: {apiKey}");
    }
}