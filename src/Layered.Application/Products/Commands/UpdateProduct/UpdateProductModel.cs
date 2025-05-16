using System;

namespace Layered.Application.Products.Commands.UpdateProduct;

public class UpdateProductModel
{
    public int ProductId { get; set; }
    public required string Name { get; set;}
    public double Price { get; set; }

}
