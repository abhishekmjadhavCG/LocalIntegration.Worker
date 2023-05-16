using LocalIntegration.Service.Core;
using Serilog;
using System.Reflection;

namespace LocalIntegration.Worker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var currentDirectory = new System.Uri(Assembly.GetExecutingAssembly().CodeBase).AbsolutePath.Split("/bin")[0];
            Environment.SetEnvironmentVariable("JSON_SOURCE_FILE_PATH", @"C:\Users\amohanja\WorkRelated\Project");
            Environment.SetEnvironmentVariable("JSON_SOURCE_FILE_NAME", "Sample JSON Source structure.json"); //"Sources.json Sample JSON Source structure.json");
            Environment.SetEnvironmentVariable("JSON_SCHEMA_NR08_FILE_PATH", $@"{currentDirectory}"); //C:\Users\amohanja\WorkRelated\Important Files for development\NORKOM GAP");
            Environment.SetEnvironmentVariable("JSON_SCHEMA_NR08_FILE_NAME", "JSON-SCHEMA-NR08.json");
            Environment.SetEnvironmentVariable("LOG_FILE_PATH", $@"C:\LIL_LOGS\LogFile.txt");
            
            var logFilePath = Environment.GetEnvironmentVariable("LOG_FILE_PATH");

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Warning)
                .WriteTo.File(logFilePath)
                .Enrich.FromLogContext()
                .CreateLogger();

            IHostBuilder builder = Host.CreateDefaultBuilder(args);
            
            builder.ConfigureServices(services =>
            {
                services.AddHostedService<Worker>();
            })
            .UseSerilog()
            .Build().Run();            
        }
    }
}