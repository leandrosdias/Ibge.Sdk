using System.Text.Json.Serialization;

namespace Ibge.Sdk.Models
{
    public class MesoRegion
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("nome")]
        public string Name { get; set; }
        [JsonPropertyName("UF")]
        public Uf Uf { get; set; }
    }
}
