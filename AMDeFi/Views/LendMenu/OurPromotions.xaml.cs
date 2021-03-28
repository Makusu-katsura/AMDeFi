using System;
using System.Collections.Generic;
using AMDeFi.Models;
using AMDeFi.ViewModels.LendMenu;
using Xamarin.Forms;

namespace AMDeFi.Views.LendMenu
{
    public partial class OurPromotions : BasePage
    {
        OurPromotionsViewModel viewModel;
        public OurPromotions()
        {
            InitializeComponent();
            viewModel = new OurPromotionsViewModel();
            this.BindingContext = viewModel;
        }
    }
}
