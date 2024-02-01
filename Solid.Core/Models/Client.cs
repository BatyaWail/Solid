namespace Solid.Core.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pone { get; set; }
        public string Address { get; set; }
        public int StationId { get; set; }
        public Station Station { get; set; }
        //public List<Product> Products { get; set; }


    }
}
