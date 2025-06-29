namespace Service.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;

        public int LocalidadId { get; set; }
        public Localidad? Localidad { get; set; }
        public List<Venta> Ventas { get; set; } = new List<Venta>();

        // El constructor puede estar vacío, o incluso puedes eliminarlo
        public Cliente() { }
    }
}
