using System.Text.Json.Serialization;

namespace Ibge.Sdk.Models
{
    public class NameResult
    {
        [JsonPropertyName("nome")]
        public string Name { get; set; }
        [JsonPropertyName("sexo")]
        public string Gender { get; set; }
        [JsonPropertyName("localidade")]
        public string Location { get; set; }
        [JsonPropertyName("res")]
        public NameDetails[] Details { get; set; }
    }

    public class NameDetails
    {
        [JsonPropertyName("periodo")]
        public string Period { get; set; }
        [JsonPropertyName("frequencia")]
        public int Frequency { get; set; }
        [JsonPropertyName("nome")]
        public string Name { get; set; }
    }

}
