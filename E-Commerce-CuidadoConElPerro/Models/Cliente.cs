using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace E_Commerce_CuidadoConElPerro.Models
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio ")]
        public string NomCliente { get; set; }
        [StringLength(30, ErrorMessage = "La contraseña solo acepta 30 caracteres")]
        public string Contrasenia { get; set; }
        public byte[] Imagen { get; set; }
        [Required(ErrorMessage = "El telefono es obligatorio ")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio ")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El domicilio es obligatorio ")]
        public string Domicilio { get; set; }
    }
}
