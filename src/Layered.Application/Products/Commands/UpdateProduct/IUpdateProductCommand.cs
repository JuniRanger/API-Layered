using System;
using Layered.Domain.Entities;

namespace Layered.Application.Products.Commands.UpdateProduct;

public interface IUpdateProductCommand
{
    Task<ProductEntity> ExecuteAsync(UpdateProductCommand product);
}
