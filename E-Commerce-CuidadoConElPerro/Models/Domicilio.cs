using System;
using System.Collections.Generic;

#nullable disable

namespace E_Commerce_CuidadoConElPerro.Models
{
    public partial class Domicilio
    {
        public Domicilio()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int IdDomicilio { get; set; }
        public string Calle { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public int? NumeroExt { get; set; }
        public int? NumeroInt { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
