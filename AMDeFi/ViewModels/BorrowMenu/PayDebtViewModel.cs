using System;
namespace AMDeFi.ViewModels.BorrowMenu
{
    public class PayDebtViewModel:BaseViewmodel
    {
        string _TotalCoin;
        string _Debt;
        string _RemainCoin;
        public string TotalCoin
        {
            get => _TotalCoin;
            set
            {
                _TotalCoin = value;
                OnPropertyChanged(nameof(TotalCoin));
            }
        }
        public string Debt
        {
            get => _Debt;
            set
            {
                _Debt = value;
                OnPropertyChanged(nameof(Debt));
            }
        }
        public string RemainCoin
        {
            get => _RemainCoin;
            set
            {
                _RemainCoin = value;
                OnPropertyChanged(nameof(RemainCoin));
            }
        }
        public PayDebtViewModel()
        {
            IsActionBarVisible = true;
            PageTitle = "Pay Debt";
            BackArrowVisible = true;
            IconAMDeFiVisible = false;

            TotalCoin = "1,000,000";
            Debt = "500,000";
            RemainCoin = "500,000";
        }
    }
}
