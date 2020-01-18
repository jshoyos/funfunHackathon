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
            //todo: replace ClassificationMockService by ClassificationService
            builder.RegisterType<ClassificationMockService>().As<IClassificationService>().SingleInstance();
            #endregion

            builder.RegisterType<ResultsViewModel>().AsSelf();
            builder.RegisterType<ResultsView>().AsSelf();

            builder.RegisterType<LiveCameraViewModel>().AsSelf();
            builder.RegisterType<LiveCameraView>().AsSelf();

            return builder.Build();
        }
    }
}
