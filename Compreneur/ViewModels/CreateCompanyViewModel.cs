using Compreneur.Commands;
using Compreneur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compreneur.ViewModels
{
    internal class CreateCompanyViewModel : ViewModelBase
    {
        private readonly MainViewModel _mainViewModel;


        public Navigation Navigation { get; set; }

        public ActionCommand CreateCompanyCommand { get; set; }

        public CreateCompanyViewModel(MainViewModel mainViewModel, Navigation navigation)
        {
            Navigation = navigation;

            _mainViewModel = mainViewModel;

            CreateCompanyCommand = new ActionCommand(CreateCompany, CanCreateCompany);
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
