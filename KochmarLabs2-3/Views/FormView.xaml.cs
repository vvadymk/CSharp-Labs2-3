using System.Windows.Controls;
using KochmarLabs2_3.Tools.Navigation;
using KochmarLabs2_3.ViewModels;

namespace KochmarLabs2_3.Views
{
    /// <summary>
    /// Логика взаимодействия для FormView.xaml
    /// </summary>
    public partial class FormView : UserControl, INavigatable
    {
        public FormView()
        {
            InitializeComponent();
            DataContext = new FormViewModel();
        }
    }
}
