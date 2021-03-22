namespace Ibge.Sdk.Models
{
    public class MicroRegion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MesoRegion MesoRegion { get; set; }
    }
}
