using System;
using KochmarLabs2_3.Views;

namespace KochmarLabs2_3.Tools.Navigation
{
    internal class InitializationNavigationModel : BaseNavigationModel
    {
        public InitializationNavigationModel(IContentOwner contentOwner) : base(contentOwner)
        {

        }

        protected override void InitializeView(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.FormInput:
                    ViewsDictionary.Add(viewType, new FormView());;
                    break;
                case ViewType.ShowResults:
                    ViewsDictionary.Add(viewType, new ResultsView());
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(viewType), viewType, null);
            }
        }
    }
}
