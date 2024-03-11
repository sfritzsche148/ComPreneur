using Compreneur.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compreneur.Models
{
    internal class Building
    {
        public string BuildingName { get; set; }
        public BuildingType BuildingType { get; set; }

        public Building(string name, string buildingType)
        {
            BuildingName = name;

            switch(buildingType)
            {
                case "buero1":
                    BuildingType = BuildingType.Buero1;
                    break;
                case "buero2":
                    BuildingType = BuildingType.Buero2;
                    break;
                case "factory1":
                    BuildingType = BuildingType.Factory1;
                    break;
            }
        }
    }
}
