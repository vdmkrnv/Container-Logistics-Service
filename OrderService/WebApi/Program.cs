using WebApi.Extensions;
using WebApi.Middlewares;

namespace WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var services = builder.Services;
        
        services.AddControllers();

        // Extensions
        services.AddDataContext(builder.Configuration
            .GetConnectionString("DefaultConnectionString")!);
        services.AddSwagger();
        services.AddValidation();
        services.AddMappers();
        services.AddServices();
        services.AddRepositories();
        services.AddVersioning();
        services.AddExceptionHandling();
        services.ConfigureMassTransit(builder.Configuration);
        services.AddTelemetry();
        
        var app = builder.Build();

        app.UseMiddleware<ExceptionHandlerMiddleware>();
        
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseHttpsRedirection();

        app.MapPrometheusScrapingEndpoint();

        app.MapControllers();
        app.Run();
    }
}