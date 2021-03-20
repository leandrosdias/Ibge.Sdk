using System;
using System.Net;

namespace Ibge.Sdk.Models
{
    class ConnectorException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccessStatusCode { get; set; }

        public ConnectorException(HttpStatusCode statusCode, bool isSuccessStatusCode)
        {
            StatusCode = statusCode;
            IsSuccessStatusCode = isSuccessStatusCode;
        }
    }
}
