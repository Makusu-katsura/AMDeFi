using System;

using Xamarin.Forms;

namespace AMDeFi.ViewModels.LendMenu
{
    public class AddPromotionViewModel : BaseViewmodel
    {
        public AddPromotionViewModel()
        {
            IsActionBarVisible = true;
            PageTitle = "Lending Criteria";
            BackArrowVisible = true;
            IconAMDeFiVisible = false;
        }
    }
}

