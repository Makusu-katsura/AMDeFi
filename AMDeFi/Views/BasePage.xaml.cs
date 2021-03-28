using System;
using System.Collections.Generic;
using AMDeFi.ViewModels;
using Xamarin.Forms;

namespace AMDeFi.Views
{
    public partial class BasePage : ContentPage
    {
        #region Bindable Properties
        public static readonly BindableProperty DetailViewProperty =
            BindableProperty.Create(nameof(DetailView), typeof(View), typeof(BasePage), null);
        #endregion

        BaseViewmodel viewmodel;

        /// <summary>
        /// Get or set detail view session
        /// </summary>
        /// <value>The detail view.</value>
        public View DetailView
        {
            get { return (View)GetValue(DetailViewProperty); }
            set { SetValue(DetailViewProperty, value); }
        }

        public BasePage()
        {
            InitializeComponent();
            this.BindingContext = viewmodel;
        }
    }
}
