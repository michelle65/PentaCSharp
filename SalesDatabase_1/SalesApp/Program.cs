using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SalesApp.SalesDatabaseEntities1;

namespace SalesApp
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var customer = new SalesDatabaseEntities1())
            {
                var count = customer.Customers.Count();

                //  Console.WriteLine(context.Database.Connection.ConnectionString);

                //Console.WriteLine(count);

                customer.Customers.Add(new Customer() { Id=1,Name="Mary",Email="mary@gmail.com",CreditCardNumber="567888989"});

                customer.Customers.Add(new Customer() { Id=2,Name="James",Email="james@gmail.com",CreditCardNumber="567897665" });

                customer.Customers.Add(new Customer() {Id=3,Name="Henry",Email="henry@gmail.com",CreditCardNumber="678908765" });

                customer.Customers.Add(new Customer() { Id=4,Name="John",Email="john@gmail.com",CreditCardNumber="546789043567" });

                customer.SaveChanges();

                count = customer.Customers.Count();

                //show me the reults and convert them to a list
                var search = customer.Customers.Where(o => o.Name.Contains("y")).ToList();

                Console.WriteLine(search.Count());

                Console.WriteLine(count);

                Console.ReadLine();
            }

          

        }


    }
}