using Singleton.Configuration;

namespace Singleton.Services;

public class LoggingService
{
    public void Log(string message)
    {
        var logLevel = ConfigurationManager.GetSetting("LogLevel");
        Console.WriteLine($"[LoggingService] [{logLevel}] {message}");
    }
}
