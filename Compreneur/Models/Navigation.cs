﻿using Compreneur.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compreneur.Models
{
    internal class Navigation
    {

		public event Action CurrentViewModelChanged;
		private ViewModelBase _currentViewModel;

		public ViewModelBase CurrentViewModel
		{
			get { return _currentViewModel; }
			set { _currentViewModel = value; OnCurrentViewModelChanged(); }
		}

		public void OnCurrentViewModelChanged()
		{
			CurrentViewModelChanged?.Invoke();
		}
    }
}
