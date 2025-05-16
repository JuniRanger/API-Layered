using AutoMapper;
using Layered.Application.Products.Commands.CreateProduct;
using Layered.Domain.Entities;

namespace Layered.Application.Configuration;

public class MapperProfile : Profile
{
    public MapperProfile() {
        CreateMap<ProductEntity, CreateProductModel>().ReverseMap();
    }
}
