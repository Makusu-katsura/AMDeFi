using System;
using System.Collections.Generic;
using AMDeFi.Models;
using AMDeFi.ViewModels.WalletMenu;
using Xamarin.Forms;

namespace AMDeFi.Views.WalletMenu.HistoryDigitalAssets
{
    public partial class HistoryDigitalAssets : BasePage
    {
        HistoryDigitalAssetsViewModel viewModel;

        public HistoryDigitalAssets()
        {
            InitializeComponent();
            viewModel = new HistoryDigitalAssetsViewModel();
            this.BindingContext = viewModel;
        }
    }
}
