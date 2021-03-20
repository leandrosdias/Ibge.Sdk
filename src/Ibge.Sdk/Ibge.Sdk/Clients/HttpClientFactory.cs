using System;
using System.Net.Http;

namespace Ibge.Sdk.Clients
{
    public static class HttpClientFactory
    {
        public static HttpClient GetClient(string url)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(url)
            };

            client.DefaultRequestHeaders.ConnectionClose = false;
            return client;
        }
    }
}
