using Microsoft.AspNetCore.Mvc;
using Layered.Application.Products;
using Layered.Domain.Interfaces;
using Layered.Application.Products.Commands.CreateProduct;

namespace Layered.Presentation.Controllers;

    [ApiController]
    [Route("/api/v1/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ICreateProductCommand _createProductCommand;

    public ProductsController(
        ICreateProductCommand createProductCommand
    )
    {
        _createProductCommand = createProductCommand;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProductModel request) {
        var createdProduct = await _createProductCommand.ExecuteAsync(request);
        return Ok(createdProduct);
    }
}
