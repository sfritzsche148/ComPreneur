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

        public List<Location> LoadLocations(DirectoryInfo sourceDirectory, string companyName)
        {
            List<Location> locations = new List<Location>();

            var configFile = sourceDirectory.EnumerateFiles(companyName + "LocationsConfiguration.txt").FirstOrDefault();
            
            if (configFile != null)
            {
                string[] lines = File.ReadAllLines(configFile.FullName);
                int lineNumber = 0;

                foreach(var line in lines)
                {
                    if (!string.IsNullOrEmpty(line) && lineNumber != 0)
                    {
                        locations.Add(new Location()
                        {
                            LocationName = "test"
                        }) ;
                    }
                    lineNumber++;
                }
                return locations;

            } else
            {
                return null;
            }

        }
    }
}
