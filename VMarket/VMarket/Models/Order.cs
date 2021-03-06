﻿using System;
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

        public int StateId { get; set; }

        public virtual State State { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}