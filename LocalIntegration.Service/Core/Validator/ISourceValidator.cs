using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace LocalIntegration.Service.Core.Validator.Validator
{
    public interface ISourceValidator
    {
        Task<bool> ValidateSourceFieldsAsync(string? eachCustomerData, JSchema schema, JObject customer);
        Task<bool> ValidateSourceFieldsForComplexScenarioAsync(string eachCustomerData);
    }
}