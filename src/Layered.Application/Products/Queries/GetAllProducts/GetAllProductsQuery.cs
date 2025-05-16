using Layered.Domain.Entities;
using Layered.Domain.Interfaces;

namespace Layered.Application.Products.Queries.GetAllProducts;

public class GetAllProductsQuery : IGetAllProductsQuery
{
    private readonly IProductRepository _productRepository;

    public GetAllProductsQuery(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IEnumerable<ProductEntity>> ExecuteAsync()
    {
        return await _productRepository.GetAllProductsAsync();
    }
}
