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
                IbgeApis.Locations => "localidades/",
                IbgeApis.Names => "censos/nomes/",
                _ => throw new System.NotImplementedException()
            };
        }
    }
}
