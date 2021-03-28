using System;
using System.Collections.Generic;
using AMDeFi.Models;
using AMDeFi.ViewModels.LendMenu;
using Xamarin.Forms;


namespace AMDeFi.Views.LendMenu
{
    public partial class AssetsOwn : BasePage
    {
        AssetsOwnViewModel viewModel;
        public AssetsOwn()
        {
            InitializeComponent();
            viewModel = new AssetsOwnViewModel();
            this.BindingContext = viewModel;

        }

       async void SellSubmit(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
