using System;
using AutoMapper;
using Layered.Domain.Entities;
using Layered.Domain.Interfaces;

namespace Layered.Application.Products.Commands.CreateProduct;

public class CreateProductCommand : ICreateProductCommand
{
    private readonly IProductRepository _repository;
    private readonly IMapper _mapper;

    public CreateProductCommand(IProductRepository repository, IMapper mapper) {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ProductEntity> ExecuteAsync(CreateProductModel model) 
    {
        var entity = _mapper.Map<ProductEntity>(model);
        return await _repository.CreateProductAsync(entity);
    }
}
