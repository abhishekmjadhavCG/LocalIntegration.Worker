using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Schema;
using Serilog;

namespace LocalIntegration.Service.Core
{
    public class JsonSchemaResolver
    {
        private string filePath = Environment.GetEnvironmentVariable("JSON_SCHEMA_NR08_FILE_PATH");
        private string fileName = Environment.GetEnvironmentVariable("JSON_SCHEMA_NR08_FILE_NAME");
        public JsonSchemaResolver()
        {
            ResolveJsonSchema();
        }

        public void ResolveJsonSchema()
        {
            try
            {
                Log.Information("Starting to Resolve the Json schema as per Json.Net Schema library");

                var combinePath = Path.Combine(filePath, fileName);
                string jsonSchema = File.ReadAllText(combinePath);
               
            }
            catch(Exception ex)
            {
                Log.Error($"Error occured in :{ex.StackTrace}");
            }                        
        }
    }
}
