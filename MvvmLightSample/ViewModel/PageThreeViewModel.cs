using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MvvmLightSample.ViewModel
{
    public class PageThreeViewModel
    {
        private INavigationService _navigationService;
        public ICommand GoBackCommand { get; set; }
        public ICommand GoToNextCommand { get; set; }

        public PageThreeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            GoBackCommand = new RelayCommand(GoBack);
            GoToNextCommand = new RelayCommand(GotoNext);
        }

        private void GoBack()
        {
            _navigationService.GoBack();
        }
        private void GotoNext()
        {
            var navigationService = ServiceLocator.Current.GetInstance<INavigationService>();
            navigationService.NavigateTo("PageTwo4");
        }
    }
}
