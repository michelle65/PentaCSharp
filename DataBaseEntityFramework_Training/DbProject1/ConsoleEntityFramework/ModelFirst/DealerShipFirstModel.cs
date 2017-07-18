namespace ConsoleEntityFramework.ModelFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DealerShipFirstModel : DbContext
    {
        public DealerShipFirstModel()
            : base("name=DealerShipFirstModel")
        {
        }

        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .Property(e => e.Type)
                .IsFixedLength();

            modelBuilder.Entity<Car>()
                .Property(e => e.Engine)
                .IsFixedLength();

            modelBuilder.Entity<Car>()
                .Property(e => e.Fuel)
                .IsFixedLength();

            modelBuilder.Entity<Car>()
                .Property(e => e.Color)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.BirthDate)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Sellers)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Producer>()
                .Property(e => e.Location)
                .IsFixedLength();

            modelBuilder.Entity<Producer>()
                .Property(e => e.ContactPerson)
                .IsFixedLength();

            modelBuilder.Entity<Seller>()
                .Property(e => e.DealerShip_Address)
                .IsFixedLength();

            modelBuilder.Entity<Seller>()
                .Property(e => e.WorkPhone)
                .IsFixedLength();
        }
    }
}
