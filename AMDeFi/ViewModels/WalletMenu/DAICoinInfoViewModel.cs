using System;
namespace AMDeFi.ViewModels.WalletMenu
{
    public class DAICoinInfoViewModel:BaseViewmodel
    {
        string _Name;
        string _Type;
        string _Amount;
        string _Burrower;
        string _DateTime;
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
        public string Amount
        {
            get => _Amount;
            set
            {
                _Amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }
        public string Burrower
        {
            get => _Burrower;
            set
            {
                _Burrower = value;
                OnPropertyChanged(nameof(Burrower));
            }
        }
        public string DateTime
        {
            get => _DateTime;
            set
            {
                _DateTime = value;
                OnPropertyChanged(nameof(DateTime));
            }
        }
   
        public DAICoinInfoViewModel()
        {

            IsActionBarVisible = true;
            PageTitle = "DAI Coin Information";
            BackArrowVisible = true;
            IconAMDeFiVisible = false;

            Name = "Home A";
            Type = "House";
            Amount = "10,000,000";
            Burrower = "Mr.10X";
            DateTime = "01/02/2020";
        }
    }
}
