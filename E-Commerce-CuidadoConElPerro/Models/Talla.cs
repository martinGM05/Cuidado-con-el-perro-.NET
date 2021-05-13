using System;
using System.Collections.Generic;

#nullable disable

namespace E_Commerce_CuidadoConElPerro.Models
{
    public partial class Talla
    {
        public Talla()
        {
            Prenda = new HashSet<Prendum>();
        }

        public int IdTalla { get; set; }
        public string NombreTalla { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Prendum> Prenda { get; set; }
    }
}
