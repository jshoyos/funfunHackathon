using HackatownRecyling.ViewModels;
using System.Windows;

namespace HackatownRecyling.Views
{
    /// <summary>
    /// Interaction logic for ResultsView.xaml
    /// </summary>
    public partial class ResultsView : Window
    {
        public ResultsView(ResultsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
