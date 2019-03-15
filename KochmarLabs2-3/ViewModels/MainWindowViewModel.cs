using KochmarLabs2_3.Tools;

namespace KochmarLabs2_3.ViewModels
{
    class MainWindowViewModel:BaseViewModel
    {
        private bool _isControlEnabled = true;

        public bool IsControlEnabled
        {
            get { return _isControlEnabled; }
            set
            {
                _isControlEnabled = value;
                OnPropertyChanged();
            }
        }
    
    }
}
