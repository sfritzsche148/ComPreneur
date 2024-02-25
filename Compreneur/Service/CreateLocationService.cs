using Compreneur.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compreneur.Service
{
    internal class CreateLocationService
    {
        public void CreateLocation(DirectoryInfo sourceDirectory, Company company, string locationName, List<Location> locations)
        {
            Location location = new Location()
            {
                LocationName = locationName
            };
            if (location != null)
            {
                locations.Add(location);

            }
            var locationsConfigFile = sourceDirectory.EnumerateFiles(company.CompanyName + "LocationConfiguration.txt").FirstOrDefault();

            if (locationsConfigFile.Exists)
            {
                StreamWriter locationsConfig = new StreamWriter(locationsConfigFile.FullName);
                foreach(var loaction in locations)
                {
                    locationsConfig.WriteLine(location);
                }
            }


        }
    }
}
