using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AMDeFi.Helpers;
using AMDeFi.Models.BurrowerModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AMDeFi.Api
{
    public class BorrowerGetOwnerAssetListApi
    {
        public async Task<AssetsAndStatusList> GetOwner()
        {
            try
            {
                HttpClientImpl Api = new HttpClientImpl();
                JObject oJsonObject = new JObject();
                string sContentType = "application/json";
                oJsonObject.Add("bc_user", "NodeMoonLaNiTiSukJai");
                oJsonObject.Add("wallet_address", "0x3921h3921hg7wRipjUIG39sdkOgfkbJe3KWDindoHIsdMiiNSKw");

                //Utilities.DebugWriteLine(" DataJsonObject => " + oJsonObject.ToString());

                var content = new StringContent(oJsonObject.ToString(), Encoding.UTF8, sContentType);
                String responseJson = await Api.PostAsync(Constants.url + "/" + "BorrowerGetOwnerAssetList", true, content);
                AssetsAndStatusList res = JsonConvert.DeserializeObject<AssetsAndStatusList>(responseJson);
                return res;
            }
            catch (Exception ex)
            {
            }
            return null;

            //}
        }
    }
}
