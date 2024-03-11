using Compreneur.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Compreneur.Service
{
    internal class LoadBusinessUnitsService
    {

        public List<BusinessUnit> LoadBusinessUnits(DirectoryInfo sourceDirectory, Company company)
        {
            List<BusinessUnit> businessUnits = new List<BusinessUnit>();

            var configFile = sourceDirectory.EnumerateFiles(company.CompanyName + "BusinessUnitsConfiguration.txt").FirstOrDefault();
            
            if (configFile != null)
            {
                string[] lines = File.ReadAllLines(configFile.FullName);

                int lineNumber = 0;

                foreach(var line in lines)
                {
                    if (lineNumber != 0)
                    {
                        BusinessUnit businessUnit = MapToBusinessUnit(line, company);

                        if (businessUnit != null)
                        {
                            businessUnits.Add(businessUnit);
                        }
                    }
                    lineNumber++;

                }

            }

            return businessUnits;
        }

        private BusinessUnit MapToBusinessUnit(string data, Company company)
        {
            string[] properties = data.Split(';');
            if (properties[0] == company.CompanyName)
            {
                return new BusinessUnit(properties[1]);

            }
            return null;
        }
    }
}
