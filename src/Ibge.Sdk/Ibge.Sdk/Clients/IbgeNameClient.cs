using Ibge.Sdk.Interfaces;
using Ibge.Sdk.Models;
using Ibge.Sdk.Services;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ibge.Sdk.Clients
{
    public class IbgeNameClient
    {
        private readonly IIbgeConnector _connector;
        public IbgeNameClient(IIbgeConnector connector)
        {
            _connector = connector;
        }

        public IbgeNameClient()
        {
            _connector = IbgeConnectorFactory.GetIbgeConnector(Enums.IbgeApis.Names);
        }

        public async Task<IEnumerable<NameResult>> GetNamesAsync(List<string> names)
        {
            var result = await _connector.GetClientResponseAsync(string.Join("|", names));
            return JsonSerializer.Deserialize<IEnumerable<NameResult>>(result);
        }

        public async Task<List<NameResult>> GetNamesByRankingAsync()
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "ranking/");
            return JsonSerializer.Deserialize<List<NameResult>>(result);
        }
    }
}
