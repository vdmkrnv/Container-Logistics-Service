using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntityFramework;

/// <summary>
/// Контекст для работы с EFCore
/// </summary>
public class DataContext : DbContext
{
	public DbSet<Container> Containers { get; set; }

	public DataContext() { }

	public DataContext(DbContextOptions<DataContext> options) : base(options)
	{
		
	}
}