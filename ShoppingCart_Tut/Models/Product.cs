using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart_Tut.Models
{
    public class Product
    {
        public int ProdId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}