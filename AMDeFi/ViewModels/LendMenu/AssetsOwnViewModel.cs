using System;
using System.Windows.Input;
using AMDeFi.Views.CustomViews;
using AMDeFi.Helpers;
using Xamarin.Forms;
using AMDeFi.Models.BurrowerModel;
namespace AMDeFi.ViewModels.LendMenu
{
    public class AssetsOwnViewModel:BaseViewmodel
    {
        string _Name;
        string _Type;
        string _Status;
        string _TotalAmount;
        string _SellVolumn;
        string _PricePerVolumn;
        string _TotalVolumn;
        string _Issue_Date;
        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                OnPropertyChanged(nameof(Name));
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
        public string TotalAmount
        {
            get => _TotalAmount;
            set
            {
                _TotalAmount = value;
                OnPropertyChanged(nameof(TotalAmount));
            }
        }
        public string SellVolumn
        {
            get => _SellVolumn;
            set
            {
                _SellVolumn = value;
                OnPropertyChanged(nameof(SellVolumn));
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
        public string Issue_Date
        {
            get => _Issue_Date;
            set
            {
                _Issue_Date = value;
                OnPropertyChanged(nameof(Issue_Date));
            }
        }
        public AssetsOwnViewModel()
        {

            IsActionBarVisible = true;
            PageTitle = "Own Assets";
            BackArrowVisible = true;
            IconAMDeFiVisible = false;

            Name = "Home A";
            Type = "secure loan";
            Status = "Approved";
            TotalAmount = "10";
            SellVolumn = "5";
            PricePerVolumn="10,000";
            TotalVolumn = "50,000";
            Issue_Date = "23/28/2021 06:22:12 AM";
        }
    }
}
