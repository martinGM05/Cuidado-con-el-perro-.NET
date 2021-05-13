using System;
using System.Collections.Generic;

#nullable disable

namespace E_Commerce_CuidadoConElPerro.Models
{
    public partial class Carrito
    {
        public Carrito()
        {
            Ordens = new HashSet<Orden>();
        }

        public int IdCarrito { get; set; }
        public int? IdCliente { get; set; }
        public int? IdPrenda { get; set; }
        public int? Cantidad { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Prendum IdPrendaNavigation { get; set; }
        public virtual ICollection<Orden> Ordens { get; set; }
    }
}
