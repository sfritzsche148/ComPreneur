using Compreneur.Commands;
using Compreneur.Models;
using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Media3D;

namespace Compreneur.ViewModels
{
    internal class StartViewModel :ViewModelBase
    {

        private readonly LoadCompanyViewModel _loadCompanyViewModel;
        private readonly CreateCompanyViewModel _createCompanyViewModel;

        public ActionCommand OpenLoadCompanyViewCommand { get; set; }
        public ActionCommand OpenCreateCompanyViewCommand { get; set; }

        private Navigation _navigation;

        public Navigation Navigation
        {
            get { return _navigation; }
            set { _navigation = value; RaisePropertyChanged(nameof(Navigation)); }
        }

        public Model3D StartPageModel1 { get; set; }


        public StartViewModel(LoadCompanyViewModel loadCompanyViewModel, CreateCompanyViewModel createCompanyViewModel, Navigation navigation)
        {
            _navigation = navigation;
            _loadCompanyViewModel = loadCompanyViewModel;
            _createCompanyViewModel = createCompanyViewModel;
            OpenLoadCompanyViewCommand = new ActionCommand(OpenLoadCompanyView, CanOpenLoadComapanyView);
            OpenCreateCompanyViewCommand = new ActionCommand(OpenCreateCompanyView, CanOpenCreateComapanyView);
            ModelImporter imp = new ModelImporter();
            StartPageModel1 = imp.Load($"C:\\Users\\Sebastian\\OneDrive\\03_Sonstiges\\Dokumente\\My Games\\Compreneur\\buero1.obj");
        }

        public bool CanOpenLoadComapanyView()
        {
            return true;
        }
        public void OpenLoadCompanyView()
        {
            Navigation.CurrentViewModel = _loadCompanyViewModel;
        }

        public bool CanOpenCreateComapanyView()
        {
            return true;
        }

        public void OpenCreateCompanyView()
        {
            Navigation.CurrentViewModel = _createCompanyViewModel;
        }
    }
}
