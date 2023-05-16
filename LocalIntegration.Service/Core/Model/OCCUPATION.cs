using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalIntegration.Service.Core.Model
{
    public class OCCUPATION
    {
        [MaxLength(6)]
        public string OCCUPATION_1 { get; set; }

        [MaxLength(6)]
        public string OCCUPATION_2 { get; set; }
    }
}
