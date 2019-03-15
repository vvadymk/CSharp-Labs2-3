using KochmarLabs2_3.Tools;
using KochmarLabs2_3.Tools.Managers;

namespace KochmarLabs2_3.ViewModels
{
    class ResultsViewModel : BaseViewModel
    {
        public string FirstName => StationManager.CurrentUser.FirstName;

        public string LastName => StationManager.CurrentUser.LastName;

        public string Email => StationManager.CurrentUser.Email;

        public bool IsAdult => StationManager.CurrentUser.IsAdult;

        public string WesternZodiac => StationManager.CurrentUser.WesternZodiac;

        public string ChineseZodiac => StationManager.CurrentUser.ChineseZodiac;

        public bool IsBirthday => StationManager.CurrentUser.IsBirthday;
    }
}
