using Microsoft.EntityFrameworkCore;

namespace DBTest
{
    internal class ContainerContext : DbContext
    {
        public ContainerContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Port> Ports { get; set; }
        public DbSet<Containe> Containers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ContainerService;Username=postgres;Password=admin.123");
        }

    }
}
