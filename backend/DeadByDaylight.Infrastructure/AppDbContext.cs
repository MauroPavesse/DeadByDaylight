using DeadByDaylight.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeadByDaylight.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Rol> Roles => Set<Rol>();
    public DbSet<Personaje> Personajes => Set<Personaje>();
    public DbSet<Ventaja> Ventajas => Set<Ventaja>();
    public DbSet<Categoria> Categorias => Set<Categoria>();
    public DbSet<VentajaCategoria> VentajasCategorias => Set<VentajaCategoria>();
}
