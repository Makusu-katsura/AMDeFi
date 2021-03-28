using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AMDeFi.Helpers;
using AMDeFi.Models.WalletModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AMDeFi.Api
{
    public class GetWalletApi
    {
        public async Task<HistoryDAICoinList> GetWallet()
        {
           var WebAPIUrl = "http://262bd96082c4.ngrok.io/GetWallet"; // Set your REST API URL here.
            var uri = new Uri(WebAPIUrl);
            try
            {
                HttpClientImpl Api = new HttpClientImpl();
                JObject oJsonObject = new JObject();
                string sContentType = "application/json";
                oJsonObject.Add("bc_user", "NodeMoonLaNiTiSukJai");
                oJsonObject.Add("wallet_address", "0x3921h3921hg7wRipjUIG39sdkOgfkbJe3KWDindoHIsdMiiNSKw");

                //Utilities.DebugWriteLine(" DataJsonObject => " + oJsonObject.ToString());

                var content = new StringContent(oJsonObject.ToString(), Encoding.UTF8, sContentType);
                String responseJson = await Api.PostAsync(Constants.url+"/"+ "GetWallet", true, content); 
                HistoryDAICoinList res = JsonConvert.DeserializeObject<HistoryDAICoinList>(responseJson);
                return res;
            }
            catch (Exception ex)
            {
            }
            return null;

        }
    }
}
