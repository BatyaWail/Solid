namespace Solid.Core.Models
{
    public class Station
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int CountFamily { get; set; }
        public DayOfWeek Day { get; set; }
        public List<Client> Clients { get; set; }
        public List<Product> Products { get; set; }

    }
}
