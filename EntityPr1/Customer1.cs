using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPr1
{
   public partial class Customer
    {
        public override string ToString()
        {
            return String.Format($"{CustomerID},{CompanyName},{City},{ContactName},{Country}");
        }
    }
}
