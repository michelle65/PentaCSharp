namespace ConsoleEntityFramework.ModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? PersonId { get; set; }

        public int? CarId { get; set; }

        public virtual Car Car { get; set; }

        public virtual Person Person { get; set; }
    }
}
