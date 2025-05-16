using System;
using Layered.Domain.Entities;
using Layered.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Layered.Persistence.Database;


public class DatabaseService : DbContext, IDatabaseService
{
    /// <param name="options">Opciones de configuración para el contexto de base de datos que determinan
    /// cómo se comportará la conexión y qué características estarán disponibles</param>
    public DatabaseService(DbContextOptions<DatabaseService> options) : base(options) { }

    public DbSet<ProductEntity> Products { get; set; }

    public async Task<bool> SaveAsync() {
        return await SaveChangesAsync() > 0;
    }

    /// <summary>
    /// Método que se ejecuta cuando se está creando el modelo de la base de datos.
    /// Este método es fundamental en Entity Framework Core ya que permite configurar
    /// cómo las entidades se mapean a las tablas de la base de datos, definir relaciones,
    /// establecer restricciones y aplicar configuraciones personalizadas.
    /// </summary>
    /// <param name="modelBuilder">Objeto que proporciona una API fluida para configurar el modelo de la base de datos.
    /// Permite definir la estructura de las entidades, sus relaciones, índices, restricciones y cualquier otra
    /// configuración necesaria para el correcto funcionamiento del modelo de datos.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        EntityConfiguration(modelBuilder);
    }

    /// <summary>
    /// Aplica las configuraciones específicas para cada entidad del modelo.
    /// </summary>
    /// <param name="modelBuilder">Objeto que permite aplicar las configuraciones definidas para cada entidad.
    /// A través de este parámetro, se pueden aplicar las configuraciones específicas de cada entidad,
    /// como las definidas en ProductEntityConfiguration, que establecen las reglas de mapeo,
    /// validaciones y restricciones para cada entidad en la base de datos.</param>
    private static void EntityConfiguration(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
    }
}
