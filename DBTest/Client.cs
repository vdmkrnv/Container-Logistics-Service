using System.ComponentModel.DataAnnotations.Schema;

namespace DBTest
{
    internal class Client
    {
        public int Id { get; set; }
        [Column("first_name")]
        public string? FirstName { get; set; }
        [Column("last_name")]
        public string? LastName { get; set; }
        [Column("telephone")]
        public string? Telephone { get; set; }
        [Column("email")]
        public string? Email { get; set; }
        [Column("login")]
        public string? Login { get; set; }
        [Column("password")]
        public string? Password { get; set; }

        public ICollection<Order> Orders { get; set; }

        public Client()
        {
            Orders = new List<Order>();
        }
    }
}