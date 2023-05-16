using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using System.Diagnostics;
using static LocalIntegration.Service.Enum.LOVEnums;
using LocalIntegration.Service.Core.Validator.Validator;

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
        string combineSchemaFilePath;
        string headers = string.Empty;

        private readonly ISourceValidator _sourceValidator;

        #endregion

        #region Constructor

        public SourceFileProcessor(ISourceValidator sourceValidator)
        {
            _sourceValidator = sourceValidator;
        }
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
            JSchema? schema;
            JObject? customer;
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
                        Log.Information($"Starting reading each line in the file...");
                        var eachCustomerDataJson = await reader.ReadLineAsync();

                        //continuing to validate next line if the current line is empty or no data.
                        if (string.IsNullOrWhiteSpace(eachCustomerDataJson))
                        {
                            counter++;
                            continue;
                        }

                        combineSchemaFilePath = Path.Combine(schemaFilePath + "\\JsonSchema", schemaFile);
                        schema = JSchema.Parse(File.ReadAllText(combineSchemaFilePath));
                        customer = JObject.Parse(eachCustomerDataJson);

                        isFileValid = await _sourceValidator.ValidateSourceFieldsAsync(eachCustomerDataJson, schema, customer);                        

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
                    schema = null;
                    customer = null;
                }

                Log.Information($"Time taken for reading and validating the file - {watch.Elapsed.ToString()}");                
                watch.Stop();
            }

            return isFileValid;
        }

        #endregion

        #region Private Methods        

        #region ValidateSourceFields

        //private bool ValidateSourceFields(string? eachCustomerData)
        //{
        //    bool isValidFile = false;
        //    JSchema? schema;
        //    JObject? customer;

        //    try
        //    {                
                

        //        IList<string> errorMessages;
        //        isValidFile = customer.IsValid(schema, out errorMessages);                
        //        if (!isValidFile)
        //        {
        //            Log.Error($"Incorrect json data of the customer at below line \n \n {eachCustomerData} \n\n.");
        //            foreach (var errorMessage in errorMessages)
        //            {
        //                Log.Error($" Fix the following errors: \n\n Error : {errorMessages.IndexOf(errorMessage) + 1 } - {errorMessage} \n");
        //            }

        //            return isValidFile;
        //        }

        //        //var isComplexValidationsPassed = ValidateSourceFieldsForComplexScenario(eachCustomerData);
        //    }
        //    catch (Exception ex)
        //    {
        //        Log.Error($"Error occured while validating the file : {ex.Message} on the following data \n \n {eachCustomerData} \n \n");
        //    }
        //    finally 
        //    {
        //        schema = null;
        //        customer = null;
        //    }
        //    return isValidFile;
        //}

        private bool ValidateSourceFieldsForComplexScenario(string eachCustomerData)
        {
            return false;
        }
        
        #endregion

        #endregion


    }
}
