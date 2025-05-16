using Microsoft.AspNetCore.Mvc;
using Layered.Application.Products;
using Layered.Domain.Interfaces;
using Layered.Application.Products.Commands.CreateProduct;
using Layered.Application.Products.Queries.GetAllProducts;

namespace Layered.Presentation.Controllers;

    [ApiController]
    [Route("/api/v1/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ICreateProductCommand _createProductCommand;
    private readonly IGetAllProductsQuery _getAllProductsQuery;

    public ProductsController(
        ICreateProductCommand createProductCommand,
        IGetAllProductsQuery getAllProductsQuery
    )
    {
        _createProductCommand = createProductCommand;
        _getAllProductsQuery = getAllProductsQuery;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProductModel request) {
        var createdProduct = await _createProductCommand.ExecuteAsync(request);
        return Ok(createdProduct);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _getAllProductsQuery.ExecuteAsync();
        return Ok(products);
    }
}
