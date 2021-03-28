using System;
using System.Collections.Generic;
using AMDeFi.Helpers;
using System.Windows.Input;
using AMDeFi.Models;
using Xamarin.Forms;
using AMDeFi.ViewModels.WalletMenu;
using AMDeFi.Views.WalletMenu.HistoryDAICoin;
using AMDeFi.Views.WalletMenu.HistoryDigitalAssets;

namespace AMDeFi.Views.CustomViews
{
    public partial class WalletView :ContentView
    {
        HistoryDAICoinViewModel viewmodel;
        public WalletView()
        {
            InitializeComponent();
            //viewmodel = new HistoryDAICoinViewModel();
            //this.BindingContext = viewmodel;
        }

        async void NavigateWalletPage(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new HistoryDaiCoin());

        }

        async void NavigateDigitalAssetsPage(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new HistoryDigitalAssets());
            //Console.WriteLine("navigate");
        }


    }
 
}
