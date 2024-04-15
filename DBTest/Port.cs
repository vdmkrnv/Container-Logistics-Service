using System.ComponentModel.DataAnnotations.Schema;

namespace DBTest
{
    internal class Port
    {
        public int Id { get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("cost")]
        public decimal Cost { get; set; }

        public ICollection<Order> OrdersInPort1 { get; set; }
        public ICollection<Order> OrdersInPort2 { get; set; }

        public Port()
        {
            OrdersInPort1 = new List<Order>();
            OrdersInPort2 = new List<Order>();
        }
    }
}