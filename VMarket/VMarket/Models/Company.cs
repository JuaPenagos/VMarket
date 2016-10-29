using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VMarket.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Display(Name = "Nombre")]
        public String Nombre { get; set; }

        [Required]
        public String Direccion { get; set; }

        [Required]
        public String Telefono { get; set; }

        public String Email { get; set; }

        public String RazonSocial { get; set; }

        public String Nit { get; set; }

        public String Imagen { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImagenFile { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        [NotMapped]
        public int DepartmentId { get; set; }

        [NotMapped]
        public virtual Department Department { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int CityId { get; set; }

        public virtual City City { get; set; }


    }
}