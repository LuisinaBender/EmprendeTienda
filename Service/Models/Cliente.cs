using System.Text.Json.Serialization;

namespace Service.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public int LocalidadId { get; set; }
        public Localidad? Localidad { get; set; }

        [JsonIgnore]
        public List<Venta> Ventas { get; set; } = new List<Venta>();
    }
}

