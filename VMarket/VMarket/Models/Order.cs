using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VMarket.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime Fecha { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}