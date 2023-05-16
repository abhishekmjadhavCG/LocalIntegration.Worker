using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalIntegration.Service.Core.Aggregator
{
    public interface IAggregator
    {        
        Task<bool> WriteToDestinationFileAsync(string eachSourcefileWithPath);        
    }
}
