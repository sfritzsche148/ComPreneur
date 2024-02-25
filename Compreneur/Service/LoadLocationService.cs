using Compreneur.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compreneur.Service
{
    internal class LoadLocationService
    {

        public List<Location> locations(DirectoryInfo sourceDirectory, Company company)
        {
            List<Location> locations = new List<Location>();

            var configFile = sourceDirectory.EnumerateFiles(company.CompanyName + "LocationsConfiguration.txt").FirstOrDefault();
            
            if (configFile != null)
            {
                string[] lines = File.ReadAllLines(configFile.FullName);

                foreach(var line in lines)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        
                    }
                }


            }

            return locations;
        }
    }
}
