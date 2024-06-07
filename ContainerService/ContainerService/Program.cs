
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace ContainerService
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllers();
			
			// Конфигурация контекста EF Core
			DataContextService.ConfigureContext(builder.Services,
				builder.Configuration.GetConnectionString("DefaultConnectionString")!);
			builder.Services.AddScoped<DbContext, DataContext>();
			
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
}
