using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compreneur.Models
{
    enum LegalForms
    {
        Einzelunternehmen,
        GbR,
        OHG,
        KG,
        GmbH,
        AG,
        eG,
        UG
    }

    internal class Company
    {
        public string CompanyName { get; set; }
        public LegalForms CompanyLegalForm { get; set; }
        public string CompanyBranche { get; set; }
        public int CompanyEmployeeCount { get; set; }
        public float CompanyMonthlySales { get; set; }
        public float CompanyYearSales { get; set; }
        public int CompanyLocationCount { get; set; }
        public string[] CompanyLocationNames { get; set; }
        public float CompanyYearEconomics { get; set; }
        public float CompanyProfitability { get; set; }
        public float CompanyWorkProductivity { get; set; }
        public float CompanyMachineProductivity { get; set; }
        public float CompanyMaterialProductivity { get; set; }
        public float CompanyMonthlyProfit { get; set; }
        public float CompanyYearProfit { get; set; }
        public float CompanyYearCosts { get; set; } // Muss noch gemappt werden
        public float CompanyMachineInput { get; set; } // Muss noch gemappt werden
        public float CompanyWorkInput { get; set; } // Muss noch gemappt werden
        public float CompanyMaterialInput { get; set; } // Muss noch gemappt werden
        public float CompanyMachineOutput { get; set; } // Muss noch gemappt werden
        public float CompanyMaterialOutput { get; set; } // Muss noch gemappt werden
        public float CompanyWorkOutput { get; set; } // Muss noch gemappt werden
    }
}
