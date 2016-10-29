using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VMarket.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Display(Name = "Nombre")]
        public String Nombre { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public Boolean Estado { get; set; }

        public int CantidadMax { get; set; }

        public int CantidadMin { get; set; }


        public String CodigoBarras { get; set; }

        public String Imagen { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImagenFile { get; set; }

        [Required]
        public Decimal Precio { get; set; }
        //Pendiente Promociones

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}