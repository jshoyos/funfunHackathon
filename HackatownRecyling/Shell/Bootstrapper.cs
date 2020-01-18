using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using HackatownRecyling.ViewModels;
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
            return builder.Build();
        }
    }
}
