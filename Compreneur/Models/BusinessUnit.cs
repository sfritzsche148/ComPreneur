using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compreneur.Models
{
    internal class BusinessUnit
    {
        public string BusinessUnitName { get; set; }

        public BusinessUnit(string businessUnitName) 
        {
            BusinessUnitName = businessUnitName;
        }
    }
}
