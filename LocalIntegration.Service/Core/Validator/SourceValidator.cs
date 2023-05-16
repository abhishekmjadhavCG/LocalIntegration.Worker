using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalIntegration.Service.Core.Validator.Validator;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Serilog;

namespace LocalIntegration.Service.Core.Validator
{
    public class SourceValidator : ISourceValidator
    {
        public async Task<bool> ValidateSourceFieldsAsync(string? eachCustomerData, JSchema schema, JObject customer)
        {
            bool isValidFile = false;
            IList<string> errorMessages;

            try
            {
                isValidFile = customer.IsValid(schema, out errorMessages);
                if (!isValidFile)
                {
                    Log.Error($"Incorrect json data of the customer at below line \n \n {eachCustomerData} \n\n.");
                    foreach (var errorMessage in errorMessages)
                    {
                        Log.Error($" Fix the following errors: \n\n Error : {errorMessages.IndexOf(errorMessage) + 1} - {errorMessage} \n");
                    }
                }

                //var isComplexValidationsPassed = ValidateSourceFieldsForComplexScenario(eachCustomerData);
            }
            catch (Exception ex)
            {
                Log.Error($"Error occured while validating the file : {ex.Message} on the following data \n \n {eachCustomerData} \n \n");
            }
            finally
            {
                schema = null;
                customer = null;
            }
            return isValidFile;
        }

        public Task<bool> ValidateSourceFieldsForComplexScenarioAsync(string eachCustomerData)
        {
            throw new NotImplementedException();
        }
    }
}
