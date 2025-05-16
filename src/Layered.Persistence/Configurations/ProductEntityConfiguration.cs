using Layered.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Layered.Persistence.Configurations
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        /// <summary>
        /// El metodo Configure inicializa la configuracion de una entidad de producto usando entity framework
        /// </summary>
        /// <param name="builder">
        /// El parametro `builder` es un objeto de tipo `EntityTypeBuilder<ProductEntity>` el cual es usado en entity framework para configurar el mapeo entre una entidad y una tabla en una base de datos
        /// </param>
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            // Definir la clave primaria
            builder.HasKey(p => p.ProductId);

            // Configurar propiedades (required, max length, etc)
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Price)
                .IsRequired();
        }
    }
}
