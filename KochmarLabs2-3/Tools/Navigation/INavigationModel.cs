namespace KochmarLabs2_3.Tools.Navigation
{
    internal enum ViewType
    {
        FormInput,
        ShowResults
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}
