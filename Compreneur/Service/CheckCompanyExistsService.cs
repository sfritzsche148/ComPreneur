using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compreneur.Service
{
    internal class CheckCompanyExistsService
    {

        public bool CheckCompanyExists(string companyName)
        {
            int count = 0;

            SqlConnection connection = new SqlConnection("LAPTOP-LDJ9CKVE\\COMPRENEURSERVER");

            connection.Open();

            string abfrage = $"SELECT COUNT(*) from Company Where CompanyName = {companyName}";

            SqlCommand command = new SqlCommand(abfrage, connection);
            // ExecuteScalar gibt an wie viele Einträge in der Datenbank gefunden wurden!
            count = (Int32)command.ExecuteScalar();

            if (count == 1)
            {
                return true;
            } else
            {
                return false;
            }


        }
    }
}
