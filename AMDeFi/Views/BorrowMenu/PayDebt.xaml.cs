using System;
using System.Collections.Generic;
using AMDeFi.Models;
using AMDeFi.ViewModels.BorrowMenu;
using Xamarin.Forms;
using AMDeFi.Views.LendMenu;


namespace AMDeFi.Views.BorrowMenu
{
    public partial class PayDebt : BasePage
    {
        PayDebtViewModel viewModel;
        public PayDebt()
        {
            InitializeComponent();
            viewModel = new PayDebtViewModel();
            this.BindingContext = viewModel;
        }

        async void PaySuccess(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
