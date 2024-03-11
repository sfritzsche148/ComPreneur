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
using System.Diagnostics;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using System.Collections.ObjectModel;

namespace Compreneur.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private readonly LoadCompanyService _loadCompanyService;
        private readonly LoadLocationService _loadLocationService;
        private readonly LoadBuildingService _loadBuildingService;
        private readonly LoadBusinessUnitsService _loadBusinessUnitsService;

        public Company Company { get; set; }

        public List<Location> Locations { get; set; }
        public List<Building> Buildings { get; set; }
        public List<BusinessUnit> BusinessUnits { get; set; }

        private Visibility startPageVisibility = Visibility.Collapsed;

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

        private Visibility mainPageVisibility = Visibility.Visible;

        public Visibility MainPageVisibility
        {
            get { return mainPageVisibility; }
            set { mainPageVisibility = value; }
        }



        public ActionCommand openLoadCompanyPageCommand { get; set; }
        public ActionCommand openCreateCompanyPageCommand { get; set; }

        public Model3D StartPageModel1 { get; set; }
        public Model3D StartPageModel2 { get; set; }

        public ObservableCollection<Model3D> BuildingModels { get; set; }

        public MainWindowViewModel()
        {
            List<Building> startPageBuildings = new List<Building>();
            startPageBuildings.Add(new Building("StartPage1", "buero1"));
            startPageBuildings.Add(new Building("StartPage1", "factory1"));
            LoadStartPageBuildingModels(startPageBuildings);

            BuildingModels = new ObservableCollection<Model3D>();

            openLoadCompanyPageCommand = new ActionCommand(OpenLoadCompanyPage, canOpenLoadCompanyPage);
            openCreateCompanyPageCommand = new ActionCommand(OpenCreateCompanyPage, canOpenCreateCompanyPage);
            _loadCompanyService = new LoadCompanyService();
            _loadLocationService = new LoadLocationService();
            _loadBuildingService = new LoadBuildingService();
            _loadBusinessUnitsService = new LoadBusinessUnitsService();

            Company = _loadCompanyService.LoadCompanyData(new DirectoryInfo("C:\\Users\\Sebastian\\OneDrive\\03_Sonstiges\\Dokumente\\My Games\\Compreneur"), "testCompany");
            Locations = _loadLocationService.LoadLocations(new DirectoryInfo("C:\\Users\\Sebastian\\OneDrive\\03_Sonstiges\\Dokumente\\My Games\\Compreneur"), "testCompany");
            Buildings = _loadBuildingService.GetBuildings(new DirectoryInfo("C:\\Users\\Sebastian\\OneDrive\\03_Sonstiges\\Dokumente\\My Games\\Compreneur"), "testCompany", "st1");
            BusinessUnits = _loadBusinessUnitsService.LoadBusinessUnits(new DirectoryInfo("C:\\Users\\Sebastian\\OneDrive\\03_Sonstiges\\Dokumente\\My Games\\Compreneur"), Company);
            LoadMainPageBuildingModels(Buildings);


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

        public void LoadStartPageBuildingModels(List<Building> buildings)
        {
            if (buildings != null)
            {
                int modelNumber = 1;
                foreach(var building in buildings)
                {
                    ModelImporter imp = new ModelImporter();
                    if (modelNumber == 1)
                    {
                        StartPageModel1 = imp.Load($"C:\\Users\\Sebastian\\OneDrive\\03_Sonstiges\\Dokumente\\My Games\\Compreneur\\{building.BuildingType}.obj");

                    } else if (modelNumber == 2)
                    {
                        StartPageModel2 = imp.Load($"C:\\Users\\Sebastian\\OneDrive\\03_Sonstiges\\Dokumente\\My Games\\Compreneur\\{building.BuildingType}.obj");
                    }
                    modelNumber++;
                }

            }
        }

        public void LoadMainPageBuildingModels(List<Building> buildings)
        {
            if (buildings != null)
            {
                int modelNumber = 1;
               
                foreach (var building in buildings)
                {
                    ModelImporter imp = new ModelImporter();
                    if (building.BuildingType == Enums.BuildingType.Buero1)
                    {
                        BuildingModels.Add(imp.Load($"C:\\Users\\Sebastian\\OneDrive\\03_Sonstiges\\Dokumente\\My Games\\Compreneur\\buero1.obj"));
                        BuildingModels.Add(imp.Load($"C:\\Users\\Sebastian\\OneDrive\\03_Sonstiges\\Dokumente\\My Games\\Compreneur\\buero2.obj"));

                    }
                    else if (building.BuildingType == Enums.BuildingType.Buero2)
                    {

                    }
                    modelNumber++;
                }
            }
        }
    }
}
