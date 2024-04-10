using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compreneur.Models
{
    internal class ViewModelTransfer
    {
        public string CompanyName { get; set; }
        public Rechtsform CompanyLegalForm { get; set; }
        public Branche CompanyBranche { get; set; }
        public int CompanyEmployeeCount { get; set; }
        public float CompanyMonthlySales { get; set; }
        public float CompanyYearSales { get; set; }
        public int CompanyLocationCount { get; set; }
        public ObservableCollection<string> CompanyLocationNames { get; set; }
        public float CompanyEconomics { get; set; }
        public float CompanyProfitability { get; set; }
        public float CompanyWorkProductivity { get; set; }
        public float CompanyMachineProductivity { get; set; }
        public float CompanyMaterialProductivity { get; set; }
    }
}
