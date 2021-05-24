using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace E_Commerce_CuidadoConElPerro.Models
{
    public partial class Empleado
    {
        public int IdEmpleado { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio ")]
        public string NombreEmpleado { get; set; }
        [Required(ErrorMessage = "El usuario es obligatorio ")]
        public string Usuario { get; set; }
        [StringLength(6, ErrorMessage = "La contraseña solo acepta 6 caracteres")]
        public string Contrasenia { get; set; }
        public byte[] Imagen { get; set; }
        public int? IdRol { get; set; }

        public virtual Rol IdRolNavigation { get; set; }
    }
}
