namespace Ibge.Sdk.Models
{
    public class SubDistrict
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public District District { get; set; }
    }
}
