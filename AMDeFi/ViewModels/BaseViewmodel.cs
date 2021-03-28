using System;
using System.Windows.Input;
using AMDeFi.Helpers;
using Xamarin.Forms;

namespace AMDeFi.ViewModels
{
    public class BaseViewmodel : NotifyObject
    {
        public INavigation Navigation => App.Current.MainPage.Navigation;
        //public INavigation NavigationService => App.Current.MainPage.Navigation;

        string _pageTitle;
        bool _isActionBarVisible;

        /// <summary>
        /// Get or set Page Title property
        /// </summary>
        /// <value>The page title.</value>
        public string PageTitle
        {
            get => _pageTitle;
            set
            {
                _pageTitle = value;
                OnPropertyChanged(nameof(PageTitle));
            }
        }

        /// <summary>
        /// Get or set action bar visibility
        /// </summary>
        /// <value><c>true</c> if is action bar visible; otherwise, <c>false</c>.</value>
        public bool IsActionBarVisible
        {
            get => _isActionBarVisible;
            set
            {
                _isActionBarVisible = value;
                OnPropertyChanged(nameof(IsActionBarVisible));
            }
        }
        bool _backArrowVisible;
        public bool BackArrowVisible
        {
            get => _backArrowVisible;
            set
            {
                _backArrowVisible = value;
                OnPropertyChanged(nameof(BackArrowVisible));
            }
        }

        bool _IconAMDeFiVisible;
        public bool IconAMDeFiVisible
        {
            get => _IconAMDeFiVisible;
            set
            {
                _IconAMDeFiVisible = value;
                OnPropertyChanged(nameof(IconAMDeFiVisible));
            }
        }

        ICommand _backArrowTapCommand;
        public ICommand BackArrowTapCommand
        {
            get => _backArrowTapCommand;
            set
            {
                _backArrowTapCommand = value;
                OnPropertyChanged(nameof(BackArrowTapCommand));
            }
        }
        string _adUnitId;
        public string AdUnitId
        {
            get => _adUnitId;
            set
            {
                _adUnitId = value;
                OnPropertyChanged(nameof(AdUnitId));
            }
        }

        public BaseViewmodel()
        {
            if (Device.RuntimePlatform == Device.iOS)
                AdUnitId = "ca-app-pub-7458872344977788/7779541926";
            else if (Device.RuntimePlatform == Device.Android)
                AdUnitId = "ca-app-pub-7458872344977788/8255497726";
            BackArrowTapCommand = new Command(() => NavigateToPreviousPage());
        }

        public async void NavigateToPreviousPage()
        {
            await Navigation.PopAsync(true);
        }

    }
}

