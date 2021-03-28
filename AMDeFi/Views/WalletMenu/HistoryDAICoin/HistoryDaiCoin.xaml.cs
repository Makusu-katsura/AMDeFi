using System;
using System.Collections.Generic;
using AMDeFi.Models;
using AMDeFi.ViewModels.WalletMenu;
using Xamarin.Forms;

namespace AMDeFi.Views.WalletMenu.HistoryDAICoin
{
    public partial class HistoryDaiCoin : BasePage
    {
        HistoryDAICoinViewModel viewModel;
        public HistoryDaiCoin()
        {
            InitializeComponent();
            viewModel = new HistoryDAICoinViewModel();
            this.BindingContext = viewModel;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.GetWellet();
        }
    }
}
