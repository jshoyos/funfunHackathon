using Autofac;
using HackatownRecyling.Common;
using HackatownRecyling.Interfaces;
using HackatownRecyling.Views;
using Microsoft.Win32;
using Prism.Events;

namespace HackatownRecyling.Services
{
    internal class WindowService : IWindowService
    {
        private readonly ILifetimeScope _lifetimeScope;
        private readonly IEventAggregator _eventAggregator;

        public WindowService(ILifetimeScope lifetimeScope, IEventAggregator eventAggregator)
        {
            _lifetimeScope = lifetimeScope;
            _eventAggregator = eventAggregator;
        }

        public string ShowFileDialog()
        {
            string fileName = null;
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.PNG;*.JPG)|*.PNG;*.JPG";
            var result = dialog.ShowDialog();

            if(result == true)
            {
                fileName = dialog.FileName;
            }

            return fileName;
        }

        public void ShowResultView(string fileName)
        {
            var view = _lifetimeScope.Resolve<ResultsView>();
            view.LoadImage(fileName);
            //_eventAggregator.GetEvent<ImageLoadedByUserEvent>().Publish(fileName);
            view.Show();
        }

        public void ShowLiveCameraView()
        {
            var view = _lifetimeScope.Resolve<LiveCameraView>();
            view.Show();
        }
    }
}
