using System;
using System.Collections.Generic;
using AMDeFi.Models;
using AMDeFi.ViewModels.WalletMenu;
using Xamarin.Forms;

namespace AMDeFi.Views.WalletMenu.HistoryDAICoin
{
    public partial class DAICoinInfo : BasePage
    {
        DAICoinInfoViewModel viewModel;
        public DAICoinInfo()
        {
            InitializeComponent();
            viewModel = new DAICoinInfoViewModel();
            this.BindingContext = viewModel;
        }

        async void OnSubmitSell(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
