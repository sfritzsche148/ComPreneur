using Compreneur.Commands;
using Compreneur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

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


        public StartViewModel(LoadCompanyViewModel loadCompanyViewModel, CreateCompanyViewModel createCompanyViewModel, Navigation navigation)
        {
            _navigation = navigation;
            _loadCompanyViewModel = loadCompanyViewModel;
            _createCompanyViewModel = createCompanyViewModel;
            OpenLoadCompanyViewCommand = new ActionCommand(OpenLoadCompanyView, CanOpenLoadComapanyView);
            OpenCreateCompanyViewCommand = new ActionCommand(OpenCreateCompanyView, CanOpenCreateComapanyView);
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
