using System;
using System.Collections.Generic;

#nullable disable

namespace E_Commerce_CuidadoConElPerro.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            Prenda = new HashSet<Prendum>();
        }

        public int IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; }
        public byte[] Imagen { get; set; }

        public virtual ICollection<Prendum> Prenda { get; set; }
    }
}
