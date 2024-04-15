using System.ComponentModel.DataAnnotations.Schema;

namespace DBTest
{
    internal class Containe
    {
        public int Id { get; set; }
        [Column("type")]
        public TypeContainer Type { get; set; }
        [Column("cost")]
        public decimal Cost { get; set; }

        public ICollection<Order> Orders { get; set; }

        public Containe()
        {
            Orders = new List<Order>();
        }
    }

    public enum TypeContainer
    {
        UNDEF, STANDART, FREEZ, OPEN, PLATFORM, BOILER, TERMOS, SILK, VENT
    }
}