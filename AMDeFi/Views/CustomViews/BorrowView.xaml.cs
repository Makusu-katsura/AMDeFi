using System;
using System.Collections.Generic;
using AMDeFi.Models;
using AMDeFi.ViewModels.BorrowMenu;
using AMDeFi.Views.BorrowMenu;
using Xamarin.Forms;

namespace AMDeFi.Views.CustomViews
{
    public partial class BorrowView : ContentView
    {
        BurrowerViewmodel viewmodel;
        public BorrowView()
        {
            InitializeComponent();
            //viewmodel = new BurrowerViewmodel();
            //this.BindingContext = viewmodel;
        }

        async void NavigateAddAssets(System.Object sender, System.EventArgs e)
        {
            //Console.WriteLine("==>hel");
            await Navigation.PushAsync(new AddAssets());
        }


    }
}
