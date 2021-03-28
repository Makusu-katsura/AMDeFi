using System;
using System.Collections.Generic;
using AMDeFi.Models;
using AMDeFi.ViewModels.LendMenu;
using Xamarin.Forms;
using AMDeFi.Views.LendMenu;
namespace AMDeFi.Views.CustomViews
{
    public partial class LendView : ContentView
    {
        LenderViewModel viewmodel;

        public LendView()
        {
            InitializeComponent();
            viewmodel = new LenderViewModel();
            this.BindingContext = viewmodel;

            ControlAssets.BackgroundColor = Color.FromHex("#DD7C11");
            ControlPromotion.BackgroundColor = Color.FromHex("#FFFFFF");
            ControlAssetsText.TextColor = Color.FromHex("#FFFFFF");
            ControlPromotionText.TextColor = Color.FromHex("#A9A6A6");
            AssetsOwn.IsVisible = true;
            OurPromotion.IsVisible = false;
        }

        async void NavigateOurPromotion(System.Object sender, System.EventArgs e)
        {
            AssetsOwn.IsVisible = false;
            OurPromotion.IsVisible = true;
            ControlAssets.BackgroundColor = Color.FromHex("#FFFFFF");
            ControlPromotion.BackgroundColor = Color.FromHex("#DD7C11");

            ControlAssetsText.TextColor = Color.FromHex("#A9A6A6");
            ControlPromotionText.TextColor = Color.FromHex("#FFFFFF");
            //await Navigation.PushAsync(new OurPromotionList());
        }
        async void NavigateAssetsOwn(System.Object sender, System.EventArgs e)
        {
            AssetsOwn.IsVisible = true;
            OurPromotion.IsVisible = false;
            ControlAssets.BackgroundColor = Color.FromHex("#DD7C11");
            ControlPromotion.BackgroundColor = Color.FromHex("#FFFFFF");

            ControlAssetsText.TextColor = Color.FromHex("#FFFFFF");
            ControlPromotionText.TextColor = Color.FromHex("#A9A6A6");
        }

        async void NaviagateAssetsMarket(System.Object sender, System.EventArgs e)
        {
            //Console.WriteLine("he");
            await Navigation.PushAsync(new AssetsMarket());
        }
        async void NavigateAddPromotion(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddPromotion());
        }
    }
}
