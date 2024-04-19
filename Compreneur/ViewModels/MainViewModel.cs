using Compreneur.Commands;
using Compreneur.Models;
using Compreneur.Service;
using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Media3D;

namespace Compreneur.ViewModels
{ 
    internal class MainViewModel : ViewModelBase
    {

        private readonly CompanyOverViewViewModel _companyOverViewVM;
        private readonly LoadCompanyService _loadCompanyService;

        public Building MainBuildingModel { get; set; }

        public ActionCommand ChangeBetweenBuildingsCommand { get; set; }
        public ActionCommand OpenCompanyOverViewCommand { get; set; }

        public Navigation Navigation { get; set; }

        public Company Company { get; set; }



        public MainViewModel(CompanyOverViewViewModel companyOverViewViewModel, Navigation navigation, LoadCompanyService loadCompanyService)
        {
            Navigation = navigation;
            _companyOverViewVM = companyOverViewViewModel;
            _loadCompanyService = loadCompanyService;


            ChangeBetweenBuildingsCommand = new ActionCommand(ChangeBuilding, CanChangeBuilding);
            OpenCompanyOverViewCommand = new ActionCommand(OpenCompanyOverView, CanOpenCompanyOverView);

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

        private bool CanOpenCompanyOverView()
        {
            return true;
        }
        private void OpenCompanyOverView()
        {
            Navigation.CurrentViewModel = _companyOverViewVM;
            _companyOverViewVM.Company = Company;
        }
    }
}
