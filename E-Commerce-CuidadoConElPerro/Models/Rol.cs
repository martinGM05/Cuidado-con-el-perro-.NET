using System;
using System.Collections.Generic;

#nullable disable

namespace E_Commerce_CuidadoConElPerro.Models
{
    public partial class Rol
    {
        public Rol()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int IdRol { get; set; }
        public string Usuario { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
