using Platform.Core;
using Platform.Datasource;
using Platform.Hardware;
using Platform.Ioc.Injection;
using Platform.Shared;
using Platform.Shared.Contract;
using Platform.Ui;

namespace Platform.Ioc
{
    public static class PlatformDependencies
    {
        public static void BuildDependencies()
        {
            //create container
            Injector.CreateContainer();

            //inject
            InjectDependencies();

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
        }
    }
}
