using System.Net.Http;
using System.Threading.Tasks;

namespace Ibge.Sdk.Interfaces
{
    public interface IIbgeConnector
    {
        Task<string> GetClientResponseAsync(string args, string uri = "");
    }
}
