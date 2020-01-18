using Prism.Commands;
using System;
using System.Collections.ObjectModel;

namespace HackatownRecyling.ViewModels
{
    public class ResultsViewModel
    {
        public ResultsViewModel()
        {
            RegisterCommands();
        }

        public DelegateCommand<int> FirstChoiceCommand { get; private set; }
        public DelegateCommand<int> SecondChoiceCommand { get; private set; }
        public DelegateCommand<int> ThirdChoiceCommand { get; private set; }

        private void RegisterCommands()
        {
            FirstChoiceCommand = new DelegateCommand<int>(ChoiceCommandExecute, ChoiceCommandCanExecute);
            SecondChoiceCommand = new DelegateCommand<int>(ChoiceCommandExecute, ChoiceCommandCanExecute);
            ThirdChoiceCommand = new DelegateCommand<int>(ChoiceCommandExecute, ChoiceCommandCanExecute);
        }

        private bool ChoiceCommandCanExecute(int choiceIndex)
        {
            throw new NotImplementedException();
        }

        private void ChoiceCommandExecute(int choiceIndex)
        {
            throw new NotImplementedException();
        }
    }
}
