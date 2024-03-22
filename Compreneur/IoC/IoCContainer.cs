using Autofac;
using Compreneur.Models;
using Compreneur.Service;
using Compreneur.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compreneur.IoC
{
    internal class IoCContainer
    {
        public static IContainer Current { get; set; }
        static IoCContainer()
        {
            var builder = new ContainerBuilder();

            // Services
            builder.RegisterType<CheckCompanyExistsService>().SingleInstance();
            builder.RegisterType<LoadCompanyService>().SingleInstance();
            builder.RegisterType<LoadLocationService>().SingleInstance();
            builder.RegisterType<CreateLocationService>().SingleInstance();
            builder.RegisterType<LoadBusinessUnitsService>().SingleInstance();
            builder.RegisterType<CreateBusinessUnitService>().SingleInstance();
            builder.RegisterType<LoadBuildingService>().SingleInstance();
            builder.RegisterType<Navigation>().SingleInstance();

            // VMs
            builder.RegisterType<MainWindowViewModel>().SingleInstance();
            builder.RegisterType<StartViewModel>().SingleInstance();
            builder.RegisterType<LoadCompanyViewModel>().SingleInstance();
            builder.RegisterType<CreateCompanyViewModel>().SingleInstance();
            builder.RegisterType<MainViewModel>().SingleInstance();

            Current = builder.Build();
        }
    }
}
