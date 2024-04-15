using System.ComponentModel.DataAnnotations.Schema;

namespace DBTest
{
    internal class Order
    {
        public int Id { get; set; }
        [Column("client_id")]
        public int ClientID { get; set; }
        [Column("port_1_id")]
        public int Port1Id { get; set; }
        [Column("port_2_id")]
        public int Port2Id { get; set; }
        [Column("start_time")]
        public DateTime StartTime { get; set; }
        [Column("end_time")]
        public DateTime EndTime { get; set; }
        [Column("depart_time")]
        public DateTime DepartTime { get; set; }
        [Column("arrival_time")]
        public DateTime ArrivalTime { get; set; }
        [Column("price")]
        public decimal Price { get; set; }

        public Client Client { get; set; }
        public Port Port1 { get; set; }
        public Port Port2 { get; set; }
        public ICollection<Containe> Containers { get; set; }

        public Order()
        {
            Client = new Client();
            Port1 = new Port();
            Port2 = new Port();
            Containers = new List<Containe>();
        }
    }
}