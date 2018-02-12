using System;
using System.Collections.Generic;
using System.Text;
using DroidVersionGuide.Entity;
using Prism.Navigation;

namespace DroidVersionGuide.ViewModels
{
    class DetailPageViewModel : ViewModelBase
    {
        private DroidVersion _version;
        public DroidVersion Version
        {
            get { return _version; }
            set { SetProperty(ref _version, value); }
        }

        public DetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("codeName"))
            {
                Version = (DroidVersion)parameters["codeName"];
            }
        }
    }
}
