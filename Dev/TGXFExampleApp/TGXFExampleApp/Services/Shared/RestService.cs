using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TGXFExampleApp.Interfaces;

namespace TGXFExampleApp.Services.Shared
{
    public class RestService<T> : IRestService<T>
    {
        HttpClient client;

        public RestService()
        {
            //var authData = string.Format("{0}:{1}", Constants.Username, Constants.Password);
            //var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));

            client = new HttpClient
            {
                MaxResponseContentBufferSize = 256000,
                Timeout = TimeSpan.FromSeconds(5)
            };
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
        }

        public async Task<T> GetDataAsync()
        {
            try
            {
                // RestUrl = http://exmpleurl.xamarin.com/api/exampleitems
                var uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

                var response = await client.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<T>(content);

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"              ERROR {0}", ex.Message);
                return default(T);
            }
        }

        public Task DeleteDataAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task SaveDataAsync(T t)
        {


        }
    }
}
