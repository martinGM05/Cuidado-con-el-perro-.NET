using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MinLength(5, ErrorMessage = "El nombre debe tener al menos 3 caracteres")]
        public string NomCliente { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [StringLength(6, ErrorMessage = "La contraseña solo acepta 6 caracteres")]
        [MinLength(3,ErrorMessage = "La contraseña debe tener al menos 6 caracteres")]
        public string Contrasenia { get; set; }
        [Required(ErrorMessage = "La imagen es obligatoria")]
        public byte[] Imagen { get; set; }
        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El domicilio es obligatorio")]
        public string Domicilio { get; set; }

        public virtual ICollection<Carrito> Carritos { get; set; }
        public virtual ICollection<Orden> Ordens { get; set; }
    }
}
