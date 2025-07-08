using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Service.Class
{
    public static class ApiEndpoints
    {
        public static string Cliente { get; set; } = "clientes";
        public static string DetalleVenta { get; set; } = "detallesVentas";
        public static string Localidad { get; set; } = "localidades";
        public static string Producto { get; set; } = "productos";
        public static string Venta { get; set; } = "ventas";

        public static string GetEndpoint(string name)
        {
            return name switch
            {
                "Cliente" => Cliente,
                "DetalleVenta" => DetalleVenta,
                "Localidad" => Localidad,
                "Producto" => Producto,
                "Venta" => Venta,
                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }
    }
}

