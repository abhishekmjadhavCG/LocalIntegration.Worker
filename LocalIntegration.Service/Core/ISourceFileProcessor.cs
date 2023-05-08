using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalIntegration.Service.Core
{
    internal interface ISourceFileProcessor
    {
        public Task<bool> ReadFileAsync();
    }
}
