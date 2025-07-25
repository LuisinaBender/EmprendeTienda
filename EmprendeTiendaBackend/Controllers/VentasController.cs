using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendEmprendeTienda.DataContext;
using Service.Models;

namespace BackendEmprendeTienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VentasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("Ventas endpoint OK");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Venta>>> GetVentas()
        {
            try
            {
                var ventas = await _context.Ventas
                    .Include(v => v.Cliente)
                        .ThenInclude(c => c.Localidad)
                    .ToListAsync();
                return ventas;
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al obtener ventas: {ex.Message} | Inner: {ex.InnerException?.Message}");
            }
        }

        [HttpGet("concliente")]
        public async Task<ActionResult<IEnumerable<Venta>>> GetVentasConCliente()
        {
            try
            {
                var ventas = await _context.Ventas
                    .Include(v => v.Cliente)
                    .ToListAsync();
                return ventas;
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al obtener ventas con Cliente: {ex.Message} | Inner: {ex.InnerException?.Message}");
            }
        }

        [HttpGet("completo")]
        public async Task<ActionResult<IEnumerable<Venta>>> GetVentasCompleto()
        {
            try
            {
                var ventas = await _context.Ventas
                    .Include(v => v.Cliente)
                        .ThenInclude(c => c.Localidad)
                    .ToListAsync();
                return ventas;
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al obtener ventas completo: {ex.Message} | Inner: {ex.InnerException?.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Venta>> GetVenta(int id)
        {
            try
            {
                var venta = await _context.Ventas
                    .Include(v => v.Cliente)
                        .ThenInclude(c => c.Localidad)
                    .FirstOrDefaultAsync(v => v.Id == id);

                if (venta == null)
                    return NotFound();

                return venta;
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al obtener venta por id: {ex.Message} | Inner: {ex.InnerException?.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutVenta(int id, Venta venta)
        {

            if (id != venta.Id)
                return BadRequest();

            _context.Entry(venta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VentaExists(id))
                    return NotFound();
                else
                    throw;
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar venta: {ex.Message} | Inner: {ex.InnerException?.Message}");
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Venta>> PostVenta(Venta venta)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                _context.Ventas.Add(venta);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetVenta", new { id = venta.Id }, venta);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al crear venta: {ex.Message} | Inner: {ex.InnerException?.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVenta(int id)
        {
            try
            {
                var venta = await _context.Ventas.FindAsync(id);
                if (venta == null)
                    return NotFound();

                _context.Ventas.Remove(venta);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al eliminar venta: {ex.Message} | Inner: {ex.InnerException?.Message}");
            }
        }

        private bool VentaExists(int id)
        {
            return _context.Ventas.Any(e => e.Id == id);
        }
    }
}
