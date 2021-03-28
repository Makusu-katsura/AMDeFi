using System;
using System.Collections.Generic;
using AMDeFi.ViewModels.LendMenu;
using Xamarin.Forms;

namespace AMDeFi.Views.LendMenu
{
    public partial class AddPromotion : BasePage
    {
        AddPromotionViewModel viewModel;
        public AddPromotion()
        {
            InitializeComponent();
            viewModel = new AddPromotionViewModel();
            this.BindingContext = viewModel;
        }

       async void SubmitLendingCriteria(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
