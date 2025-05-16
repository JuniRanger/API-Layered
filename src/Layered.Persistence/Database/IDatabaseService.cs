using System;
using Layered.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Layered.Persistence.Database;

public interface IDatabaseService
{
    public DbSet<ProductEntity> Products {get; set;}
    public Task<bool> SaveAsync();
}
