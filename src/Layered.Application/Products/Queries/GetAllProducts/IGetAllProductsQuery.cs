using Layered.Domain.Entities;

namespace Layered.Application.Products.Queries.GetAllProducts;

public interface IGetAllProductsQuery
{
    Task<IEnumerable<ProductEntity>> ExecuteAsync();
}
