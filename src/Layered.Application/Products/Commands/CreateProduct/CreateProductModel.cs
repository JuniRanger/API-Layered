using System;

namespace Layered.Application.Products.Commands.CreateProduct;

public class CreateProductModel
{
    public required string Name { get; set; }
    public required double Price { get; set; }
}
