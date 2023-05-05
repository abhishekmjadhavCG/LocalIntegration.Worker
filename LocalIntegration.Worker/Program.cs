using Serilog;

namespace LocalIntegration.Worker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Environment.SetEnvironmentVariable("JSON_SOURCE_FILE_PATH", @"C:\Users\amohanja\WorkRelated\Project");
            Environment.SetEnvironmentVariable("LOG_FILE_PATH", $@"C:\LIL_LOGS\{DateTime.UtcNow.ToShortDateString()}");
            
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
            .Build().Run();            
        }
    }
}