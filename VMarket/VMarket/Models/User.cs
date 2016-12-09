using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VMarket.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.EmailAddress)]
        [Index("User_Name:index", IsUnique =true)]
        [MaxLength (256, ErrorMessage ="El campo {0} debe ser menor a 256 Caracteres")]
        public String UserName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public String Nombre { get; set; }

        public String Apellido { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public String Direccion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public String Telefono { get; set; }

        public String Celular { get; set; }

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