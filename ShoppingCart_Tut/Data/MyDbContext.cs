using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ShoppingCart_Tut.Models;

namespace ShoppingCart_Tut.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("MyDbContext")
        {

        }

        public virtual DbSet<Product> products { get; set; }
    }
}