using Autofac;
using HackatownRecyling.Interfaces;
using HackatownRecyling.Views;
using Microsoft.Win32;

namespace HackatownRecyling.Services
{
    internal class WindowService : IWindowService
    {
        private readonly ILifetimeScope _lifetimeScope;

        public WindowService(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        public string ShowFileDialog()
        {
            string fileName = null;
            var dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();

            if(result == true)
            {
                fileName = dialog.FileName;
            }

            return fileName;
        }

        public void ShowResultView()
        {
            var view = _lifetimeScope.Resolve<ResultsView>();
            view.Show();
        }

        public void ShowLiveCameraView()
        {
            var view = _lifetimeScope.Resolve<LiveCameraView>();
            view.Show();
        }
    }
}
