namespace ConsoleEntityFramework.ModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Seller")]
    public partial class Seller
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int PersonId { get; set; }

        [Column("DealerShip Address")]
        [Required]
        [StringLength(100)]
        public string DealerShip_Address { get; set; }

        [StringLength(50)]
        public string WorkPhone { get; set; }

        public virtual Person Person { get; set; }
    }
}
