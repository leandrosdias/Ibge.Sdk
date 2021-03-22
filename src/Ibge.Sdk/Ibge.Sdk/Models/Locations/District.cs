namespace Ibge.Sdk.Models
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public County County { get; set; }
    }
}
