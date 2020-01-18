using HackatownRecyling.Common;
using HackatownRecyling.Models;
using Prism.Commands;
using Prism.Events;
using System;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace HackatownRecyling.ViewModels
{
    public class ResultsViewModel : BindableBase, IDisposable
    {
        private BitmapSource _imageSource;
        private readonly IEventAggregator _eventAggregator;

        public ResultsViewModel(IEventAggregator eventAggregator)
        {
            RegisterCommands();
            
            //eventAggregator.GetEvent<ImageLoadFromUserEvent>

            //todo: remove this, this is only for testing
            FirstChoice = new ResultChoiceModel() { Name = "Cardboard", Score = 0.9 };
            SecondChoice = new ResultChoiceModel() { Name = "Glass", Score = 0.8 };
            ThirdChoice = new ResultChoiceModel() { Name = "Trash", Score = 0.6 };
            _eventAggregator = eventAggregator;
            //_eventAggregator.GetEvent<ImageLoadedByUserEvent>().Subscribe(ShowImage);
        }

        public ICommand FirstChoiceCommand { get; private set; }
        public ICommand SecondChoiceCommand { get; private set; }
        public ICommand ThirdChoiceCommand { get; private set; }
        public ResultChoiceModel FirstChoice { get; private set; }
        public ResultChoiceModel SecondChoice { get; private set; }
        public ResultChoiceModel ThirdChoice { get; private set; }
        public BitmapSource ImageSource 
        {
            get
            {
                return _imageSource;
            }
            private set
            {
                _imageSource = value;
                OnPropertyChanged();
            }
        }

        private void RegisterCommands()
        {
            FirstChoiceCommand = new DelegateCommand<int?>(ChoiceCommandExecute, ChoiceCommandCanExecute);
            SecondChoiceCommand = new DelegateCommand<int?>(ChoiceCommandExecute, ChoiceCommandCanExecute);
            ThirdChoiceCommand = new DelegateCommand<int?>(ChoiceCommandExecute, ChoiceCommandCanExecute);
        }

        private bool ChoiceCommandCanExecute(int? choiceIndex)
        {
            return true;
        }

        private void ChoiceCommandExecute(int? choiceIndex)
        {

        }

        public void ShowImage(string fileName)
        {
            ImageSource = new BitmapImage(new Uri(fileName));
        }

        public void Dispose()
        {
            
        }
    }
}
