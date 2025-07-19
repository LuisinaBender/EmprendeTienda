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
        public async Task<ActionResult<IEnumerable<DetalleVenta>>> GetDetalleVentas()
        {
            var detalles = await _context.DetalleVentas
                .Include(d => d.Producto)
                .Include(d => d.Venta)
                    .ThenInclude(v => v.Cliente)
                        .ThenInclude(c => c.Localidad)
                .ToListAsync();

            return Ok(detalles);
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
