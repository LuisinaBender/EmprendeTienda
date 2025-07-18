using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class Venta
    {
        public int Id { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int ClienteId { get; set; }

        // No requerido al crear, pero sí útil al obtener
        public Cliente? Cliente { get; set; }

        public ICollection<DetalleVenta> DetalleVentas { get; set; } = new List<DetalleVenta>();
    }
}
