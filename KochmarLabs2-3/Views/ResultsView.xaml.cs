using System.Windows.Controls;
using KochmarLabs2_3.Tools.Navigation;
using KochmarLabs2_3.ViewModels;

namespace KochmarLabs2_3.Views
{
    /// <summary>
    /// Логика взаимодействия для ResultsView.xaml
    /// </summary>
    public partial class ResultsView : UserControl, INavigatable
    {
        public ResultsView()
        {
            InitializeComponent();
            DataContext = new ResultsViewModel();
        }
    }
}
