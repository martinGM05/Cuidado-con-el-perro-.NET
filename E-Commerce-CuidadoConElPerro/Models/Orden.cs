using System;
using System.Collections.Generic;

#nullable disable

namespace E_Commerce_CuidadoConElPerro.Models
{
    public partial class Orden
    {
        public int IdOrden { get; set; }
        public int? IdCliente { get; set; }
        public int? IdMetodoPago { get; set; }
        public int? IdCarrito { get; set; }
        public decimal? Total { get; set; }
        public DateTime? FechaHora { get; set; }

        public virtual Carrito IdCarritoNavigation { get; set; }
        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual MetodoPago IdMetodoPagoNavigation { get; set; }
    }
}
