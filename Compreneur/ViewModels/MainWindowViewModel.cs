using Compreneur.Commands;
using Compreneur.Models;
using Compreneur.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace Compreneur.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private readonly LoadCompanyService _loadCompanyService;

        public Company Company { get; set; }

        private Visibility startPageVisibility = Visibility.Visible;

        public Visibility StartPageVisibility
        {
            get { return startPageVisibility; }
            set 
            { 
                startPageVisibility = value;
                RaisePropertyChanged(nameof(StartPageVisibility));
            }
        }


        private Visibility loadCompanyPageVisibility = Visibility.Collapsed;

        public Visibility LoadCompanyPageVisibility
        {
            get { return loadCompanyPageVisibility; }
            set { loadCompanyPageVisibility = value;
                RaisePropertyChanged(nameof(LoadCompanyPageVisibility));
            }
        }


        private Visibility createCompanyPageVisibility = Visibility.Collapsed;

        public Visibility CreateCompanyPageVisibility
        {
            get { return createCompanyPageVisibility; }
            set 
            { 
                createCompanyPageVisibility = value;
                RaisePropertyChanged(nameof(CreateCompanyPageVisibility));
            }
        }


        public ActionCommand openLoadCompanyPageCommand { get; set; }
        public ActionCommand openCreateCompanyPageCommand { get; set; }

        public MainWindowViewModel()
        {
            openLoadCompanyPageCommand = new ActionCommand(OpenLoadCompanyPage, canOpenLoadCompanyPage);
            openCreateCompanyPageCommand = new ActionCommand(OpenCreateCompanyPage, canOpenCreateCompanyPage);
            _loadCompanyService = new LoadCompanyService();

            Company = _loadCompanyService.LoadCompanyData(new DirectoryInfo("C:\\Users\\Sebastian\\OneDrive\\03_Sonstiges\\Dokumente\\My Games\\Compreneur"), "testCompany");
        }

        public bool canOpenLoadCompanyPage()
        {
            return true;
        }

        public void OpenLoadCompanyPage()
        {
            StartPageVisibility = Visibility.Collapsed;
            LoadCompanyPageVisibility = Visibility.Visible;
        }

        public bool canOpenCreateCompanyPage()
        {
            return true;
        }

        public void OpenCreateCompanyPage()
        {
            StartPageVisibility = Visibility.Collapsed;
            CreateCompanyPageVisibility = Visibility.Visible;
        }
    }
}
