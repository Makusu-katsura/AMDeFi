using System;
using System.Threading.Tasks;
using AMDeFi.Api;
using AMDeFi.Models.HomeModel;

namespace AMDeFi.ViewModels.LendMenu
{
    public class AssetMarketInfoViewModel:BaseViewmodel
    {
        string _Name;
        string _TotalAmount;
        string _BuyVolumn;
        string _PricePerVolumn;
        string _TotalVolumn;

        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string TotalAmount
        {
            get => _TotalAmount;
            set
            {
                _TotalAmount = value;
                OnPropertyChanged(nameof(TotalAmount));
            }
        }
        public string BuyVolumn
        {
            get => _BuyVolumn;
            set
            {
                _BuyVolumn = value;
                OnPropertyChanged(nameof(BuyVolumn));
            }
        }
        public string PricePerVolumn
        {
            get => _PricePerVolumn;
            set
            {
                _PricePerVolumn = value;
                OnPropertyChanged(nameof(PricePerVolumn));
            }
        }
        public string TotalVolumn
        {
            get => _TotalVolumn;
            set
            {
                _TotalVolumn = value;
                OnPropertyChanged(nameof(TotalVolumn));
            }
        }


        string _issue_date;

        public string issue_date
        {
            get => _issue_date;
            set
            {
                _issue_date = value;
                OnPropertyChanged(nameof(issue_date));
            }
        }

        string _loan_interest;

        public string loan_interest
        {
            get => _loan_interest;
            set
            {
                _loan_interest = value;
                OnPropertyChanged(nameof(loan_interest));
            }
        }

        string _loan_max;

        public string loan_max
        {
            get => _loan_max;
            set
            {
                _loan_max = value;
                OnPropertyChanged(nameof(loan_max));
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
        public AssetMarketInfoViewModel()
        {
            IsActionBarVisible = true;
            PageTitle = "Digital Assets Information";
            BackArrowVisible = true;
            IconAMDeFiVisible = false;
            GetMarketplaceList();
        }

        
        public async Task GetMarketplaceList()
        {
            GetMarketplaceApi api = new GetMarketplaceApi();
            HomeModelList = await api.GetMarketplace();
            Name = HomeModelList.Message.asset_list[0].asset_info.asset_name;
            TotalAmount = HomeModelList.Message.asset_list[0].asset_info.token_amount.ToString();
            BuyVolumn = HomeModelList.Message.asset_list[0].asset_info.token_balance.ToString();
            PricePerVolumn = HomeModelList.Message.asset_list[0].asset_info.status;
            TotalVolumn = HomeModelList.Message.asset_list[0].asset_info.loan_id;
            issue_date = HomeModelList.Message.asset_list[0].asset_info.issue_date.ToString();
            loan_interest = HomeModelList.Message.asset_list[0].asset_info.loan_interest.ToString();
            loan_max = HomeModelList.Message.asset_list[0].asset_info.loan_max.ToString();
        }
    }
}
