using Compreneur.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Compreneur.Service
{
    internal class LoadBuildingService
    {

        public List<Building> GetBuildings(DirectoryInfo sourceDirectory, string companyName, string locationName)
        {
            List<Building> buildings = new List<Building>();

            var configFile = sourceDirectory.EnumerateFiles(companyName + locationName + "BuildingsConfiguration.txt").FirstOrDefault();

            if (configFile.Exists)
            {
                var lines = File.ReadLines(configFile.FullName);
                if (lines != null)
                {
                    int lineNumber = 0;
                    foreach (var line in lines)
                    {
                        if (lineNumber != 0)
                        {
                            Building building = MapToBuilding(line);
                            if (building != null)
                            {
                                buildings.Add(building);
                            }
                        }
                        lineNumber++;
                    }
                    return buildings;

                } else
                {
                    return null;
                }

            } else
            {
                return null;
            }

        }

        public Building MapToBuilding(string data)
        {
            if (!String.IsNullOrEmpty(data))
            {
                string[] properties = data.Split(';');
                return new Building(properties[0], properties[1]);

            }
            return null;
        }
    }
}
