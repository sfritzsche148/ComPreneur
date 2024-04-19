using Compreneur.Commands;
using Compreneur.Models;
using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Compreneur.ViewModels
{
    internal class CreateCompanyViewModel : ViewModelBase
    {
        private readonly MainViewModel _mainViewModel;


        public Navigation Navigation { get; set; }

        public ViewModelTransfer ViewModelTransfer { get; set; }

        public ActionCommand CreateCompanyCommand { get; set; }

        public Model3D CreateCompanyModel { get; set; }

        public CreateCompanyViewModel(MainViewModel mainViewModel, Navigation navigation)
        {
            Navigation = navigation;

            _mainViewModel = mainViewModel;
            ViewModelTransfer = new ViewModelTransfer();

            CreateCompanyCommand = new ActionCommand(CreateCompany, CanCreateCompany);
            ModelImporter imp = new ModelImporter();
            CreateCompanyModel = imp.Load($"C:\\Users\\Sebastian\\OneDrive\\03_Sonstiges\\Dokumente\\My Games\\Compreneur\\buero1.obj");
        }

        public bool CanCreateCompany()
        {
            return true;
        }

        public void CreateCompany()
        {
            Navigation.CurrentViewModel = _mainViewModel;
        }
    }
}
