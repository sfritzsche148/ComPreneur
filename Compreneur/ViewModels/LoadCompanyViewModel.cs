using Compreneur.Commands;
using Compreneur.Models;
using Compreneur.Views;
using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Compreneur.ViewModels
{
    internal class LoadCompanyViewModel : ViewModelBase
    {

        private readonly MainViewModel _mainViewModel;

        public Navigation Navigation { get; set; }

        public ViewModelTransfer ViewModelTransfer { get; set; }

        public ActionCommand LoadCompanyCommand { get; set; }

        public Model3D LoadCompanyModel { get; set; }


        public LoadCompanyViewModel(MainViewModel mainViewModel, Navigation navigation)
        {
            Navigation = navigation;

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
        }
    }
}
