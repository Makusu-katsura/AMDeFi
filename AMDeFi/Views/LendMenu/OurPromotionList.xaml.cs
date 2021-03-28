using System;
using System.Collections.Generic;
using AMDeFi.Models;
using AMDeFi.ViewModels.LendMenu;
using Xamarin.Forms;
using AMDeFi.Views.LendMenu;


namespace AMDeFi.Views.LendMenu
{
    public partial class OurPromotionList : BasePage
    {
        OurPromotionListViewModel viewModel;
        public OurPromotionList()
        {
            InitializeComponent();
            viewModel =new OurPromotionListViewModel();
            this.BindingContext = viewModel;
        }

        async void NavigateAddPromotion(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddPromotion());
        }
    }
}
