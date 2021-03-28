using System;
using System.Collections.Generic;
using AMDeFi.Helpers;
using AMDeFi.ViewModels;
using Xamarin.Forms;

namespace AMDeFi.Views
{
    public partial class LandingPage
    {
        LandingViewModel viewmodel;
        View selectedView { get; set; }
        public LandingPage()
        {
            InitializeComponent();
            viewmodel = new LandingViewModel();
            viewmodel.SelectedViewIndex = Constants.HomeViewIndex;
            selectedView = HomeView;
            this.BindingContext = viewmodel;
        }


        protected override void OnAppearing()
        {

            if (viewmodel.SelectedViewIndex == Constants.WalletViewIndex)
                viewmodel.GetWalletList();
            else if(viewmodel.SelectedViewIndex == Constants.HomeViewIndex)
                viewmodel.GetMarketplaceList();
            else if (viewmodel.SelectedViewIndex == Constants.BorrowViewIndex)
                viewmodel.GetMyAssets();
            else if (viewmodel.SelectedViewIndex == Constants.LendViewIndex)
                viewmodel.GetMyAssets();

            base.OnAppearing();
        }



        void BorrowViewSelectedEvent(object sender, EventArgs e)
        {
            if (viewmodel.SelectedViewIndex == Constants.BorrowViewIndex) return;
            SetViewAnimationDirection(selectedView, BorrowView, false);
            selectedView = BorrowView;
            viewmodel.SelectedViewIndex = Constants.BorrowViewIndex;
            viewmodel.GetMyAssets();
        }
        void LendViewSelectedEvent(object sender, EventArgs e)
        {
            if (viewmodel.SelectedViewIndex == Constants.LendViewIndex) return;
            SetViewAnimationDirection(selectedView, LendView, false);
            selectedView = LendView;
            viewmodel.SelectedViewIndex = Constants.LendViewIndex;
            viewmodel.GetMyAssets();
        }
        void WalletViewSelectedEvent(object sender, EventArgs e)
        {
            if (viewmodel.SelectedViewIndex == Constants.WalletViewIndex) return;
            SetViewAnimationDirection(selectedView, WalletView, false);
            selectedView = WalletView;
            viewmodel.SelectedViewIndex = Constants.WalletViewIndex;
            viewmodel.GetWalletList();

        }
        void HomeViewSelectedEvent(object sender, EventArgs e)
        {
            if (viewmodel.SelectedViewIndex == Constants.HomeViewIndex) return;
            SetViewAnimationDirection(selectedView, HomeView, false);
            selectedView = HomeView;
            viewmodel.SelectedViewIndex = Constants.HomeViewIndex;
            viewmodel.GetMarketplaceList();
        }

        private void SetViewAnimationDirection(View firstView, View secondView, bool isLeftSwipe)
        {
            var firstViewStart = 0.0;
            var firstViewEnd = -Width;
            var secondViewStart = Width;
            var secondViewEnd = 0.0;
            if (isLeftSwipe)
            {
                // Animating the views from right to left.
                secondViewStart = firstViewEnd = 0;
                secondViewEnd = -Width;
                firstViewStart = Width;
            }
            else
            {
                // Animating the views from left to right.
                firstViewEnd = Width;
                secondViewStart = -Width;
            }
            // Invoking view animation
            PerformViewAnimation(firstView, firstViewStart, firstViewEnd);
            PerformViewAnimation(secondView, secondViewStart, secondViewEnd);
        }

        private void PerformViewAnimation(View view, double startValue, double endValue)
        {
            view.TranslationX = startValue;
            view.IsVisible = true;
            view.TranslateTo(endValue, 0, Constants.AnimationTime, Easing.CubicOut);
        }



    }
}
