using LocalIntegration.Service.Core;
using Serilog;

namespace LocalIntegration.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Log.Information("\n\nScheduler started");
            
            var sourcesFilePath = Environment.GetEnvironmentVariable("JSON_SOURCE_FILE_PATH");
            var sourcesFile = Environment.GetEnvironmentVariable("JSON_SOURCE_FILE_NAME");

            if (!File.Exists(Path.Combine(sourcesFilePath, sourcesFile)))
            {
                Log.Error("Could not find sources file in the respective folder. Scheduler stopping..");
                return;
            }
            
            SourceFileProcessor sourceFileProcessor = new SourceFileProcessor(sourcesFilePath);
            while (!stoppingToken.IsCancellationRequested)
            {                
                Log.Information("Initiaiting the source file processing..");

                var isValid = await sourceFileProcessor.ReadFileAsync();

                //Stopping the service from further executing in case of validation errors.
                if (!isValid) 
                { 
                    Log.Error("Scheduler stopping as json file is not validated.");
                    break;
                }

                Log.Information($"Scheduler stopping...");
                await Task.Delay(TimeSpan.FromDays(1), stoppingToken);
            }
           
        }
    }
}