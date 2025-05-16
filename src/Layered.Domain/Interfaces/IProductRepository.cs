using Layered.Domain.Entities;

namespace Layered.Domain.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<ProductEntity>> GetAllProductsAsync();
    Task<ProductEntity?> GetProductByIdAsync(int id);
    Task<ProductEntity> CreateProductAsync(ProductEntity product);
    Task<ProductEntity?> UpdateProductAsync(ProductEntity product);
    Task<bool> DeleteProductAsync(int id);
}
