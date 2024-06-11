using Infrastructure.EntityFramework;
using Infrastructure.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using Services.Repositories.Abstractions;
using Services.Services.Abstractions;
using Services.Services.Implementations;
using Services.Services.Implementations.Mapping;

namespace WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services.AddControllers();

        // Конфигурация контекста EF Core
        DbContextService.ConfigureContext(builder.Services,
            builder.Configuration.GetConnectionString("DefaultConnectionString")!);
        builder.Services.AddScoped<DbContext, DataContext>();
        
        
        // Автомаппер
        builder.Services.AddAutoMapper(typeof(OrderMappingProfile), typeof(ContainerMappingProfile));
        
        // Репозитории
        builder.Services.AddScoped<IContainerRepository, ContainerRepository>();
        builder.Services.AddScoped<IOrderService, OrderService>();
        
        // Сервисы
        builder.Services.AddScoped<IOrderRepository, OrderRepository>();
        builder.Services.AddScoped<IContainerService, ContainerService>();
        
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.MapControllers();

        app.Run();
    }
}