using Layered.Domain.Entities;
using Layered.Domain.Interfaces;
using Layered.Persistence.Database;
using Microsoft.EntityFrameworkCore;

namespace Layered.Persistence.Repositories;


public class ProductRepository : IProductRepository
{
    private readonly DatabaseService _context;

    public ProductRepository(DatabaseService context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ProductEntity>> GetAllProductsAsync()
    {
        return await _context.Products.ToListAsync<ProductEntity>();
    }

    public async Task<ProductEntity?> GetProductByIdAsync(int id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task<ProductEntity> CreateProductAsync(ProductEntity product)
    {
        _context.Products.Add(product);
        await _context.SaveAsync();
        return product;
    }

    public async Task<ProductEntity?> UpdateProductAsync(ProductEntity product)
    {
        var existingProduct = await _context.Products.FindAsync(product.ProductId);
        if (existingProduct == null) return null;

        existingProduct.Name = product.Name;
        existingProduct.Price = product.Price;
        await _context.SaveAsync();

        return existingProduct;
    }

    public async Task<bool> DeleteProductAsync(int id) {
        var product = await _context.Products.FindAsync();
        if (product == null) return false;

        _context.Products.Remove(product);
        await _context.SaveAsync();

        return true;
    }
}
