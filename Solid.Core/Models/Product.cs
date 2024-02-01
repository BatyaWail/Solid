namespace Solid.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int StationId { get; set; }
        public Station Station { get; set; }
        public List<Client> Clients { get; set; }

    }
}
