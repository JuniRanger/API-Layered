using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Layered.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using Layered.Domain.Interfaces;
using Layered.Persistence.Repositories;

namespace Layered.Persistence;

public static class DependencyInjectionService
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration) 
    { 
        /* 
        Este metodo añade un contexto de la base de datos al contenedor de inyeccion de dependencias usando entity framework
        */
        services.AddDbContext<DatabaseService>(options => options.UseNpgsql(
            configuration.GetConnectionString("SQLConnectionString")
        ));

        /* Registra un servicio en el contenedor de inyección de depencencias, cada vez que se llama la interfaz del servicio de db, se tiene que proveer un servicio de base de datos */
        services.AddScoped<IDatabaseService>(provider => 
            provider.GetRequiredService<DatabaseService>()
        );

        services.AddScoped<IProductRepository, ProductRepository>();
        return services;
    }
}