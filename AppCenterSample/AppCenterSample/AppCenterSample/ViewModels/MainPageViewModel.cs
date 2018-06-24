using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCenterSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand SecondPage { get; set; }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            this.SecondPage = new DelegateCommand(() =>
           {
               try
               {
                   Analytics.TrackEvent("Abriu segunda página");
                   Crashes.GenerateTestCrash();
                   NavigationService.NavigateAsync("NavigationPage/SecondPage");                  
               }
               catch (Exception e)
               {
                   Crashes.TrackError(e);
               }

           });
        }
    }
}
