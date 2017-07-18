namespace ConsoleEntityFramework.ModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer")]
    public partial class Buyer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? PersonId { get; set; }

        public int? ProducerId { get; set; }

        public virtual Person Person { get; set; }

        public virtual Producer Producer { get; set; }
    }
}
