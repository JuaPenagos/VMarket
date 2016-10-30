using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VMarket.Models
{
    public class OrderDetail
    {

        [Key]
        public int OrderDetailId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int Cantidad { get; set; }

        public double Subtotal { get; set; }
    }
}