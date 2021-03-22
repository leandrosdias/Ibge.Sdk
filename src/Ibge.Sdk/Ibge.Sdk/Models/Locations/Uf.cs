using System.Text.Json.Serialization;

namespace Ibge.Sdk.Models
{
    public class Uf
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("sigla")]
        public string Acronym { get; set; }
        [JsonPropertyName("nome")]
        public string Name { get; set; }
        [JsonPropertyName("regiao")]
        public Region Region { get; set; }
    }
}
