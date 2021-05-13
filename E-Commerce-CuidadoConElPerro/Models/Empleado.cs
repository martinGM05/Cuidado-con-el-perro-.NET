using System;
using System.Collections.Generic;

#nullable disable

namespace E_Commerce_CuidadoConElPerro.Models
{
    public partial class Empleado
    {
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
        public byte[] Imagen { get; set; }
        public int? IdRol { get; set; }

        public virtual Rol IdRolNavigation { get; set; }
    }
}
