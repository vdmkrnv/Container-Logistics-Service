using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntityFramework;

public class DataContext : DbContext
{
	public DbSet<Container> Containers { get; set; }

	public DataContext() { }

	public DataContext(DbContextOptions<DataContext> options) : base(options)
	{
		// Database.EnsureDeleted();
		// Database.EnsureCreated();
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		//modelBuilder.Ignore<Container>();
	}
}