using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AMDeFi.Helpers;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace AMDeFi.Api
{

    public class HttpClientSingleton
    {
        static HttpClient client;

        private HttpClientSingleton()
        {

        }

        public static HttpClient getInstance()
        {
            if (client == null)
            {
                client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(Constants.ClientTimeout);
                client.MaxResponseContentBufferSize = 256000000;
            }
            return client;
        }

    }
    public class HttpClientImpl
    {
        private async Task SetHeader(bool requireToken)
        {
            Console.WriteLine(" On SetHeader");
            HttpClient client = HttpClientSingleton.getInstance();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("content", "application/json");
            client.DefaultRequestHeaders.Add("apikey", "558344f429d66e42b53ff6449710cea0f79211c2163d3d92b4180eaee3b6afd1");

        }
        public async Task<string> GetAsync(String url, bool requireToken = false, StringContent content = null, bool ignoreAlert = false)
        {
            try
            {
                //var url = string.Format("{0}{1}", Constants.RestUrl, serviceName);
                Console.WriteLine(@"######### START [GET] WEBAPI : " + DateTime.Now);
                Console.WriteLine(@"       Url: " + url);
                HttpClient client = HttpClientSingleton.getInstance();
                await SetHeader(requireToken);
                Console.WriteLine(@"       client.GetHashCode: " + client.GetHashCode());
                //var content = new StringContent(oJsonObject.ToString(), Encoding.UTF8, sContentType);
                var response = await client.GetAsync(url);

                Console.WriteLine(@"######### END CALL WEBAPI : " + DateTime.Now);
                Console.WriteLine("response.StatusCode" + response.StatusCode);
                string responseStringTest = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(@"######### responseStringTest (" + url + ") : " + responseStringTest);

                if (response.StatusCode != System.Net.HttpStatusCode.OK && response.StatusCode != System.Net.HttpStatusCode.NoContent)
                {
                    await Task.Run(async () =>
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                    });
                }
                string responseString = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(@"######### responseString : " + responseString);
                return responseString;
            }
            catch (TaskCanceledException error)
            {
                Console.WriteLine(@"       REST API LOGIN: set param failure => " + error);
               
                return null;
            }
            catch (Exception error)
            {
                Console.WriteLine(@"       REST API LOGIN: set param failure => " + error);
               
                //await Application.Current.MainPage.DisplayAlert("", Utilities.ResourceMessage("Err-" + StatusCode.HTTPCLIENT_ERROR) + " [" + error.Message + "]", "ตกลง");
                return null;
            }
        }
        public async Task<byte[]> GetByteAsync(String url, bool requireToken = false, bool ignoreAlert = false)
        {
            try
            {
                //var url = string.Format("{0}{1}", Constants.RestUrl, serviceName);
                Console.WriteLine(@"######### START [GET] WEBAPI : " + DateTime.Now);
                Console.WriteLine(@"       Url: " + url);
                HttpClient client = HttpClientSingleton.getInstance();
                await SetHeader(requireToken);
                Console.WriteLine(@"       client.GetHashCode: " + client.GetHashCode());
                //var content = new StringContent(oJsonObject.ToString(), Encoding.UTF8, sContentType);
                var response = await client.GetAsync(url);

                Console.WriteLine(@"######### END CALL WEBAPI : " + DateTime.Now);
                Console.WriteLine("response.StatusCode" + response.StatusCode);
                string responseStringTest = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(@"######### responseStringTest (" + url + ") : " + responseStringTest);

                if (response.StatusCode != System.Net.HttpStatusCode.OK && response.StatusCode != System.Net.HttpStatusCode.NoContent)
                {
                    await Task.Run(async () =>
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                    });
                }
                var responseString = await response.Content.ReadAsByteArrayAsync();
                Console.WriteLine(@"######### responseString : " + responseString.ToString());
                return responseString;
            }
            catch (TaskCanceledException error)
            {
                Console.WriteLine(@"       REST API LOGIN: set param failure => " + error);
               
                return null;
            }
            catch (Exception error)
            {
                Console.WriteLine(@"       REST API LOGIN: set param failure => " + error);
                  return null;
            }
        }
        public async Task<string> PostAsync(String url, bool requireToken = false, StringContent content = null, bool ignoreAlert = false)
        {
            try
            {
                //var url = string.Format("{0}{1}", Constants.RestUrl, serviceName);
                Console.WriteLine(@"######### START [POST] WEBAPI : " + DateTime.Now);
                Console.WriteLine(@"       Url: " + url);
                //client = new HttpClient();
                await SetHeader(requireToken);
                HttpClient client = HttpClientSingleton.getInstance();
                Console.WriteLine(@"       client.GetHashCode: " + client.GetHashCode());
                Console.WriteLine(@"       content: " + content);

                var response = await client.PostAsync(url, content);
                Console.WriteLine(@"######### END CALL WEBAPI : " + DateTime.Now);
                string responseStringTest = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(@"######### responseStringTest (" + url + ") : " + responseStringTest);

               

                string responseString = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(@"######### responseString : " + responseString);
                return responseString;
            }
            catch (TaskCanceledException error)
            {
                Console.WriteLine(@"       REST API LOGIN: set param failure => " + error);
              
                return null;
            }
            catch (Exception error)
            {
                Console.WriteLine(@"       REST API LOGIN: set param failure => " + error);
               
                //await Application.Current.MainPage.DisplayAlert("", Utilities.ResourceMessage("Err-" + StatusCode.HTTPCLIENT_ERROR) + " ["+error.Message+"]", "ตกลง");
                return null;
            }
        }
        public StringContent makeStringContent(JObject oJsonObject)
        {
            Console.WriteLine(" oJsonObject: " + oJsonObject.ToString());
            string sContentType = "application/json";
            return new StringContent(oJsonObject.ToString(), Encoding.UTF8, sContentType);
        }
    }
}
