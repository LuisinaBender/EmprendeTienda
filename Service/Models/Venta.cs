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

        public Cliente? Cliente { get; set; }

       public virtual ICollection<DetalleVenta> DetalleVentas { get; set; } = new List<DetalleVenta>();
       
    }
}
