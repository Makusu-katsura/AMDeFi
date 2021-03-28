using System;
using System.Threading.Tasks;
using System.Windows.Input;
using AMDeFi.Api;
using AMDeFi.Helpers;
using AMDeFi.Models;
using AMDeFi.Models.BurrowerModel;
using AMDeFi.Models.HomeModel;
using AMDeFi.Models.WalletModel;
using AMDeFi.Views.BorrowMenu;
using AMDeFi.Views.LendMenu;
using Xamarin.Forms;
using AssetInfo = AMDeFi.Models.BurrowerModel.AssetInfo;
using LoanInfo = AMDeFi.Models.BurrowerModel.LoanInfo;

namespace AMDeFi.ViewModels
{
    public class LandingViewModel : BaseViewmodel
    {
        #region

        MenuSelection _menuStyle;
        int _selectedIndex;
        public MenuSelection MenuStyle
        {
            get => _menuStyle;
            set
            {
                _menuStyle = value;
                OnPropertyChanged(nameof(MenuStyle));
            }
        }

        String _totalBalance;
        public String TotalBalance
        {
            get => _totalBalance;
            set
            {
                _totalBalance = value;
                OnPropertyChanged(nameof(TotalBalance));
            }
        }

        public int SelectedViewIndex
        {
            get => _selectedIndex;
            set
            {
                _selectedIndex = value;
                OnPropertyChanged(nameof(SelectedViewIndex));
                UpdateSelectedMenuStyle();
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
        ObservableRangeCollection<AssetInfo> _digitalAssetsList;
        public ObservableRangeCollection<AssetInfo> DigitalAssetsList
        {
            get => _digitalAssetsList;
            set
            {
                _digitalAssetsList = value;
                OnPropertyChanged(nameof(DigitalAssetsList));
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

        HistoryDAICoinList _historyDAICoinList;
        public HistoryDAICoinList HistoryDAICoinList
        {
            get => _historyDAICoinList;
            set
            {
                _historyDAICoinList = value;
                OnPropertyChanged(nameof(HistoryDAICoinList));
            }
        }

        ObservableRangeCollection<Transaction> _historyDAICoin;
        public ObservableRangeCollection<Transaction> historyDAICoin
        {
            get => _historyDAICoin;
            set
            {
                _historyDAICoin = value;
                OnPropertyChanged(nameof(historyDAICoin));
            }
        }
        string _TotalDAICoin;


        public string TotalDAICoin
        {
            get => _TotalDAICoin;
            set
            {
                _TotalDAICoin = value;
                OnPropertyChanged(nameof(TotalDAICoin));
            }
        }

        ICommand _AssetsMarketSelectCommand;
        public ICommand AssetsMarketSelectCommand
        {
            get => _AssetsMarketSelectCommand;
            set
            {
                _AssetsMarketSelectCommand = value;
                OnPropertyChanged(nameof(AssetsMarketSelectCommand));
            }
        }

        ObservableRangeCollection<AssetInfo> _Assetlist;
        public ObservableRangeCollection<AssetInfo> Assetlist
        {
            get => _Assetlist;
            set
            {
                _Assetlist = value;
                OnPropertyChanged(nameof(Assetlist));
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

        ObservableRangeCollection<LoanInfo> _OwnAssetlist;
        public ObservableRangeCollection<LoanInfo> OwnAssetlist
        {
            get => _OwnAssetlist;
            set
            {
                _OwnAssetlist = value;
                OnPropertyChanged(nameof(OwnAssetlist));
            }
        }
        #endregion
        public LandingViewModel()
        {
            MenuStyle = new MenuSelection();
            IsActionBarVisible = true;
            BackArrowVisible = false;
            IconAMDeFiVisible = true;
            GetWalletList();
            AssetsMarketSelectCommand = new Command(() => NavigateToAssetsMarketSelectCommand());
            AssetlistSelectedCommand = new Command(() => NavigateToAssetlistSelectedCommand());
            OurPromotionListSelectCommand = new Command(() => NavigateToOurPromotiontSelectCommand());

        }
        async private void NavigateToOurPromotiontSelectCommand()
        {
            //    var selected = (OurPromotionListModel)param;
            //    if (selected != null)
            //    {
            //Console.WriteLine("NavigateToAssetsMarketSelectCommand");
            await Navigation.PushAsync(new OurPromotions());
            //}
        }

        async public void NavigateToAssetlistSelectedCommand()
        {
            //var selected = (AssetsAndStatusList)param;
            //if (selected != null)
            //{
                await Navigation.PushAsync(new Assets());

            //}
        }
        async private void NavigateToAssetsMarketSelectCommand()
        {
            //var selected = (HomeModel)param;
            //if (selected != null)
            //{
            //    //Console.WriteLine("NavigateToAssetsMarketSelectCommand");
            //    ((ListView)param).SelectedItem = -1;

                await Navigation.PushAsync(new AssetMarketInfo());
            //}

        }
        public async Task GetMyAssets()
        {
            BorrowerGetOwnerAssetListApi api = new BorrowerGetOwnerAssetListApi();
            AssetsAndStatusList = await api.GetOwner();
            Assetlist = new ObservableRangeCollection<AssetInfo>();
            for (int i = 0; i < AssetsAndStatusList.message.asset_list.Count; i++)
            {

                Assetlist.Add(new AssetInfo
            {
                asset_id = AssetsAndStatusList.message.asset_list[i].asset_info.asset_id,
                address = AssetsAndStatusList.message.asset_list[i].asset_info.address,
                asset_name = AssetsAndStatusList.message.asset_list[i].asset_info.asset_name,
                value = AssetsAndStatusList.message.asset_list[i].asset_info.value,
                loan_type = AssetsAndStatusList.message.asset_list[i].asset_info.loan_type,

                loan_duration = AssetsAndStatusList.message.asset_list[i].asset_info.loan_duration,
                loan_interest = AssetsAndStatusList.message.asset_list[i].asset_info.loan_interest,
                loan_min = AssetsAndStatusList.message.asset_list[i].asset_info.loan_min,

                loan_max = AssetsAndStatusList.message.asset_list[i].asset_info.loan_max,
                valuate_interest = AssetsAndStatusList.message.asset_list[i].asset_info.valuate_interest,
                token_amount = AssetsAndStatusList.message.asset_list[i].asset_info.token_amount,
                token_balance = AssetsAndStatusList.message.asset_list[i].asset_info.token_balance,
                status = AssetsAndStatusList.message.asset_list[i].asset_info.status,
                issue_date = AssetsAndStatusList.message.asset_list[i].asset_info.issue_date,
                loan_id = AssetsAndStatusList.message.asset_list[i].asset_info.loan_id
            });
        }

        //Assetlist.Add(new AssetInfo
        //{
        //    asset_id = "123123123123",
        //    asset_name = "Asset Home A  B C",
        //    status = "Appoved"
        //});
        //Assetlist.Add(new AssetInfo
        //{
        //    asset_id = "123123123123",
        //    asset_name = "Asset Home A  B C",
        //    status = "Appoved"
        //});
        //Assetlist.Add(new AssetInfo
        //{
        //    asset_id = "123123123123",
        //    asset_name = "Asset Home A  B C",
        //    status = "Appoved"
        //}); Assetlist.Add(new AssetInfo
        //{
        //    asset_id = "123123123123",
        //    asset_name = "Asset Home A  B C",
        //    status = "Appoved"
        //});


        OwnAssetlist = new ObservableRangeCollection<LoanInfo>();
            for (int i = 0; i < AssetsAndStatusList.message.asset_list.Count; i++)
            {

                OwnAssetlist.Add(new LoanInfo
                {
                    loan_id = AssetsAndStatusList.message.asset_list[i].loan_info.loan_id,
                    asset_id = AssetsAndStatusList.message.asset_list[i].loan_info.asset_id,
                    address = AssetsAndStatusList.message.asset_list[i].loan_info.address,
                    loan = AssetsAndStatusList.message.asset_list[i].loan_info.loan,
                    remain_debt = AssetsAndStatusList.message.asset_list[i].loan_info.remain_debt,

                    min_debt_per_month = AssetsAndStatusList.message.asset_list[i].loan_info.min_debt_per_month,
                    end_date = AssetsAndStatusList.message.asset_list[i].loan_info.end_date,
                    interest = AssetsAndStatusList.message.asset_list[i].loan_info.interest,

                    status = AssetsAndStatusList.message.asset_list[i].loan_info.status,
                    token = AssetsAndStatusList.message.asset_list[i].loan_info.token,
                      });
            }

        }

        public async Task GetWalletList()
        {
            GetWalletApi api = new GetWalletApi();
            HistoryDAICoinList = await api.GetWallet();
            historyDAICoin = new ObservableRangeCollection<Transaction>();
            TotalDAICoin = HistoryDAICoinList.message.balance.ToString();
            for (int i = 0; i < HistoryDAICoinList.message.transaction.Count; i++)
            {

                historyDAICoin.Add(new Transaction
                {
                    transaction_name = HistoryDAICoinList.message.transaction[i].transaction_name,
                    transaction_type = HistoryDAICoinList.message.transaction[i].transaction_type,
                    issue_date = HistoryDAICoinList.message.transaction[i].issue_date,
                    total = HistoryDAICoinList.message.transaction[i].total,
                    snapshot_balance = HistoryDAICoinList.message.transaction[i].snapshot_balance,
                    TestColor = HistoryDAICoinList.message.transaction[i].transaction_type == "Buy" ? "#1D9113" : "#F62529",
                    icon = HistoryDAICoinList.message.transaction[i].transaction_type == "Buy" ? "plus.png" : "minus.png"
                }); ;
            }
        }

        public async Task GetMarketplaceList()
        {
            GetMarketplaceApi api = new GetMarketplaceApi();
            HomeModelList = await api.GetMarketplace();
            DigitalAssetsList = new ObservableRangeCollection<AssetInfo>();
            TotalBalance = TotalDAICoin;
            for (int i = 0; i < HomeModelList.Message.asset_list.Count; i++)
            {

                DigitalAssetsList.Add(new AssetInfo
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

        void UpdateSelectedMenuStyle()
        {
            MenuStyle.ResetStyle();
            MenuStyle.ResetColorTabStyle();
            MenuStyle.ResetTextColorStyle();
            switch (SelectedViewIndex)
            {
                case Constants.HomeViewIndex:
                    MenuStyle.HomeMenuIcon = "homeActive.png";
                    MenuStyle.HomeMenuColor = "#FFFFFF";
                    MenuStyle.HomeMenuTextColor = "#DD7C11";
                    PageTitle = "";
                    // MenuStyle.SettingsMenuTextStyle = (Style)Application.Current.Resources["MenuLabelYellowStyle"];
                    break;
                case Constants.BorrowViewIndex:
                    MenuStyle.BorrowMenuIcon = "loanActive.png";
                    MenuStyle.BorrowMenuColor = "#FFFFFF";
                    MenuStyle.BorrowMenuTextColor = "#DD7C11";
                    PageTitle = "Borrow";
                    // MenuStyle.PendingMenuTextStyle = (Style)Application.Current.Resources["MenuLabelYellowStyle"];
                    break;
                case Constants.LendViewIndex:
                    MenuStyle.LendMenuIcon = "tradeActive.png";
                    MenuStyle.LendMenuColor = "#FFFFFF";
                    MenuStyle.LendMenuTextColor = "#DD7C11";
                    PageTitle = "Lend";
                    // MenuStyle.ConfirmedMenuTextStyle = (Style)Application.Current.Resources["MenuLabelYellowStyle"];
                    break;
                case Constants.WalletViewIndex:
                    MenuStyle.WalletMenuIcon = "portfolioActive.png";
                    MenuStyle.WalletMenuColor = "#FFFFFF";
                    MenuStyle.WalletMenuTextColor = "#DD7C11";
                    PageTitle = "Wallet";
                    // MenuStyle.ReportMenuTextStyle = (Style)Application.Current.Resources["MenuLabelYellowStyle"];
                    break;
              
            }
        }
    }
}
