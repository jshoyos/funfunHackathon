using Autofac;
using HackatownRecyling.Interfaces;
using HackatownRecyling.Views;
using Microsoft.Win32;

namespace HackatownRecyling.Services
{
    internal class WindowService : IWindowService
    {
        private readonly LiveCameraView _liveCameraView;
        private readonly ResultsView _resultsView;

        public WindowService(ILifetimeScope scope)
        {
            _liveCameraView = scope.Resolve<LiveCameraView>();
            _resultsView = scope.Resolve<ResultsView>();
        }

        public void ShowFileDialog()
        {
            var dialog = new OpenFileDialog();
            dialog.ShowDialog();
        }

        public void ShowResultView()
        {
            _resultsView.Show();
        }

        public void ShowLiveCameraView()
        {
            _liveCameraView.Show();
        }
    }
}
