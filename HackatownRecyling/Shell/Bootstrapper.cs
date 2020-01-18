using Autofac;
using HackatownRecyling.Interfaces;
using HackatownRecyling.Services;
using HackatownRecyling.ViewModels;
using HackatownRecyling.Views;
using Prism.Events;

namespace HackatownRecyling.Shell
{
    public class Bootstrapper
    {
        internal IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();

            #region services
            builder.RegisterType<WindowService>().As<IWindowService>().SingleInstance();
            builder.RegisterType<ResultsView>().AsSelf();
            #endregion

            return builder.Build();
        }
    }
}
