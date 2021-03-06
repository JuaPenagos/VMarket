﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VMarket.Models
{
    public class VMarketContext : DbContext
    {
        public VMarketContext() : base("DefaultConnection")
    {

        }

        public System.Data.Entity.DbSet<VMarket.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<VMarket.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<VMarket.Models.State> States { get; set; }

        public System.Data.Entity.DbSet<VMarket.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<VMarket.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<VMarket.Models.Company> Companies { get; set; }

        public System.Data.Entity.DbSet<VMarket.Models.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<VMarket.Models.OrderDetail> OrderDetails { get; set; }

        public System.Data.Entity.DbSet<VMarket.Models.User> Users { get; set; }
    }
}