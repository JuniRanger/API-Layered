using AutoMapper;
using Layered.Application.Products.Commands.CreateProduct;
using Layered.Domain.Entities;

namespace Layered.Application.Configuration;

public class MapperProfile : Profile
{
/// <summary>
/// Las funciones de MapperProfile mapean ProductEntity y El modelo y viceversa
/// </summary>
    public MapperProfile() {
        CreateMap<ProductEntity, CreateProductModel>().ReverseMap();
    }
}
