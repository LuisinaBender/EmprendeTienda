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

        // OPCIONAL: otros métodos para crear, editar y eliminar si querés agregar más adelante.
    }
}
