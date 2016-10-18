using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VMarket.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Display(Name = "Ciudad")]
        public String Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}