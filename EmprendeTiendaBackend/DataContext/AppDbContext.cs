using Microsoft.EntityFrameworkCore;
using Service.Models;
using System;

namespace BackendEmprendeTienda.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<Localidad> Localidades { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4");
            ConfigureModels(modelBuilder);
            SeedInitialData(modelBuilder);
        }

        private void ConfigureModels(ModelBuilder modelBuilder)
        {
            // Localidad
            modelBuilder.Entity<Localidad>(entity =>
            {
                entity.HasKey(l => l.Id);
                entity.Property(l => l.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            // Cliente
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.Property(c => c.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(c => c.Apellido)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(c => c.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(c => c.Telefono)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(c => c.Direccion)
                    .IsRequired()
                    .HasMaxLength(200);

                //entity.HasOne(c => c.Localidad)
                //    .WithMany(l => l.Clientes)
                //    .HasForeignKey(c => c.LocalidadId)
                //    .OnDelete(DeleteBehavior.Restrict);
            });

            // Producto
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(p => p.Id);

                entity.Property(p => p.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(p => p.Descripcion)
                    .HasMaxLength(500);

                entity.Property(p => p.Precio)
                    .HasColumnType("decimal(18,2)");

                entity.Property(p => p.Stock)
                    .HasDefaultValue(0);
            });

            // Venta
            modelBuilder.Entity<Venta>(entity =>
            {
                entity.Property(v => v.Fecha)
                      .HasColumnType("timestamp")
                      .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(v => v.Cliente)
                        .WithMany(c => c.Ventas)
                        .HasForeignKey(v => v.ClienteId)
                        .OnDelete(DeleteBehavior.Restrict);
            });

            // DetalleVenta
            modelBuilder.Entity<DetalleVenta>(entity =>
            {
                entity.HasKey(dv => dv.Id);

                entity.Property(dv => dv.Cantidad)
                    .IsRequired();

                entity.Property(dv => dv.PrecioUnitario)
                    .HasColumnType("decimal(18,2)")
                    .IsRequired();

                entity.HasOne(dv => dv.Venta)
                    .WithMany(v => v.DetalleVentas)
                    .HasForeignKey(dv => dv.VentaId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(dv => dv.Producto)
                    .WithMany(p => p.DetalleVentas)
                    .HasForeignKey(dv => dv.ProductoId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }

        private void SeedInitialData(ModelBuilder modelBuilder)
        {
            // Localidades
            modelBuilder.Entity<Localidad>().HasData(
                new Localidad { Id = 1, Nombre = "Capital" },
                new Localidad { Id = 2, Nombre = "Güemes" },
                new Localidad { Id = 3, Nombre = "Rivadavia" }
            );

            // Productos
            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    Id = 1,
                    Nombre = "Laptop Gamer",
                    Descripcion = "Laptop de alto rendimiento para juegos",
                    Precio = 120000m,
                    Stock = 10
                },
                new Producto
                {
                    Id = 2,
                    Nombre = "Smartphone",
                    Descripcion = "Teléfono inteligente de última generación",
                    Precio = 80000m,
                    Stock = 15
                },
                new Producto
                {
                    Id = 3,
                    Nombre = "Tablet",
                    Descripcion = "Tablet con pantalla HD",
                    Precio = 45000m,
                    Stock = 8
                }
            );

            // Clientes
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente
                {
                    Id = 1,
                    Nombre = "Juan",
                    Apellido = "Pérez",
                    Email = "juan@example.com",
                    Direccion = "Calle Falsa 123",
                    Telefono = "3815123456",
                    LocalidadId = 1
                },
                new Cliente
                {
                    Id = 2,
                    Nombre = "María",
                    Apellido = "Gómez",
                    Email = "maria@example.com",
                    Direccion = "Avenida Siempre Viva 456",
                    Telefono = "3815234567",
                    LocalidadId = 2
                },
                new Cliente
                {
                    Id = 3,
                    Nombre = "Carlos",
                    Apellido = "López",
                    Email = "carlos@example.com",
                    Direccion = "Boulevard de los Sueños Rotos 789",
                    Telefono = "3815345678",
                    LocalidadId = 3
                }
            );

            // Ventas
            modelBuilder.Entity<Venta>().HasData(
                new Venta
                {
                    Id = 1,
                    ClienteId = 1
                },
                new Venta
                {
                    Id = 2,
                    ClienteId = 2
                },
                new Venta
                {
                    Id = 3,
                    ClienteId = 3
                }
            );

            // DetalleVentas
            modelBuilder.Entity<DetalleVenta>().HasData(
                new DetalleVenta
                {
                    Id = 1,
                    VentaId = 1,
                    ProductoId = 1,
                    Cantidad = 2,
                    PrecioUnitario = 120000m
                },
                new DetalleVenta
                {
                    Id = 2,
                    VentaId = 2,
                    ProductoId = 2,
                    Cantidad = 1,
                    PrecioUnitario = 80000m
                },
                new DetalleVenta
                {
                    Id = 3,
                    VentaId = 3,
                    ProductoId = 3,
                    Cantidad = 3,
                    PrecioUnitario = 45000m
                }
            );
        }
    }
}