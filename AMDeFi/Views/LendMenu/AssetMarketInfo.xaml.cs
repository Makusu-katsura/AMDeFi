using System;
using System.Collections.Generic;
using AMDeFi.Models;
using AMDeFi.Models.HomeModel;
using AMDeFi.ViewModels.LendMenu;
using AMDeFi.Views.CustomViews;
using Xamarin.Forms;
namespace AMDeFi.Views.LendMenu
{
    public partial class AssetMarketInfo : BasePage
    {
        AssetMarketInfoViewModel viewmodel;
        public AssetMarketInfo()
        {
            InitializeComponent();
            viewmodel = new AssetMarketInfoViewModel();
            this.BindingContext = viewmodel;
        }

        async void SubmitBuy(System.Object sender, System.EventArgs e)
        {
            //if buy success
            await Navigation.PopToRootAsync();
        }
    }
}
