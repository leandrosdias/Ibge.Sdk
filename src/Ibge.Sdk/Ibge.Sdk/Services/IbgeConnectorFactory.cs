using Ibge.Sdk.Enums;

namespace Ibge.Sdk.Services
{
    public static class IbgeConnectorFactory
    {
        public static IbgeConnector GetIbgeConnector(string api, string urlBase = "")
        {
            return new IbgeConnector(api, urlBase);
        }

        public static IbgeConnector GetIbgeConnector(IbgeApis api, string urlBase = "")
        {
            return new IbgeConnector(GetApiName(api), urlBase);
        }

        private static string GetApiName(IbgeApis api)
        {
            return api switch
            {
                IbgeApis.Locations => "v1/localidades/",
                IbgeApis.Names => "v2/censos/nomes/",
                IbgeApis.NamesRanking => "v2/censos/nomes/ranking/",
                _ => throw new System.NotImplementedException()
            };
        }
    }
}
