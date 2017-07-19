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
           
            using (var context = new SalesDatabaseEntities1())
            {
                Database.SetInitializer<SalesDatabaseEntities1>(new CustomerDbInitializer());
                var stdQuery = (from d in context.Customers
                                select new { Id = d.Id, Name = d.Name,Email=d.Email,CreditCard=d.CreditCardNumber });

                foreach (var q in stdQuery)
                {
                    Console.WriteLine("ID : " + q.Id + ", Name : " + q.Name+", Email :"+q.Email+",CreditCard "+q.CreditCard);
                }

                Console.ReadKey();
            }

        }


    }
}