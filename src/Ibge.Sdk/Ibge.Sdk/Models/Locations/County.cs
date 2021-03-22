using System.Text.Json.Serialization;

namespace Ibge.Sdk.Models
{
    public class County
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("nome")]
        public string Name { get; set; }
        [JsonPropertyName("microrregiao")]
        public MicroRegion MicroRegion { get; set; }
    }
}
