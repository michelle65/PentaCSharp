using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sales_Database.Models
{
    public class Product
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }


    }
}