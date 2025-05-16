using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Layered.Domain.Entities;

[Table("Productos")]
public class ProductEntity
{
    public int ProductId { get; set; }
    public required string Name { get; set; }
    public required double Price { get; set; }
}
