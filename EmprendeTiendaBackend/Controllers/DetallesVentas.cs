using BackendEmprendeTienda.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendEmprendeTienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleVentasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DetalleVentasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/detalleventas
        [HttpGet]
        public async Task<ActionResult> GetDetalleVentas()
        {
            try
            {
                var detalles = await _context.DetalleVentas
                    .Include(d => d.Producto)
                    .Include(d => d.Venta)
                        .ThenInclude(v => v.Cliente)
                            .ThenInclude(c => c.Localidad)
                    .Select(d => new
                    {
                        d.Id,
                        d.Cantidad,
                        d.PrecioUnitario,
                        d.ProductoId,
                        Producto = d.Producto == null ? null : new
                        {
                            d.Producto.Id,
                            d.Producto.Nombre,
                            d.Producto.Precio,
                            d.Producto.Stock
                        },
                        d.VentaId,
                        Venta = d.Venta == null ? null : new
                        {
                            d.Venta.Id,
                            d.Venta.Fecha,
                            Cliente = d.Venta.Cliente == null ? null : new
                            {
                                d.Venta.Cliente.Id,
                                d.Venta.Cliente.Nombre,
                                d.Venta.Cliente.Apellido,
                                Localidad = d.Venta.Cliente.Localidad == null ? null : new
                                {
                                    d.Venta.Cliente.Localidad.Id,
                                    d.Venta.Cliente.Localidad.Nombre
                                }
                            }
                        }
                    })
                    .ToListAsync();

                return Ok(detalles);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error en API DetalleVentas: {ex.Message}");
            }
        }



        // POST: api/detalleventas
        [HttpPost]
        public async Task<ActionResult<DetalleVenta>> PostDetalleVenta(DetalleVenta detalle)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.DetalleVentas.Add(detalle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalleVenta", new { id = detalle.Id }, detalle);
        }


    }
}
