namespace Sales_Database.Migrations
{
    using Sales_Database.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Runtime.CompilerServices;

    internal sealed class Configuration : DbMigrationsConfiguration<Sales_Database.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Sales_Database.Models.ApplicationDbContext";
           
        }
        [Dependency]
        property IMyInitializer initializer;
        protected override void Seed(Sales_Database.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
       // //   protected override void Seed(BookService.Models.BookServiceContext context)
      //  {
            context.Customers.AddOrUpdate(x => x.CustomerId,
                new Customer() { CustomerId = 1, CustomerName = "Jane Austen",Email="jane@gmail.com",CreditCardNumber="34542345" },
                new Customer() { CustomerId = 2, CustomerName = "Charles Dickens",Email="charlie@gmail.com",CreditCardNumber="234554234" },
                new Customer() { CustomerId = 3, CustomerName = "Miguel de Cervantes",Email="migel@gmail.com",CreditCardNumber="234543234" }
                );

            context.Products.AddOrUpdate(x => x.ProductId,
                new Product(){ ProductId = 1,ProductName="T-shirt", Quantity=349, Price=34 },
                new Product() {ProductId=2,ProductName="Trousers",Quantity=344,Price=91 },
                new Product() {ProductId=3,ProductName="Soap",Quantity=32,Price=4  },
                new Product() { ProductId=4,ProductName="Paper",Quantity=500,Price=15      }
                );

            context.Sales.AddOrUpdate(x => x.SaleId,
               new Sale() { SaleId = 1, Date = "6/1/2008", CustomerId=2,ProductId=3,StoreLocationId=1 },
               new Sale() { SaleId = 2, Date = "16/11/2009", CustomerId = 1, ProductId = 3, StoreLocationId = 3 },
               new Sale() { SaleId = 3, Date = "6/4/2010", CustomerId = 2,ProductId = 3,StoreLocationId = 1 },
         new Sale() { SaleId = 4, Date = "6/2/2008", CustomerId = 3,ProductId = 4,StoreLocationId = 2 }
               );

            context.StoreLocations.AddOrUpdate(x => x.StoreLocationId,
              new StoreLocation() { StoreLocationId = 1,LocationName="Room3" },
              new StoreLocation() { StoreLocationId = 2, LocationName = "Room1" }
            
              );

        
    }
    }
}
