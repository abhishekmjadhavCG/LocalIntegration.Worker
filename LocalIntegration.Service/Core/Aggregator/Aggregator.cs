using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalIntegration.Service.Core.Aggregator
{
    public class Aggregator: IAggregator
    {
        public Aggregator() { }

        public Task<bool> WriteToDestinationFileAsync(string eachSourcefileWithPath)
        {
            throw new NotImplementedException();
        }
    }
}
