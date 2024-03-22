﻿using Autofac;
using Compreneur.IoC;
using Compreneur.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Compreneur.Views
{
    /// <summary>
    /// Interaktionslogik für StartView.xaml
    /// </summary>
    public partial class StartView : UserControl
    {
        public StartView()
        {
            InitializeComponent();
            IoCContainer.Current.Resolve<StartViewModel>();
        }
    }
}
