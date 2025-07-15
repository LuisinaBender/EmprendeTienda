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
        public virtual DbSet<DetalleVenta> DetallesVentas { get; set; }
        public virtual DbSet<Localidad> Localidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración del charset para MySQL
            modelBuilder.HasCharSet("utf8mb4");

            // Configuración de modelos y relaciones
            ConfigureModels(modelBuilder);

            // Datos semilla iniciales
            SeedInitialData(modelBuilder);
        }

        private void ConfigureModels(ModelBuilder modelBuilder)
        {
            // Configuración de Localidad
            modelBuilder.Entity<Localidad>(entity =>
            {
                entity.HasKey(l => l.Id);
                entity.Property(l => l.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            // Configuración de Cliente
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


                entity.HasOne(c => c.Localidad)
                    .WithMany(l => l.Clientes)
                    .HasForeignKey(c => c.LocalidadId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Configuración de Producto
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


            modelBuilder.Entity<Venta>(entity =>
            {
                entity.Property(v => v.Fecha)
                      .HasColumnType("timestamp") // Tipo timestamp acepta CURRENT_TIMESTAMP
                      .HasDefaultValueSql("CURRENT_TIMESTAMP");
        

            entity.HasOne(v => v.Cliente)
                    .WithMany(c => c.Ventas)
                    .HasForeignKey(v => v.ClienteId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Configuración de DetalleVenta
            modelBuilder.Entity<DetalleVenta>(entity =>
            {
                entity.HasKey(d => d.Id);

                entity.Property(d => d.Cantidad)
                    .IsRequired();

                entity.Property(d => d.PrecioUnitario)
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(d => d.Venta)
                    .WithMany(v => v.Detalles)
                    .HasForeignKey(d => d.VentaId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Producto)
                    .WithMany()
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }

        private void SeedInitialData(ModelBuilder modelBuilder)
        {
            // Orden IMPORTANTE: 1. Localidades, 2. Productos, 3. Clientes, 4. Ventas, 5. DetallesVenta

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

            // Ventas (con fechas explícitas para seed data)
            modelBuilder.Entity<Venta>().HasData(
                new Venta
                {
                    Id = 1,
                    ClienteId = 1,
                    Fecha = DateTime.Now.AddDays(-5)
                },
                new Venta
                {
                    Id = 2,
                    ClienteId = 2,
                    Fecha = DateTime.Now.AddDays(-3)
                },
                new Venta
                {
                    Id = 3,
                    ClienteId = 3,
                    Fecha = DateTime.Now.AddDays(-1)
                }
            );

            // DetallesVenta
            modelBuilder.Entity<DetalleVenta>().HasData(
                new DetalleVenta
                {
                    Id = 1,
                    VentaId = 1,
                    ProductoId = 1,
                    Cantidad = 1,
                    PrecioUnitario = 120000m
                },
                new DetalleVenta
                {
                    Id = 2,
                    VentaId = 1,
                    ProductoId = 2,
                    Cantidad = 2,
                    PrecioUnitario = 80000m
                },
                new DetalleVenta
                {
                    Id = 3,
                    VentaId = 2,
                    ProductoId = 3,
                    Cantidad = 3,
                    PrecioUnitario = 45000m
                }
            );
        }
    }
}