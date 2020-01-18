using HackatownRecyling.Interfaces;
using Prism.Commands;

namespace HackatownRecyling.ViewModels
{
    public class MainViewModel : IViewModel
    {
        private readonly IWindowService _windowService;

        public DelegateCommand UploadCommand { get; private set; }
        public DelegateCommand LiveCameraCommand { get; private set; }

        public MainViewModel(IWindowService windowService)
        {
            _windowService = windowService;
            RegisterCommands();
        }
        public void RegisterCommands()
        {
            UploadCommand=new DelegateCommand(UploadCommandExecute, UploadCanExecute);
            LiveCameraCommand = new DelegateCommand(LiveCameraCommandExecute, LiveCameraCanExecute);
        }

        private bool LiveCameraCanExecute()
        {
            return true;
        }

        private void LiveCameraCommandExecute()
        {
            _windowService.ShowLiveCameraView();
        }

        private bool UploadCanExecute()
        {
            return true;
        }

        private void UploadCommandExecute()
        {
            var fileName =_windowService.ShowFileDialog();
            if (!string.IsNullOrEmpty(fileName))
            { 
                _windowService.ShowResultView(fileName);
            }
        }
    }
}
