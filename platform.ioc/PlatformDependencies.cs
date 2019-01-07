using Platform.Core;
using Platform.Datasource;
using Platform.Datasource.Repository;
using Platform.Hardware;
using Platform.Ioc.Injection;
using Platform.Shared;
using Platform.Shared.Contract;
using Platform.Ui;
using System;
using System.Threading.Tasks;

namespace Platform.Ioc
{
    public static class PlatformDependencies
    {
        public static void BuildDependencies(Action externalDependencies = null)
        {
            //create container
            Injector.CreateContainer();

            //inject
            InjectDependencies();

            //inject external dependencies
            externalDependencies.Invoke();

            //build container
            Injector.BuildContainer();
        }

        private static void InjectDependencies()
        {
            //platform
            Injector.RegisterType<PlatformDatasource, IPlatformDatasource>();
            Injector.RegisterType<PlatformCore, IPlatformCore>();
            Injector.RegisterType<PlatformShared, IPlatformShared>();
            Injector.RegisterType<PlatformUi, IPlatformUi>();
            Injector.RegisterType<PlatformHardware, IPlatformHardware>();

            //database
            Injector.RegisterType<PlatformDatabase, IPlatformDatabase>();            
        }
    }
}
