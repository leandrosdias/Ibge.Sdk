using Ibge.Sdk.Clients;
using Ibge.Sdk.Interfaces;
using Ibge.Sdk.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ibge.Sdk.Services
{
    public class IbgeConnector : IIbgeConnector, IDisposable
    {
        private readonly HttpClient _httpClient;
        public IbgeConnector(string api, string urlBase = "")
        {
            if (string.IsNullOrWhiteSpace(urlBase))
            {
                urlBase = $"https://servicodados.ibge.gov.br/api/v2/";
            }

            var endpoint = urlBase + api;
            _httpClient = HttpClientFactory.GetClient(endpoint);
        }

        public async Task<string> GetClientResponseAsync(string args, string sufixUrl = "")
        {
            if (!string.IsNullOrWhiteSpace(sufixUrl))
            {
                var url = _httpClient.BaseAddress.AbsoluteUri + sufixUrl;
                _httpClient.BaseAddress = new Uri(url);
            }
            var response = await _httpClient.GetAsync(args).ConfigureAwait(true);
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
