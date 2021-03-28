using System;
using System.Threading.Tasks;
using System.Windows.Input;
using AMDeFi.Helpers;
using AMDeFi.Models.HomeModel;
using AMDeFi.Views.LendMenu;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;
using System.Diagnostics;
namespace AMDeFi.ViewModels.HomeMenu
{
    public class HomeViewmodel : BaseViewmodel
    {

        public HomeViewmodel()
        {
            DigitalAssetsList = new ObservableRangeCollection<HomeModel>();

            //DigitalAssetsList.Add(new HomeModel { AssetsName = "Home A", Allvalue = "100,000", Balance = "20,000" });
            //DigitalAssetsList.Add(new HomeModel { AssetsName = "Condo B", Allvalue = "100,000", Balance = "20,000" });
            //DigitalAssetsList.Add(new HomeModel { AssetsName = "Car C", Allvalue = "100,000", Balance = "20,000" });
            //DigitalAssetsList.Add(new HomeModel { AssetsName = "Youtube Chanel D", Allvalue = "100,000", Balance = "20,000" });
            //AssetsMarketSelectCommand = new Command(() => NavigateToAssetsMarketSelectCommand());
        }

        //async private void NavigateToAssetsMarketSelectCommand()
        //{
        //    //var selected = (HomeModel)param;
        //    //if (selected != null)
        //    //{
        //        //Console.WriteLine("NavigateToAssetsMarketSelectCommand");
        //        //((ListView)param).SelectedItem = -1;

        //        await Navigation.PushAsync(new AssetMarketInfo(null));
        //    //}

        //}



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

        ObservableRangeCollection<HomeModel> _digitalAssetsList;
        public ObservableRangeCollection<HomeModel> DigitalAssetsList
        {
            get => _digitalAssetsList;
            set
            {
                _digitalAssetsList = value;
                OnPropertyChanged(nameof(DigitalAssetsList));
            }
        }

        public async void ViewAllDigitalAssetsListAsync()
        {
            try
            {
                //DigitalAssetsList = new ObservableRangeCollection<HomeModel>();
                //for (int i = 0; i < 5; i++)
                //{
                //    DigitalAssetsList.Add(new HomeModel
                //    {
                //        AssetsName = "Home A",
                //        Allvalue = "100,000",
                //        Balance = "20,000"
                //    });
                //}

                //using (ServiceProvider service = new ServiceProvider())
                //{
                //    var req = new HomeModel();
                //    var results = await service.PostAsync<HomeModel>("", req);

                //    if (results != null)
                //    {
                //        Console.WriteLine("CollateralListApi : " + results.ToString());

                //        results = JsonConvert.DeserializeObject<HomeModel>(results.ToString());

                //        for (int i = 0; i < 5; i++)
                //        {
                //            DigitalAssetsList.Add(new HomeModel
                //            {
                //                AssetsName = "Home A",
                //                Allvalue = "100,000",
                //                Balance = "20,000"
                //            });
                //        }
                //    }
                //}
            }

            catch (Exception ex)
            {
            }

        }


    }
}

