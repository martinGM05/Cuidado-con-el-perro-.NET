using System;
using System.Collections.Generic;

#nullable disable

namespace E_Commerce_CuidadoConElPerro.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Carritos = new HashSet<Carrito>();
            Ordens = new HashSet<Orden>();
        }

        public int IdCliente { get; set; }
        public string NomCliente { get; set; }
        public string Contrasenia { get; set; }
        public byte[] Imagen { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Domicilio { get; set; }

        public virtual ICollection<Carrito> Carritos { get; set; }
        public virtual ICollection<Orden> Ordens { get; set; }
    }
}
