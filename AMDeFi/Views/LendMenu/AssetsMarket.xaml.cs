using System;
using System.Collections.Generic;
using AMDeFi.Models;
using AMDeFi.ViewModels.LendMenu;
using Xamarin.Forms;


namespace AMDeFi.Views.LendMenu
{
    public partial class AssetsMarket : BasePage
    {
        AssetsMarketViewModel viewModel;

        public AssetsMarket()
        {
            InitializeComponent();
            viewModel = new AssetsMarketViewModel();
            this.BindingContext = viewModel;
        }

    }
}
