using Autofac;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Region;

namespace WpfApp1
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        private IContainer _container;

        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ContainerBuilder();
            ConfigureContainer(builder);
            _container = builder.Build();

            var mainWindow = _container.Resolve<MainWindow>(new TypedParameter(typeof(IContainer), _container));
            mainWindow.Show();

            base.OnStartup(e);
        }

        private void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterType<MainWindow>().SingleInstance();
            builder.RegisterType<TopViewModel>().InstancePerDependency();
            builder.RegisterType<TopView>().InstancePerDependency();
        }
    }
}
