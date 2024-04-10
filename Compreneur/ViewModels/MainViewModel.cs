using Compreneur.Commands;
using Compreneur.Models;
using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Media3D;

namespace Compreneur.ViewModels
{ 
    internal class MainViewModel : ViewModelBase
    {

        public Building MainBuildingModel { get; set; }

        public ActionCommand ChangeBetweenBuildingsCommnd { get; set; }

        public MainViewModel()
        {
            ChangeBetweenBuildingsCommnd = new ActionCommand(ChangeBuilding, CanChangeBuilding);

            ModelImporter imp = new ModelImporter();
            MainBuildingModel = new Building();
            MainBuildingModel.Model = imp.Load($"C:\\Users\\Sebastian\\OneDrive\\03_Sonstiges\\Dokumente\\My Games\\Compreneur\\buero1.obj");
        }

        private bool CanChangeBuilding()
        {
            return true;
        }

        private void ChangeBuilding()
        {
            //TODOs for 03.04.2024
                // - ActionCommand with parameter
                // - automatische Button erstellung
        }
    }
}
