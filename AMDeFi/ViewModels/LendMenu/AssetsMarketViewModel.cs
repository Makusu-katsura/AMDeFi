using System;
using System.Windows.Input;
using AMDeFi.Models.LenderModel;
using AMDeFi.Views.LendMenu;
using AMDeFi.Helpers;
using Xamarin.Forms;
using AMDeFi.Models.HomeModel;
using System.Threading.Tasks;
using AMDeFi.Api;

namespace AMDeFi.ViewModels.LendMenu
{
    public class AssetsMarketViewModel:BaseViewmodel
    {
        ObservableRangeCollection<AssetInfo> _marketAssetsLists;
        public ObservableRangeCollection<AssetInfo> marketAssetsLists
        {
            get => _marketAssetsLists;
            set
            {
                _marketAssetsLists = value;
                OnPropertyChanged(nameof(marketAssetsLists));
            }
        }
        HomeModel _homeModelList;
        public HomeModel HomeModelList
        {
            get => _homeModelList;
            set
            {
                _homeModelList = value;
                OnPropertyChanged(nameof(HomeModelList));
            }
        }
        public AssetsMarketViewModel()
        {
            IsActionBarVisible = true;
            PageTitle = "Digital Assets Market Place";
            BackArrowVisible = true;
            IconAMDeFiVisible = false;
            marketAssetsLists = new ObservableRangeCollection<AssetInfo>();

            LandingViewModel landing = new LandingViewModel();
            GetMarketplaceAllList();
            //marketAssetsLists.Add(new HomeModel { AssetsName = "Home A", Allvalue = "100,000", Balance = "20,000" });
            //marketAssetsLists.Add(new HomeModel { AssetsName = "Condo B", Allvalue = "100,000", Balance = "20,000" });
            //marketAssetsLists.Add(new HomeModel { AssetsName = "Car C", Allvalue = "100,000", Balance = "20,000" });
            //marketAssetsLists.Add(new HomeModel { AssetsName = "Youtube Chanel D", Allvalue = "100,000", Balance = "20,000" });
            //marketAssetsLists.Add(new HomeModel { AssetsName = "Home A", Allvalue = "100,000", Balance = "20,000" });
            //marketAssetsLists.Add(new HomeModel { AssetsName = "Condo B", Allvalue = "100,000", Balance = "20,000" });
            //marketAssetsLists.Add(new HomeModel { AssetsName = "Car C", Allvalue = "100,000", Balance = "20,000" });
            //marketAssetsLists.Add(new HomeModel { AssetsName = "Youtube Chanel D", Allvalue = "100,000", Balance = "20,000" });

            //marketAssetsLists.Add(new HomeModel { AssetsName = "Home A", Allvalue = "100,000", Balance = "20,000" });
            //marketAssetsLists.Add(new HomeModel { AssetsName = "Condo B", Allvalue = "100,000", Balance = "20,000" });
            //marketAssetsLists.Add(new HomeModel { AssetsName = "Car C", Allvalue = "100,000", Balance = "20,000" });
            //marketAssetsLists.Add(new HomeModel { AssetsName = "Youtube Chanel D", Allvalue = "100,000", Balance = "20,000" });

            //marketAssetsLists.Add(new HomeModel { AssetsName = "Home A", Allvalue = "100,000", Balance = "20,000" });
            //marketAssetsLists.Add(new HomeModel { AssetsName = "Condo B", Allvalue = "100,000", Balance = "20,000" });
            //marketAssetsLists.Add(new HomeModel { AssetsName = "Car C", Allvalue = "100,000", Balance = "20,000" });
            //marketAssetsLists.Add(new HomeModel { AssetsName = "Youtube Chanel D", Allvalue = "100,000", Balance = "20,000" });

            //marketAssetsLists.Add(new HomeModel { AssetsName = "Home A", Allvalue = "100,000", Balance = "20,000" });
            //marketAssetsLists.Add(new HomeModel { AssetsName = "Condo B", Allvalue = "100,000", Balance = "20,000" });
            //marketAssetsLists.Add(new HomeModel { AssetsName = "Car C", Allvalue = "100,000", Balance = "20,000" });
            //marketAssetsLists.Add(new HomeModel { AssetsName = "Youtube Chanel D", Allvalue = "100,000", Balance = "20,000" });

            AssetMarketlistSelectedCommand = new Command(() => NavigateToAssetMarketSelectedCommand());
        }
        public async Task GetMarketplaceAllList()
        {
            GetMarketplaceApi api = new GetMarketplaceApi();
            HomeModelList = await api.GetMarketplace();
            marketAssetsLists = new ObservableRangeCollection<AssetInfo>();
           
            for (int i = 0; i < HomeModelList.Message.asset_list.Count; i++)
            {

                marketAssetsLists.Add(new AssetInfo
                {
                    asset_id = HomeModelList.Message.asset_list[i].asset_info.asset_id,
                    address = HomeModelList.Message.asset_list[i].asset_info.address,
                    asset_name = HomeModelList.Message.asset_list[i].asset_info.asset_name,
                    value = HomeModelList.Message.asset_list[i].asset_info.value,
                    loan_type = HomeModelList.Message.asset_list[i].asset_info.loan_type,

                    loan_duration = HomeModelList.Message.asset_list[i].asset_info.loan_duration,
                    loan_interest = HomeModelList.Message.asset_list[i].asset_info.loan_interest,
                    loan_min = HomeModelList.Message.asset_list[i].asset_info.loan_min,

                    loan_max = HomeModelList.Message.asset_list[i].asset_info.loan_max,
                    valuate_interest = HomeModelList.Message.asset_list[i].asset_info.valuate_interest,
                    token_amount = HomeModelList.Message.asset_list[i].asset_info.token_amount,
                    token_balance = HomeModelList.Message.asset_list[i].asset_info.token_balance,
                    status = HomeModelList.Message.asset_list[i].asset_info.status,
                    issue_date = HomeModelList.Message.asset_list[i].asset_info.issue_date,
                    loan_id = HomeModelList.Message.asset_list[i].asset_info.loan_id
                });
            }
        }

        async public void NavigateToAssetMarketSelectedCommand()
        {
            //var selected = (HomeModel)param;
            //if (selected != null) {

            //Console.WriteLine("ters");
            await Navigation.PushAsync(new AssetMarketInfo());

            //}
        }
        ICommand _AssetMarketlistSelectedCommand;
        public ICommand AssetMarketlistSelectedCommand
        {
            get => _AssetMarketlistSelectedCommand;
            set
            {
                _AssetMarketlistSelectedCommand = value;
                OnPropertyChanged(nameof(AssetMarketlistSelectedCommand));
            }
        }
    }
}
