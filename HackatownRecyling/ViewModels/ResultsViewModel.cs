using HackatownRecyling.Common;
using Prism.Commands;
using System.Windows.Input;

namespace HackatownRecyling.ViewModels
{
    public class ResultsViewModel : BindableBase
    {
        private string _firstChoiceText;
        public ResultsViewModel()
        {
            RegisterCommands();
        }

        public ICommand FirstChoiceCommand { get; private set; }
        public ICommand SecondChoiceCommand { get; private set; }
        public ICommand ThirdChoiceCommand { get; private set; }
        public string FirstChoiceText
        {
            get => _firstChoiceText;
            set
            {
                if(_firstChoiceText != value)
                {
                    _firstChoiceText = value;
                    OnPropertyChanged();
                }
            }
        }

        public string SecondChoiceText
        {
            get => _firstChoiceText;
            set
            {
                if (_firstChoiceText != value)
                {
                    _firstChoiceText = value;
                    OnPropertyChanged();
                }
            }
        }

        public string ThirdChoiceText
        {
            get => _firstChoiceText;
            set
            {
                if (_firstChoiceText != value)
                {
                    _firstChoiceText = value;
                    OnPropertyChanged();
                }
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
    }
}
