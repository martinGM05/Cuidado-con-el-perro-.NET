using System;
using System.Collections.Generic;

#nullable disable

namespace E_Commerce_CuidadoConElPerro.Models
{
    public partial class Prendum
    {
        public Prendum()
        {
            Carritos = new HashSet<Carrito>();
        }

        public int IdPrenda { get; set; }
        public string NombrePrenda { get; set; }
        public string Genero { get; set; }
        public decimal? Precio { get; set; }
        public int? Cantidad { get; set; }
        public string Descripcion { get; set; }
        public int? IdTalla { get; set; }
        public int? IdDepartamento { get; set; }
        public int? IdProovedor { get; set; }
        public string Imagen { get; set; }

        public virtual Departamento IdDepartamentoNavigation { get; set; }
        public virtual Proovedor IdProovedorNavigation { get; set; }
        public virtual Talla IdTallaNavigation { get; set; }
        public virtual ICollection<Carrito> Carritos { get; set; }
    }
}
