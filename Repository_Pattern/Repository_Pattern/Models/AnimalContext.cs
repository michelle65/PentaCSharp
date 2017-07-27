namespace Repository_Pattern
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AnimalContext : DbContext
    {
        // Your context has been configured to use a 'AnimalContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Repository_Pattern.AnimalContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AnimalContext' 
        // connection string in the application configuration file.
        public AnimalContext()
            : base("name=AnimalContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Models.Animal> Animals { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}