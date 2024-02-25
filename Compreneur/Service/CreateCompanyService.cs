using Compreneur.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compreneur.Service
{
    internal class CreateCompanyService
    {
        private Company CreateCompany(DirectoryInfo sourceDirectory, string companyName)
        {
            if (sourceDirectory.Exists && !string.IsNullOrEmpty(companyName))
            {
                Company company = new Company();

                File.WriteAllText(sourceDirectory + companyName + "Configuration.txt", company.CompanyName + ";");
                return new Company();
            }

            return null;

        }
    }
}
