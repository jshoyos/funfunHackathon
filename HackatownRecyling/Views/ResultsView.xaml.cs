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
            Closed += ResultsView_Closed;
        }

        private void ResultsView_Closed(object sender, EventArgs e)
        {
            _viewModel.Dispose();
        }

        internal void LoadImage(string fileName)
        {
            _viewModel.ShowImage(fileName);
        }
    }
}
