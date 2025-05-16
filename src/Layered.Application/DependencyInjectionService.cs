using Layered.Application.Configuration;
using Layered.Application.Products.Commands.CreateProduct;
using Layered.Application.Products.Queries.GetAllProducts;
using Microsoft.Extensions.DependencyInjection;

namespace Layered.Application;

public static class DependencyInjectionService
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        //escanea el ensamblado de MapperProfile y registra todos los perfiles en automatico
        services.AddAutoMapper(typeof(MapperProfile).Assembly);


        //Registro de comandos
        services.AddTransient<ICreateProductCommand, CreateProductCommand>();

        // Registrar queries
        services.AddTransient<IGetAllProductsQuery, GetAllProductsQuery>();

        return services;
    }
}
