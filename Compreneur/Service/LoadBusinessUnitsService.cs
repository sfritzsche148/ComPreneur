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

                foreach(var line in lines)
                {
                    BusinessUnit businessUnit = MapToBusinessUnit(line);

                    if (businessUnit != null)
                    {
                        businessUnits.Add(businessUnit);
                    }
                }

            }

            return businessUnits;
        }

        private BusinessUnit MapToBusinessUnit(string data)
        {
            string[] properties = data.Split(';');
            return new BusinessUnit(properties[0]);
        }
    }
}
