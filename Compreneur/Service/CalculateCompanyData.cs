using Compreneur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;

namespace Compreneur.Service
{
    internal class CalculateCompanyData
    {
        public void Calculate(Company company)
        {
            company.CompanyYearEconomics = company.CompanyYearSales / company.CompanyYearCosts;
            company.CompanyWorkProductivity = company.CompanyWorkOutput / company.CompanyWorkInput;
            company.CompanyMachineProductivity = company.CompanyMachineOutput / company.CompanyMachineInput;
            company.CompanyMaterialProductivity = company.CompanyMaterialOutput / company.CompanyMaterialInput;
        }
    }

}
