using System;
using System.Collections.Generic;
using AMDeFi.Models;
using AMDeFi.ViewModels.BorrowMenu;
using Xamarin.Forms;
namespace AMDeFi.Views.BorrowMenu
{
    public partial class AddAssets : BasePage
    {
        AddAssetsViewModel viewModel;
        public AddAssets()
        {
            InitializeComponent();
            viewModel = new AddAssetsViewModel();
            //CaseList.ItemTapped += (sender, e) => CaseList.SelectedItem = null;
            this.BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        async void SubmitAssetsForm(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}

