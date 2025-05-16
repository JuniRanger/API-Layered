using System;
using AutoMapper;
using Layered.Domain.Entities;
using Layered.Domain.Interfaces;

namespace Layered.Application.Products.Commands.UpdateProduct;

public class UpdateProductCommand
{
    private readonly IProductRepository _repository;
    private readonly IMapper _mapper;

    public UpdateProductCommand(IProductRepository productRepository, IMapper mapper){
        _repository = productRepository;
        _mapper = mapper;
    }

    //TODO: Implementar metodo de ejecucion para el comando de actualización

    // public async Task<ProductEntity> ExecuteAsync(UpdateProductCommand product) {
    //     var entity = await _repository.GetAsync(product.Id);
    // }
}
