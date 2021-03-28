using System;
using System.Windows.Input;
using AMDeFi.Models.LenderModel;
using AMDeFi.Views.LendMenu;
using AMDeFi.Helpers;
using Xamarin.Forms;
namespace AMDeFi.ViewModels.LendMenu
{
    public class OurPromotionListViewModel:BaseViewmodel
    {
        ObservableRangeCollection<OurPromotionListModel> _OurPromotionList;
        public ObservableRangeCollection<OurPromotionListModel> OurPromotionList
        {
            get => _OurPromotionList;
            set
            {
                _OurPromotionList = value;
                OnPropertyChanged(nameof(OurPromotionList));
            }
        }
        public OurPromotionListViewModel()
        {

            IsActionBarVisible = true;
            PageTitle = "Our Promotion";
            BackArrowVisible = true;
            IconAMDeFiVisible = false;
            OurPromotionList = new ObservableRangeCollection<OurPromotionListModel>();
            OurPromotionList.Add(new OurPromotionListModel { Name = "Promo A", Value = "1,000,000" });
            OurPromotionList.Add(new OurPromotionListModel { Name = "Promo B", Value = "3,000,000" });

            OurPromotionListSelectCommand = new Command((param) => NavigateToOurPromotiontSelectCommand(param));
        }
        async private void NavigateToOurPromotiontSelectCommand(object param)
        {
            var selected = (OurPromotionListModel)param;
            if (selected != null)
            {
                //Console.WriteLine("NavigateToAssetsMarketSelectCommand");
                await Navigation.PushAsync(new OurPromotions());
            }
        }
        ICommand _OurPromotionListSelectCommand;
        public ICommand OurPromotionListSelectCommand
        {
            get => _OurPromotionListSelectCommand;
            set
            {
                _OurPromotionListSelectCommand = value;
                OnPropertyChanged(nameof(OurPromotionListSelectCommand));
            }
        }
    }
}
