using Compreneur.Enums;
using Compreneur.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;

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
            Company company = new Company();

            LegalForms legalForm = new LegalForms();
            switch(properties[1])
            {
                case "GmbH":
                    legalForm = LegalForms.GmbH;
                    break;
            }


            var locationNames = properties[7].Split(',');


            company.CompanyName = properties[0];
            company.CompanyLegalForm = legalForm;
            company.CompanyBranche = properties[2];
            company.CompanyEmployeeCount = int.Parse(properties[3]);
            company.CompanyMonthlySales = float.Parse(properties[4]);
            company.CompanyYearSales = float.Parse(properties[5]);
            company.CompanyLocationCount = int.Parse(properties[6]);
            company.CompanyLocationNames = locationNames;
            company.CompanyYearEconomics = float.Parse(properties[8]);
            company.CompanyProfitability = float.Parse(properties[9]);
            company.CompanyWorkProductivity = float.Parse(properties[10]);
            company.CompanyMachineProductivity = float.Parse(properties[11]);
            company.CompanyMaterialProductivity = float.Parse(properties[12]);
            company.CompanyMonthlyProfit = float.Parse(properties[13]);
            company.CompanyYearProfit = float.Parse(properties[14]);

            return company;
        }
    }
}
