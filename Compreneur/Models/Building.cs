using Compreneur.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Compreneur.Models
{
    internal class Building
    {
        public string BuildingName { get; set; }

        private BuildingType _buildingType;

        public BuildingType BuildingType
        {
            get { return _buildingType; }
            set { _buildingType = value;}
        }

        public Model3D Model { get; set; }

    }
}
