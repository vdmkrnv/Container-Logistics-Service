using Microsoft.EntityFrameworkCore;
using System.Configuration;

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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasKey(x => x.Id);
            modelBuilder.Entity<Order>().HasKey(x => new { x.Id, x.Port1Id, x.Port2Id });
            modelBuilder.Entity<Port>().HasKey(x => x.Id);
            modelBuilder.Entity<Containe>().HasKey(x => x.Id);

            modelBuilder.Entity<Port>().HasMany(x => x.OrdersInPort1).WithOne(e => e.Port1).HasForeignKey(x => x.Port1Id);
            modelBuilder.Entity<Port>().HasMany(x => x.OrdersInPort2).WithOne(e => e.Port2).HasForeignKey(x => x.Port2Id);
            modelBuilder.Entity<Client>().HasMany(x => x.Orders).WithOne(e => e.Client).HasForeignKey(x => x.ClientID);
            modelBuilder.Entity<Containe>().HasMany(x => x.Orders).WithMany(e => e.Containers);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConfigurationManager.AppSettings["ConnectStringDB"]);
        }
    }
}