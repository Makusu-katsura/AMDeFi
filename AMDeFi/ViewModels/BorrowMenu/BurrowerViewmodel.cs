using System;
using System.Windows.Input;
using AMDeFi.Models.BurrowerModel;
using AMDeFi.Views.CustomViews;
using AMDeFi.Helpers;
using Xamarin.Forms;
using AMDeFi.Views.BorrowMenu;
using System.Threading.Tasks;
using AMDeFi.Api;

namespace AMDeFi.ViewModels.BorrowMenu
{

    public class BurrowerViewmodel : BaseViewmodel
    {
        ObservableRangeCollection<AssetsAndStatusList> _Assetlist;
        public ObservableRangeCollection<AssetsAndStatusList> Assetlist
        {
            get => _Assetlist;
            set
            {
                _Assetlist = value;
                OnPropertyChanged(nameof(Assetlist));
            }
        }

        AssetsAndStatusList _assetsAndStatusList;
        public AssetsAndStatusList AssetsAndStatusList
        {
            get => _assetsAndStatusList;
            set
            {
                _assetsAndStatusList = value;
                OnPropertyChanged(nameof(AssetsAndStatusList));
            }
        }
        public BurrowerViewmodel()
        {
            Assetlist = new ObservableRangeCollection<AssetsAndStatusList>();

            //Assetlist.Add(new AssetsAndStatusList { Number = "1", AssetsName = "Asset A", Status = "Pending", Date = "20/01/22" });
            //Assetlist.Add(new AssetsAndStatusList { Number = "2", AssetsName = "Asset B", Status = "ready", Date = "20/01/22" });
            //Assetlist.Add(new AssetsAndStatusList { Number = "3", AssetsName = "Asset C", Status = "Approve", Date = "20/01/22" });
            //Assetlist.Add(new AssetsAndStatusList { Number = "4", AssetsName = "Asset D", Status = "Pending", Date = "20/01/22" });
            AssetlistSelectedCommand = new Command((param) => NavigateToAssetlistSelectedCommand(param));
        }
        public async Task GetMyAssets()
        {
            BorrowerGetOwnerAssetListApi api = new BorrowerGetOwnerAssetListApi();

            AssetsAndStatusList = await api.GetOwner();


            
            //IsActionBarVisible = true;
            //PageTitle = "Digital Assets Market Place";
            //BackArrowVisible = true;
            //IconAMDeFiVisible = false;
            //historyDAICoin = new ObservableRangeCollection<HistoryDAICoin>();
            //TotalDAICoin = "2,000,000";
            //historyDAICoin.Add(new HistoryDAICoin { Witdraw = "A", TransactionDate = "01/01/2020" });
            //historyDAICoin.Add(new HistoryDAICoin { Deposit = "B", TransactionDate = "01/01/2020" });


        }

        async public void NavigateToAssetlistSelectedCommand(object param)
        {
            var selected = (AssetsAndStatusList)param;
            if (selected != null) {
                await Navigation.PushAsync(new Assets());

            }
        }
        ICommand _AssetlistSelectedCommand;
        public ICommand AssetlistSelectedCommand
        {
            get => _AssetlistSelectedCommand;
            set
            {
                _AssetlistSelectedCommand = value;
                OnPropertyChanged(nameof(AssetlistSelectedCommand));
            }
        }
    }
}
