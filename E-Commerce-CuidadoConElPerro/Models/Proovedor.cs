using System;
using System.Collections.Generic;

#nullable disable

namespace E_Commerce_CuidadoConElPerro.Models
{
    public partial class Proovedor
    {
        public Proovedor()
        {
            Prenda = new HashSet<Prendum>();
        }

        public int IdProovedor { get; set; }
        public string NombreProovedor { get; set; }
        public string Telefono { get; set; }

        public virtual ICollection<Prendum> Prenda { get; set; }
    }
}
