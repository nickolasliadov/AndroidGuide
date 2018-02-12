using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using DroidVersionGuide.Entity;
using DroidVersionGuide.Service;
using System.Collections.Generic;
using DroidVersionGuide.Repository;
using System.Collections.ObjectModel;

namespace DroidVersionGuide.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand<DroidVersion> NavigateToDetailPageCommand { get; private set; }
      
        public ObservableCollection<DroidVersion> Versions { get; set; }

        public MainPageViewModel(INavigationService navigationService,  IService service) 
            : base (navigationService)
        {           
            Title = "Droid Versions Guide";          
            NavigateToDetailPageCommand = new DelegateCommand<DroidVersion>(NavigateToDetailPage);
            Versions = new ObservableCollection<DroidVersion>(service.GetVersionsAndroid());
        }
        private void NavigateToDetailPage(DroidVersion version)
        {
            var parameter = new NavigationParameters
            {
                { "codeName", version }
            };
            NavigationService.NavigateAsync("DetailPage", parameter);
        }
    }
}
