using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sales_Database.Models
{
    public class Customer
    {

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string CreditCardNumber { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }

    }
}