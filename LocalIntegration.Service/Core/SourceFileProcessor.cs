using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using System.Diagnostics;

namespace LocalIntegration.Service.Core
{
    public class SourceFileProcessor : ISourceFileProcessor
    {
        #region Declarations

        string sourcesFile = string.Empty;
        string sourcesFilePath = string.Empty;
        string schemaFile = string.Empty;
        string schemaFilePath = string.Empty;
        string combineSourcesFilePath = string.Empty;
        string headers = string.Empty;

        #endregion

        #region Constructor

        public SourceFileProcessor(string jsonPath)
        {
           LoadFileDetails();           
        }



        #endregion

        #region LoadFileDetails
        public void LoadFileDetails()
        {
            //Json source file with data to validate
            sourcesFile = Environment.GetEnvironmentVariable("JSON_SOURCE_FILE_NAME");
            sourcesFilePath = Environment.GetEnvironmentVariable("JSON_SOURCE_FILE_PATH");
            combineSourcesFilePath = Path.Combine(sourcesFilePath, sourcesFile);

            //Json schema file with defined constraints
            schemaFile = Environment.GetEnvironmentVariable("JSON_SCHEMA_NR08_FILE_NAME");
            schemaFilePath = Environment.GetEnvironmentVariable("JSON_SCHEMA_NR08_FILE_PATH");            
        }
        #endregion

        #region ReadFileAsync

        public async Task<bool> ReadFileAsync()
        {
            var isFileValid = false;
            using (StreamReader reader = new StreamReader(combineSourcesFilePath))
            {
                int counter = 0;
                var watch = new Stopwatch();
                watch.Start();
                try
                {

                    while (!reader.EndOfStream)
                    {
                        if (counter == 0)
                        {
                            headers = await reader.ReadLineAsync();
                            counter++;
                            continue;
                        }

                        var eachCustomerDataJson = await reader.ReadLineAsync();

                        //continuing to validate next line if the current line is empty or no data.
                        if (string.IsNullOrWhiteSpace(eachCustomerDataJson))
                        {
                            counter++;
                            continue;
                        }

                        isFileValid = await Task.Run(() => ValidateSourceFields(eachCustomerDataJson));

                        if (!isFileValid)
                        {
                            break;
                        }

                        counter++;
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($"Error occured in ReadFileAsync method {ex.StackTrace.ToString()}");
                }
                finally
                {
                    reader.Close();
                    reader.Dispose();
                }

                Log.Information($"Time taken for reading and validating the file - {watch.Elapsed.ToString()}");
                watch.Stop();
            }

            return isFileValid;
        }

        #endregion

        #region Private Methods        

        #region ValidateSourceFields

        private bool ValidateSourceFields(string? eachCustomerData)
        {
            bool isValidFile = false;
            JSchema? schema;
            JObject? customer;

            try
            {
                //var combineSourcesFilePath = Path.Combine(sourcesFilePath, sourcesFile);
                var combineSchemaFilePath = Path.Combine(schemaFilePath, schemaFile);

                schema = JSchema.Parse(File.ReadAllText(combineSchemaFilePath));
                customer = JObject.Parse(eachCustomerData);

                IList<string> errorMessages;
                isValidFile = customer.IsValid(schema, out errorMessages);

                if (!isValidFile)
                {
                    foreach (var errorMessage in errorMessages)
                    {
                        Log.Warning($"The json is not in correct format. Below are the errors: \n\n {errorMessage} \n");
                    }

                    return isValidFile;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Error occured while validating the file : {ex.StackTrace}");
            }
            finally 
            {
                schema = null;
                customer = null;
            }
            return isValidFile;
        }
        
        #endregion

        #endregion


    }
}
