using System;
using AMDeFi.Helpers;

namespace AMDeFi.Models
{
    public class MenuSelection : NotifyObject
    {
        string _borrowMenuColor;

        public string BorrowMenuColor
        {
            get => _borrowMenuColor;
            set
            {
                _borrowMenuColor = value;
                OnPropertyChanged(nameof(BorrowMenuColor));
            }
        }

        string _borrowMenuTextColor;

        public string BorrowMenuTextColor
        {
            get => _borrowMenuTextColor;
            set
            {
                _borrowMenuTextColor = value;
                OnPropertyChanged(nameof(BorrowMenuTextColor));
            }
        }

        string _lendMenuColor;

        public string LendMenuColor
        {
            get => _lendMenuColor;
            set
            {
                _lendMenuColor = value;
                OnPropertyChanged(nameof(LendMenuColor));
            }
        }

        string _lendMenuTextColor;

        public string LendMenuTextColor
        {
            get => _lendMenuTextColor;
            set
            {
                _lendMenuTextColor = value;
                OnPropertyChanged(nameof(LendMenuTextColor));
            }
        }

        string _walletMenuColor;

        public string WalletMenuColor
        {
            get => _walletMenuColor;
            set
            {
                _walletMenuColor = value;
                OnPropertyChanged(nameof(WalletMenuColor));
            }
        }


        string _walletMenuTextColor;

        public string WalletMenuTextColor
        {
            get => _walletMenuTextColor;
            set
            {
                _walletMenuTextColor = value;
                OnPropertyChanged(nameof(WalletMenuTextColor));
            }
        }

        string _homeMenuColor;

        public string HomeMenuColor
        {
            get => _homeMenuColor;
            set
            {
                _homeMenuColor = value;
                OnPropertyChanged(nameof(HomeMenuColor));
            }
        }

        string _borrowMenuIcon;

        public string BorrowMenuIcon
        {
            get => _borrowMenuIcon;
            set
            {
                _borrowMenuIcon = value;
                OnPropertyChanged(nameof(BorrowMenuIcon));
            }
        }

        string _lendMenuIcon;

        public string LendMenuIcon
        {
            get => _lendMenuIcon;
            set
            {
                _lendMenuIcon = value;
                OnPropertyChanged(nameof(LendMenuIcon));
            }
        }


        string _homeMenuTextColor;

        public string HomeMenuTextColor
        {
            get => _homeMenuTextColor;
            set
            {
                _homeMenuTextColor = value;
                OnPropertyChanged(nameof(HomeMenuTextColor));
            }
        }

        string _homeMenuIcon;

        public string HomeMenuIcon
        {
            get => _homeMenuIcon;
            set
            {
                _homeMenuIcon = value;
                OnPropertyChanged(nameof(HomeMenuIcon));
            }
        }

        string _walletMenuIcon;

        public string WalletMenuIcon
        {
            get => _walletMenuIcon;
            set
            {
                _walletMenuIcon = value;
                OnPropertyChanged(nameof(WalletMenuIcon));
            }
        }



        public void ResetStyle()
        {
            BorrowMenuIcon = "loanInactive.png";
            LendMenuIcon = "tradeInactive.png";
            WalletMenuIcon = "portfolioInactive.png";
            HomeMenuIcon = "homeInactive";
        }

        public void ResetColorTabStyle()
        {
            BorrowMenuColor = "#FFFFFF";
            LendMenuColor = "#FFFFFF";
            WalletMenuColor = "#FFFFFF";
            HomeMenuColor = "#FFFFFF";
        }

        public void ResetTextColorStyle()
        {
            BorrowMenuTextColor = "#ADA8A8";
            LendMenuTextColor = "#ADA8A8";
            WalletMenuTextColor = "#ADA8A8";
            HomeMenuTextColor = "#ADA8A8";

        }



    }
}
