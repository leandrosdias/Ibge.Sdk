using Ibge.Sdk.Clients;
using Ibge.Sdk.Interfaces;
using Ibge.Sdk.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ibge.Sdk.Services
{
    public class IbgeConnector : IIbgeConnector, IDisposable
    {
        private HttpClient _httpClient;
        public IbgeConnector(string api, string urlBase = "")
        {
            if (string.IsNullOrWhiteSpace(urlBase))
            {
                urlBase = $"https://servicodados.ibge.gov.br/api/v2/";
            }

            var endpoint = urlBase + api;
            _httpClient = HttpClientFactory.GetClient(endpoint);
        }

        public async Task<string> GetClientResponseAsync(string args)
        {
            var response = await _httpClient.GetAsync(args);
            var responseContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return responseContent;

            throw new ConnectorException(response.StatusCode, response.IsSuccessStatusCode);
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }

    }
}
