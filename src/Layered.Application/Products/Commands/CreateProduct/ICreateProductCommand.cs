using System;
using Layered.Domain.Entities;

namespace Layered.Application.Products.Commands.CreateProduct;

public interface ICreateProductCommand
{
    Task<ProductEntity> ExecuteAsync(CreateProductModel model);
}
