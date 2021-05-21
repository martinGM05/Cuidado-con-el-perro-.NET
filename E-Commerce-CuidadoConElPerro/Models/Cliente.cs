using System;
using System.Collections.Generic;

#nullable disable

namespace E_Commerce_CuidadoConElPerro.Models
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string NomCliente { get; set; }
        public string Contrasenia { get; set; }
        public byte[] Imagen { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Domicilio { get; set; }
    }
}
