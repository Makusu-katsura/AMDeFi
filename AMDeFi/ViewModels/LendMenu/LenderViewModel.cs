using System;
using System.Windows.Input;
using AMDeFi.Models.LenderModel;
using AMDeFi.Views.LendMenu;
using AMDeFi.Helpers;
using Xamarin.Forms;
namespace AMDeFi.ViewModels.LendMenu
{
    public class LenderViewModel:BaseViewmodel
    {
        ObservableRangeCollection<OwnAssetsList> _OwnAssetlist;
        public ObservableRangeCollection<OwnAssetsList> OwnAssetlist
        {
            get => _OwnAssetlist;
            set
            {
                _OwnAssetlist = value;
                OnPropertyChanged(nameof(OwnAssetlist));
            }
        }

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
        public LenderViewModel()
        {
            OwnAssetlist = new ObservableRangeCollection<OwnAssetsList>();
            OwnAssetlist.Add(new OwnAssetsList { AssetsName = "Asset A", Value = "1,000,000" });
            OwnAssetlist.Add(new OwnAssetsList { AssetsName = "Asset B", Value = "2,000,000" });
            OwnAssetlist.Add(new OwnAssetsList { AssetsName = "Asset C", Value = "3,000,000" });
            OwnAssetlist.Add(new OwnAssetsList { AssetsName = "Asset D", Value = "4,000,000" });

            OwnAssestSelectCommand = new Command((param) => NavigateToOwnAssetstSelectCommand(param));

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

        async private void NavigateToOwnAssetstSelectCommand(object param)
        {

            var selected = (OwnAssetsList)param;
            if (selected != null)
            {
                //Console.WriteLine("NavigateToAssetsMarketSelectCommand");
                await Navigation.PushAsync(new AssetsOwn());
            }
        }
        ICommand _OwnAssestSelectCommand;
        public ICommand OwnAssestSelectCommand
        {
            get => _OwnAssestSelectCommand;
            set
            {
                _OwnAssestSelectCommand = value;
                OnPropertyChanged(nameof(OwnAssestSelectCommand));
            }
        }
    }
}
