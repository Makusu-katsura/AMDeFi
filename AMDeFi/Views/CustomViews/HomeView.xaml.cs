using System;
using System.Collections.Generic;
using AMDeFi.ViewModels.HomeMenu;
using Xamarin.Forms;

namespace AMDeFi.Views.CustomViews
{
    public partial class HomeView : ContentView
    {
        HomeViewmodel viewmodel;
        public HomeView()
        {
            InitializeComponent();
            //CaseListView.ItemTapped += (sender, e) => CaseListView.SelectedItem = null;
            //viewmodel = new HomeViewmodel();
            //this.BindingContext = viewmodel;
        }

    }
}
