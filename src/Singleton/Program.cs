using Singleton.Services;

Console.WriteLine("=== Sistema de Configurações ===\n");
Console.WriteLine("Inicializando serviços...\n");

var dbService = new DatabaseService();
var apiService = new ApiService();
var cacheService = new CacheService();
var logService = new LoggingService();

Console.WriteLine("\nUsando os serviços...\n");

dbService.Connect();
apiService.MakeRequest();
cacheService.Connect();
logService.Log("Sistema iniciado");