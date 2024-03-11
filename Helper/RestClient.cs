using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
namespace ResourceConfigurator.Helper
{

    public class RestClient<T>
    {
        private readonly HttpClient httpClient;

        public RestClient(string baseUri, string authToken)
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUri)
            };

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
        }

        public async Task<T> GetAsync(string endpoint)
        {
            T? result = default(T);
            var response = httpClient.GetAsync(new Uri(endpoint)).Result;

            response.EnsureSuccessStatusCode();

            await response.Content.ReadAsStringAsync().ContinueWith((Task<string> x) =>
            {
                if (x.IsFaulted)
                    throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");

                result = JsonConvert.DeserializeObject<T>(x.Result);
            });
            return result;
        }


        public async Task<T> PostAsync(string endpoint, object data)
        {
            T? result = default(T);
            string jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            HttpContent httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endpoint, httpContent);

            response.EnsureSuccessStatusCode();

            await response.Content.ReadAsStringAsync().ContinueWith((Task<string> x) =>
            {
                if (x.IsFaulted)
                    throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");

                result = JsonConvert.DeserializeObject<T>(x.Result);
            });
            return result;
        }

    }
}
