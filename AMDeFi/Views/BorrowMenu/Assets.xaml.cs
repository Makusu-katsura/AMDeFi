using System;
using System.Collections.Generic;
using AMDeFi.Models;
using AMDeFi.ViewModels.BorrowMenu;
using AMDeFi.Views.BorrowMenu;
using Xamarin.Forms;

namespace AMDeFi.Views.BorrowMenu
{
    public partial class Assets : BasePage
    {
        AssetsViewModel viewmodel;
        public Assets( )
        {
            InitializeComponent();
            viewmodel = new AssetsViewModel();
            this.BindingContext = viewmodel;
        }

        async void Approve_Status(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        async void SubmitPayDept(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PayDebt());

        }
    }
}
