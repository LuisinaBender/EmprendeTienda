using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es Obligatorio")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public ICollection<DetalleVenta> DetalleVentas { get; set; } = new List<DetalleVenta>();
        public decimal Cantidad { get; set; }
    }
}

