using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceConApp
{
   public partial class Account
    {
        public override string ToString()
        {
            return string.Format($"Account no:{AccountNumber},Holders name:{HoldersName},Balance :{Balance}");
        }
    }
}
