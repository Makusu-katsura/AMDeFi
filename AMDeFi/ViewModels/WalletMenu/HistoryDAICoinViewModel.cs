using System;
using System.Windows.Input;
using AMDeFi.Models.WalletModel;
using AMDeFi.Views.WalletMenu.HistoryDAICoin;
using AMDeFi.Helpers;
using Xamarin.Forms;
using AMDeFi.Api;
using System.Threading.Tasks;

namespace AMDeFi.ViewModels.WalletMenu
{
    public class HistoryDAICoinViewModel : BaseViewmodel
    {
        ObservableRangeCollection<Transaction> _historyDAICoin;
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
        public ObservableRangeCollection<Transaction> historyDAICoin
        {
            get => _historyDAICoin;
            set
            {
                _historyDAICoin = value;
                OnPropertyChanged(nameof(historyDAICoin));
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
        public HistoryDAICoinViewModel()
        {
            //historyDAICoin = new ObservableRangeCollection<Transaction>();
            IsActionBarVisible = true;
            PageTitle = "My HistoryDAICoinViewModel";
            BackArrowVisible = true;
            IconAMDeFiVisible = false;
            TotalDAICoin = "2,000,000";

            //historyDAICoin.Add(new Transaction { transaction_name = "A", transaction_type = "Sell" , snapshot_balance = 120000000 });
            //historyDAICoin.Add(new Transaction { transaction_name = "A", transaction_type = "Sell", snapshot_balance = 20000000 });
            //historyDAICoin.Add(new Transaction { transaction_name = "A", transaction_type = "Sell", snapshot_balance = 20000000 });
            //historyDAICoin.Add(new Transaction { transaction_name = "A", transaction_type = "Sell", snapshot_balance = 20000000 });
            //historyDAICoin.Add(new Transaction { transaction_name = "A", transaction_type = "Sell", snapshot_balance = 20000000 });

            //historyDAICoin.Add(new Transaction { Deposit = "B", TransactionDate = "01/01/2020" });

        }

        public async Task GetWellet()
        {
            GetWalletApi api = new GetWalletApi();

            HistoryDAICoinList = await api.GetWallet();
            //TotalDAICoin = HistoryDAICoinList.Balance.ToString();


            //for (int i = 0; i < HistoryDAICoinList.Trasaction.Count; i++)
            //{
            //    historyDAICoin.Add(new Trasaction
            //    {
            //     address = HistoryDAICoinList.Address,
            //     issue_date = HistoryDAICoinList.Trasaction[i].issue_date,
            //     transaction_name = HistoryDAICoinList.Trasaction[i].transaction_name,
            //     transaction_type = HistoryDAICoinList.Trasaction[i].transaction_type,
            //     total = HistoryDAICoinList.Trasaction[i].total,
            //     snapshot_balance = HistoryDAICoinList.Trasaction[i].snapshot_balance,
            //    });
            //}
            //IsActionBarVisible = true;
            //PageTitle = "Digital Assets Market Place";
            //BackArrowVisible = true;
            //IconAMDeFiVisible = false;
            //historyDAICoin = new ObservableRangeCollection<HistoryDAICoin>();
            //TotalDAICoin = "2,000,000";
            //historyDAICoin.Add(new HistoryDAICoin { Witdraw = "A", TransactionDate = "01/01/2020" });
            //historyDAICoin.Add(new HistoryDAICoin { Deposit = "B", TransactionDate = "01/01/2020" });


            HistoryDAICoinSelectCommand = new Command((param) => NavigateToDAICointSelectCommand(param));
        }
        async private void NavigateToDAICointSelectCommand(object param)
        {
            //var selected = (HistoryDAICoin)param;
            //if (selected != null)
            //{
                //Console.WriteLine("NavigateToAssetsMarketSelectCommand");
                await Navigation.PushAsync(new DAICoinInfo());
            //}
        }
        ICommand _HistoryDAICoinSelectCommand;
        public ICommand HistoryDAICoinSelectCommand
        {
            get => _HistoryDAICoinSelectCommand;
            set
            {
                _HistoryDAICoinSelectCommand = value;
                OnPropertyChanged(nameof(HistoryDAICoinSelectCommand));
            }
        }
    }
}
