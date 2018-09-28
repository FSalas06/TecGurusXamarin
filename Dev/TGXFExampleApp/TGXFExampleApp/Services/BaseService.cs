using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TGXFExampleApp.Services
{
    public abstract class BaseService
    {
        private string _endpointUrl;
        HttpClient _client;

        private Uri UriBuilder(string endpoint)
        {
            return new Uri(string.Concat(_endpointUrl, endpoint));
        }

        protected BaseService(string endpointPrefix)
        {
            _endpointUrl = $"{Constants.RestUrl}{endpointPrefix}/";

            //var authData = string.Format("{0}:{1}", Constants.Username, Constants.Password);
            //var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));

            _client = new HttpClient
            {
                MaxResponseContentBufferSize = 256000,
                Timeout = TimeSpan.FromSeconds(5)
            };

            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
        }

        protected async Task<T> GetAsync<T>(string endpoint)
        {
            try
            {
                var uri = UriBuilder(endpoint);
                var response = await _client.GetAsync(uri);
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

        protected async Task PostAsync<T>(string endpoint, T t)
        {
            var uri = UriBuilder(endpoint);

            var json = JsonConvert.SerializeObject(t);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;
            response = await _client.PostAsync(uri, content);

            response.EnsureSuccessStatusCode();
        }

        protected async Task PutAsync<T>(string endpoint, T t)
        {
            var uri = UriBuilder(endpoint);

            var json = JsonConvert.SerializeObject(t);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;
            response = await _client.PutAsync(uri, content);

            response.EnsureSuccessStatusCode();
        }

        protected async Task DeleteAsync(string endpoint)
        {
            var uri = UriBuilder(endpoint);


            HttpResponseMessage response = null;
            response = await _client.DeleteAsync(uri);

            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                Debug.WriteLine(@"Successfully deleted.");
            }
            else
            {
                Debug.WriteLine(@"              ERROR {0}", nameof(DeleteAsync));
            }
        }
    }
}
