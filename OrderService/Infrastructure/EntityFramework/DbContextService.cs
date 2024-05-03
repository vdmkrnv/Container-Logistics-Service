
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.EntityFramework;

public static class DbContextService
{
    public static IServiceCollection ConfigureContext(this IServiceCollection services, 
        string connectionString)
    {
        services.AddDbContext<DataContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });
        return services;
    }
}