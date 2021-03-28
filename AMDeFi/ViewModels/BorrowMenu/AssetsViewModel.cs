using System;
using System.Windows.Input;
using AMDeFi.Views.CustomViews;
using AMDeFi.Helpers;
using Xamarin.Forms;
using AMDeFi.Models.BurrowerModel;
using System.Threading.Tasks;
using AMDeFi.Api;

namespace AMDeFi.ViewModels.BorrowMenu
{
    public class AssetsViewModel : BaseViewmodel
    {
        string _Name;
        string _Value;
        string _Type;
        string _Status;

        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Value
        {
            get => _Value;
            set
            {
                _Value = value;
                OnPropertyChanged(nameof(Value));
            }
        }
        public string Type
        {
            get => _Type;
            set
            {
                _Type = value;
                OnPropertyChanged(nameof(Type));
            }
        }
        public string Status
        {
            get => _Status;
            set
            {
                _Status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        //

        public AssetsViewModel()
        {
            IsActionBarVisible = true;
            PageTitle = "My Assets";
            BackArrowVisible = true;
            IconAMDeFiVisible = false;

            GetMyAssets();
            //Name = "Home A";
            //Value = "1,000,000";
            //Type = "House";
            //Status = "OnApprove";

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
        public async Task GetMyAssets()
        {
            BorrowerGetOwnerAssetListApi api = new BorrowerGetOwnerAssetListApi();
            AssetsAndStatusList = await api.GetOwner();
            int i = 0;
            asset_id = AssetsAndStatusList.message.asset_list[i].asset_info.asset_id;
            address = AssetsAndStatusList.message.asset_list[i].asset_info.address;
            asset_name = AssetsAndStatusList.message.asset_list[i].asset_info.asset_name;
            value = AssetsAndStatusList.message.asset_list[i].asset_info.value.ToString();
            loan_type = AssetsAndStatusList.message.asset_list[i].asset_info.loan_type;

            loan_duration = AssetsAndStatusList.message.asset_list[i].asset_info.loan_duration.ToString();
            loan_interest = AssetsAndStatusList.message.asset_list[i].asset_info.loan_interest.ToString();
            loan_min = AssetsAndStatusList.message.asset_list[i].asset_info.loan_min.ToString();

            loan_max = AssetsAndStatusList.message.asset_list[i].asset_info.loan_max.ToString();
            valuate_interest = AssetsAndStatusList.message.asset_list[i].asset_info.valuate_interest.ToString();
            token_amount = AssetsAndStatusList.message.asset_list[i].asset_info.token_amount.ToString();
            token_balance = AssetsAndStatusList.message.asset_list[i].asset_info.token_balance.ToString();
            status = AssetsAndStatusList.message.asset_list[i].asset_info.status;
            issue_date = AssetsAndStatusList.message.asset_list[i].asset_info.issue_date.ToString();
            loan_id = AssetsAndStatusList.message.asset_list[i].asset_info.loan_id;


        }
        string _loan_min;
        public string loan_min
        {
            get => _loan_min;
            set
            {
                _loan_min = value;
                OnPropertyChanged(nameof(loan_min));
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
        string _valuate_interest;
        public string valuate_interest
        {
            get => _valuate_interest;
            set
            {
                _valuate_interest = value;
                OnPropertyChanged(nameof(valuate_interest));
            }
        }
        string _loan_id;
        public string loan_id
        {
            get => _loan_id;
            set
            {
                _loan_id = value;
                OnPropertyChanged(nameof(loan_id));
            }
        }
        //
        string _token_amount;
        public string token_amount
        {
            get => _token_amount;
            set
            {
                _token_amount = value;
                OnPropertyChanged(nameof(token_amount));
            }
        }
        string _token_balance;
        public string token_balance
        {
            get => _token_balance;
            set
            {
                _token_balance = value;
                OnPropertyChanged(nameof(token_balance));
            }
        }
        string _status;
        public string status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(status));
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
        //
        string _asset_id;
        public string asset_id
        {
            get => _asset_id;
            set
            {
                _asset_id = value;
                OnPropertyChanged(nameof(asset_id));
            }
        }
        string _address;
        public string address
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged(nameof(address));
            }
        }
        string _asset_name;
        public string asset_name
        {
            get => _asset_name;
            set
            {
                _asset_name = value;
                OnPropertyChanged(nameof(asset_name));
            }
        }

        //
        string _value;
        public string value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(value));
            }
        }
        string _loan_type;
        public string loan_type
        {
            get => _loan_type;
            set
            {
                _loan_type = value;
                OnPropertyChanged(nameof(loan_type));
            }
        }
        string _loan_duration;
        public string loan_duration
        {
            get => _loan_duration;
            set
            {
                _loan_duration = value;
                OnPropertyChanged(nameof(loan_duration));
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
    }
}
