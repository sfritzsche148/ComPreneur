using Compreneur.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compreneur.Service
{
    internal class CreateBusinessUnitService
    {
        public BusinessUnit CreateBusinessUnit(DirectoryInfo sourceDirectory, Company company, string businessUnitName)
        {
            if (sourceDirectory.Exists && company != null && businessUnitName != null)
            {
                var configFile = sourceDirectory.EnumerateFiles(company.CompanyName + "BusinessUnitsConfiguration.txt").FirstOrDefault();

                BusinessUnit businessUnit = new BusinessUnit(businessUnitName);
                File.AppendAllText(configFile.FullName, businessUnit.BusinessUnitName + ";");

                return businessUnit;
            }


            return null;
        }
    }
}
