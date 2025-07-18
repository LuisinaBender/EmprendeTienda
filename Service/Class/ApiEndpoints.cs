using Service.Models;
using System;

namespace Service.Class
{
    public static class ApiEndpoints
    {
        public static string Cliente { get; set; } = "clientes";
        public static string Localidad { get; set; } = "localidades";
        public static string Producto { get; set; } = "productos";
        public static string Venta { get; set; } = "ventas";
        public static string DetalleVenta { get; set; } = "detalleventas"; 

        public static string GetEndpoint(string name)
        {
            return name switch
            {
                "Cliente" => Cliente,
                "Localidad" => Localidad,
                "Producto" => Producto,
                "Venta" => Venta,
                "DetalleVenta" => DetalleVenta, 
                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }
    }
}