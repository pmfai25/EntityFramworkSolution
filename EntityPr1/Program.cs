using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPr1
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities nEntities = new NorthwindEntities();

            #region Insert
            //Customer cust = new Customer { CustomerID = "AAA", CompanyName = "Span Labs", ContactName = "Sujit", City = "Mumbai", Country = "I" };
            // nEntities.Customers.Add(cust);

            // try
            // {
            //     nEntities.SaveChanges();
            //     Console.WriteLine("");

            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine("Error"+ex.Message);
            // } 
            #endregion

            #region Edit
            //var cust = nEntities.Customers.FirstOrDefault(c =>c.CustomerID == "AAA");
            //Console.WriteLine(cust);
            //cust.City = "Bombay-ABC";
            //Console.ReadKey(true);
            //try
            //{
            //    nEntities.SaveChanges();
            //    Console.WriteLine("Rec Updated");
            //}
            //catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException  ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //    var data = ex.Entries.Single();
            //    var originalValues = data.CurrentValues;
            //    var currentValues= data.CurrentValues;
            //    var databaseValues = data.GetDatabaseValues();
            //    Console.WriteLine("---------------");
            //    Console.WriteLine("Original Values");
            //    Console.WriteLine($"\torginalValues.GetValue<string>(City')-> {originalValues.GetValue<string>("City")}");
            //    Console.ReadKey(true);
            //    data.OriginalValues.SetValues(data.GetDatabaseValues());
            //    nEntities.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //} 
            #endregion

            var cust = nEntities.Customers.FirstOrDefault(c => c.CustomerID == "AAA");
            Console.WriteLine(cust);
            Console.WriteLine("Press any key to delete the customer");
            Console.ReadKey(true);
            nEntities.Customers.Remove(cust);
            try
            {
                nEntities.SaveChanges();
                Console.WriteLine(cust);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }

        }
    }
}
