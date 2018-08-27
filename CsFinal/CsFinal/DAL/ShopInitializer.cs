using CsFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CsFinal.DAL
{
    public class ShopInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var customers = new List<Customer>
            {
                new Customer{FirstName="Tom", LastName="Shwartz"},
                new Customer{FirstName="Bill", LastName="Smith"},
                new Customer{FirstName="Jane", LastName="Brown"},
                new Customer{FirstName="Anna", LastName="Hahne"}
            };
            customers.ForEach(x => context.Customers.Add(x));
            context.SaveChanges();

            var businesses = new List<Business>
            {
                new Business{BusinessName = "SafeWay"},
                new Business{BusinessName = "Fred Mayers"},
                new Business{BusinessName = "Johns"}
            };
            businesses.ForEach(x => context.Businesses.Add(x));
            context.SaveChanges();

            var transactions = new List<Transaction>
            {
                new Transaction{BusinessId = 1,CustomerId=1, Amount=50},
                new Transaction{BusinessId = 1,CustomerId=2, Amount=50},
                new Transaction{BusinessId = 2,CustomerId=3, Amount=50},
                new Transaction{BusinessId = 2,CustomerId=4, Amount=50},
                new Transaction{BusinessId = 3,CustomerId=1, Amount=50},
                new Transaction{BusinessId = 3,CustomerId=2, Amount=50}
            };
            transactions.ForEach(x => context.Transactions.Add(x));
            context.SaveChanges();
        }
    }
}