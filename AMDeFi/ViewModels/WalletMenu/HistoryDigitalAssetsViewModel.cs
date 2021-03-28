using System;
using System.Windows.Input;
using AMDeFi.Models.WalletModel;
using AMDeFi.Views.CustomViews;
using AMDeFi.Helpers;
using Xamarin.Forms;
namespace AMDeFi.ViewModels.WalletMenu
{
    public class HistoryDigitalAssetsViewModel:BaseViewmodel
    {
        ObservableRangeCollection<HistoryDigitalAssets> _historyAssets;
        public ObservableRangeCollection<HistoryDigitalAssets> historyAssets
        {
            get => _historyAssets;
            set
            {
                _historyAssets = value;
                OnPropertyChanged(nameof(historyAssets));
            }
        }
        public HistoryDigitalAssetsViewModel()
        {
            IsActionBarVisible = true;
            PageTitle = "Digital Assets Market Place";
            BackArrowVisible = true;
            IconAMDeFiVisible = false;
            historyAssets = new ObservableRangeCollection<HistoryDigitalAssets>();
            historyAssets.Add(new HistoryDigitalAssets { Name="A",Amount="10",Value="100,000"  });
            historyAssets.Add(new HistoryDigitalAssets { Name="B",Amount="20",Value="50,000"  });

        }
    }
}
