using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sales_Database.Models
{
    public class Sale
    {

        public int SaleId { get; set; }

        public String Date { get; set; }

        [Required()]
        public int CustomerId { get; set; }

        [Required()]
        public int ProductId { get; set; }

        [Required()]
        public int StoreLocationId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [ForeignKey("StoreLocationId")]
        public StoreLocation StoreLocation { get; set; }
    }
}