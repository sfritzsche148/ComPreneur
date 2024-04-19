using Compreneur.Commands;
using Compreneur.Models;
using Compreneur.Service;
using Compreneur.Views;
using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Compreneur.ViewModels
{
    internal class LoadCompanyViewModel : ViewModelBase
    {

        private readonly MainViewModel _mainViewModel;
        private readonly LoadCompanyService _loadCompanyService;

        public Navigation Navigation { get; set; }

        public ViewModelTransfer ViewModelTransfer { get; set; }

        public ActionCommand LoadCompanyCommand { get; set; }

        public Model3D LoadCompanyModel { get; set; }


        public LoadCompanyViewModel(MainViewModel mainViewModel, Navigation navigation, LoadCompanyService loadCompanyService)
        {
            Navigation = navigation;
            _loadCompanyService = loadCompanyService;

            _mainViewModel = mainViewModel;
            LoadCompanyCommand = new ActionCommand(LoadCompany, CanLoadCompany);

            ViewModelTransfer = new ViewModelTransfer();
            ViewModelTransfer.CompanyName = "TestCompany";

            ModelImporter imp = new ModelImporter();
            LoadCompanyModel = imp.Load($"C:\\Users\\Sebastian\\OneDrive\\03_Sonstiges\\Dokumente\\My Games\\Compreneur\\buero1.obj");
        }

        public bool CanLoadCompany()
        {
            if (!String.IsNullOrEmpty(ViewModelTransfer.CompanyName))
            {
                return true;

            }
            return false;
        }

        public void LoadCompany()
        {
            Navigation.CurrentViewModel = _mainViewModel;
            _mainViewModel.Company = _loadCompanyService.LoadCompanyData(new DirectoryInfo("C:\\Users\\Sebastian\\OneDrive\\03_Sonstiges\\Dokumente\\My Games\\Compreneur"), "testCompany");
        }
    }
}
