using AutoMapper;
using Layered.Application.Configuration;
using Layered.Application.Products.Commands.CreateProduct;
using Microsoft.Extensions.DependencyInjection;

namespace Layered.Application;

public static class DependencyInjectionService
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        //escanea el ensamblado de MapperProfile y registra todos los perfiles en automatico
        services.AddAutoMapper(typeof(MapperProfile).Assembly);

        services.AddTransient<ICreateProductCommand, CreateProductCommand>();

        return services;
    }
}
