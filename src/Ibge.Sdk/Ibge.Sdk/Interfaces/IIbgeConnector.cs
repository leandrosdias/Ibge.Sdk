using System.Net.Http;
using System.Threading.Tasks;

namespace Ibge.Sdk.Interfaces
{
    interface IIbgeConnector
    {
        Task<string> GetClientResponseAsync(string args);
    }
}
