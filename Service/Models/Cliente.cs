﻿namespace Service.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        required public string Nombre { get; set; }
        required public string Apellido { get; set; }
        required public string Email { get; set; }

       
    }
}

