using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sales_Database.Models
{
    public class StoreLocation
    {

        public int StoreLocationId { get; set; }
        public string LocationName { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}