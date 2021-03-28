using System;
using System.Windows.Input;
using AMDeFi.Models.BurrowerModel;
using AMDeFi.Views.CustomViews;
using AMDeFi.Helpers;
using Xamarin.Forms;
namespace AMDeFi.ViewModels.BorrowMenu
{
    public class AddAssetsViewModel : BaseViewmodel
    {
        ObservableRangeCollection<AssetsForm> _AssetsForm;
        public ObservableRangeCollection<AssetsForm> AssetsForm
        {
            get => _AssetsForm;
            set
            {
                _AssetsForm = value;
                OnPropertyChanged(nameof(AssetsForm));
            }
        }
        ICommand _digitalAssetSelectedCommand;

        public ICommand DigitalAssetSelectedCommand
        {
            get => _digitalAssetSelectedCommand;
            set
            {
                _digitalAssetSelectedCommand = value;
                OnPropertyChanged(nameof(DigitalAssetSelectedCommand));
            }

        }

        public AddAssetsViewModel()
        {
            IsActionBarVisible = true;
            PageTitle = "Add Assets";
            BackArrowVisible = true;
            AssetsForm = new ObservableRangeCollection<AssetsForm>();
            AssetsForm.Add(new AssetsForm { FormName = "เจ้าแตกจะไปกู้กรุงศรี" });
            AssetsForm.Add(new AssetsForm { FormName = "กู้ไม่ได้กู้กสิกรแทน" });

            DigitalAssetSelectedCommand = new Command((param) => NavigateToAssetsDetail(param));
        }

        private void NavigateToAssetsDetail(object param)
        {
            var url = string.Empty;
            var selectedItem = (AssetsForm)param;
            Console.WriteLine("NavigateToAssetsDetail");

        }
    }
}
