using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MvvmLightSample.ViewModel
{
    public class PageFourViewModel
    {
        private INavigationService _navigationService;
        public ICommand GoBackCommand { get; set; }


        public PageFourViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            GoBackCommand = new RelayCommand(GoBack);
        }

        private void GoBack()
        {
            _navigationService.GoBack();
        }
    }
}
