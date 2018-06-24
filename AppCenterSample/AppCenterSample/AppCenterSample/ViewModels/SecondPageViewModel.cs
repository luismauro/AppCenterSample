using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppCenterSample.ViewModels
{
	public class SecondPageViewModel : ViewModelBase
    {
        public SecondPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Second Page";
        }
    }
}
