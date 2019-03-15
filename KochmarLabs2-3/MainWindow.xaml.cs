using System.Windows;
using System.Windows.Controls;
using KochmarLabs2_3.Tools.Managers;
using KochmarLabs2_3.Tools.Navigation;
using KochmarLabs2_3.ViewModels;

namespace KochmarLabs2_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IContentOwner
    {
      
        public ContentControl ContentControl
        {
            get { return _contentControl; }
        }


        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            NavigationManager.Instance.Initialize(new InitializationNavigationModel(this));
            NavigationManager.Instance.Navigate(ViewType.FormInput);
        }
    
    }
}
