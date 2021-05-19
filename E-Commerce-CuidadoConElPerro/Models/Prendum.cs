using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage ="El nombre es obligatorio")]
        [MinLength(5, ErrorMessage = "El nombre debe tener al menos 3 caracteres")]
        public string NombrePrenda { get; set; }
        [Required(ErrorMessage = "El género es obligatorio")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "El precio es obligatorio")]
        [Range(1,100000, ErrorMessage = "Debe ser entre 1 y 1000000")]
        public decimal? Precio { get; set; }
        [Required(ErrorMessage = "La cantidad es obligatorio")]
        [Range(1, 100000, ErrorMessage = "Debe ser entre 1 y 1000000")]
        public int? Cantidad { get; set; }
        [Required(ErrorMessage = "La descripción es obligatorio")]
        [MinLength(5, ErrorMessage = "La descripción debe tener al menos 3 caracteres")]
        public string Descripcion { get; set; }

        public int? IdTalla { get; set; }
        public int? IdDepartamento { get; set; }
        public int? IdProovedor { get; set; }
        public byte[] Imagen { get; set; }

        public virtual Departamento IdDepartamentoNavigation { get; set; }
        public virtual Proovedor IdProovedorNavigation { get; set; }
        public virtual Talla IdTallaNavigation { get; set; }
        public virtual ICollection<Carrito> Carritos { get; set; }
    }
}
