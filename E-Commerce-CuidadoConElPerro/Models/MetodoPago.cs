﻿using System;
using System.Collections.Generic;

#nullable disable

namespace E_Commerce_CuidadoConElPerro.Models
{
    public partial class MetodoPago
    {
        public MetodoPago()
        {
            Ordens = new HashSet<Orden>();
        }

        public int IdMetodoPago { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Orden> Ordens { get; set; }
    }
}
