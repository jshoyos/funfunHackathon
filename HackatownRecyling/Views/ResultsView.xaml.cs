using HackatownRecyling.ViewModels;
using System;
using System.Windows;

namespace HackatownRecyling.Views
{
    /// <summary>
    /// Interaction logic for ResultsView.xaml
    /// </summary>
    public partial class ResultsView : Window
    {
        private readonly ResultsViewModel _viewModel;

        public ResultsView(ResultsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
            _viewModel = viewModel;
        }

        internal void LoadImage(string fileName)
        {
            _viewModel.ShowImage(fileName);
        }
    }
}
