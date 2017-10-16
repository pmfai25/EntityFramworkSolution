using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthEFConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //NorthwindEntities nentities = new NorthwindEntities();
            NorthwindEntities nEntites = new NorthwindEntities();

            var result=(from c in nEntites.Customers
                        where c.City=="London"
                        select new { c.CustomerID,c.CompanyName,c.ContactName,})

        }
    }
}
