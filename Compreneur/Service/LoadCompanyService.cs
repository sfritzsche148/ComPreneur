using Compreneur.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compreneur.Service
{
    internal class LoadCompanyService
    {

        public Company LoadCompanyData(DirectoryInfo sourceDirectory, string companyName) 
        {
            var companyConfigurationFile = sourceDirectory.EnumerateFiles(companyName + "Configuration.txt").FirstOrDefault();
            int lineNumber = 0;
            Company company = new Company();
            if(!companyConfigurationFile.Exists)
            {
                return null;
            } else
            {
                string[] lines = File.ReadAllLines(companyConfigurationFile.FullName);
                if (lines != null)
                {
                    foreach (var line in lines)
                    {

                        if (!string.IsNullOrEmpty(line) && lineNumber != 0)
                        {
                            company = MapToCompany(line);
                        }
                        lineNumber++;
                    }
                    
                }
            }

            

            return company;
        }

        private Company MapToCompany(string data)
        {
            string[] properties = data.Split(';');

            return new Company()
            {
                CompanyName = properties[0],
                //CompanyRechtsform =
            };
        }
    }
}
