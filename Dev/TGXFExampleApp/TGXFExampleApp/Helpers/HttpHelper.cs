using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TGXFExampleApp.Helpers
{
    public class HttpHelper<T>
    {


        /// <summary>
        /// Gets the data async.
        /// </summary>
        /// <returns>The data async.</returns>
        /// <param name="apiAddress">API address.</param>
        public async Task<T> GetDataAsync(string apiAddress)
        {
            var uri = new Uri(string.Format(apiAddress, string.Empty));

            var client = new HttpClient
            {
                BaseAddress = uri
            };
            var response = await client.GetAsync(client.BaseAddress);
            response.EnsureSuccessStatusCode();
            var jsonResult = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(jsonResult);

            return result;
        }

        /// <summary>
        /// Saves the data async.
        /// </summary>
        /// <returns>The data async.</returns>
        /// <param name="apiAddress">API address.</param>
        /// <param name="t">T.</param>
        public async Task SaveDataAsync(string apiAddress, T t)
        {
            var uri = new Uri(string.Format(apiAddress, string.Empty));

            var client = new HttpClient
            {
                BaseAddress = new Uri(apiAddress)
            };

            var json = JsonConvert.SerializeObject(t);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;
            response = await client.PostAsync(uri, content);

            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Updates the data async.
        /// </summary>
        /// <returns>The data async.</returns>
        /// <param name="apiAddress">API address.</param>
        /// <param name="t">T.</param>
        public async Task UpdateDataAsync(string apiAddress, T t)
        {
            var uri = new Uri(string.Format(apiAddress, string.Empty));

            var client = new HttpClient
            {
                BaseAddress = uri
            };

            var json = JsonConvert.SerializeObject(t);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;
            response = await client.PutAsync(uri, content);

            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Deletes the data async.
        /// </summary>
        /// <returns>The data async.</returns>
        /// <param name="apiAddress">API address.</param>
        /// <param name="id">Identifier.</param>
        public async Task DeleteDataAsync(string apiAddress, string id)
        {
            var uri = new Uri(string.Format(apiAddress, id));

            var client = new HttpClient
            {
                BaseAddress = uri
            };

            var response = await client.DeleteAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                Debug.WriteLine(@"Successfully deleted.");
            }
        }
    }
}