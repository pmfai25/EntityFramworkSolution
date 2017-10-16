using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiDbEntities mEntities = new MultiDbEntities();
            mEntities.Database.Log = (log) => Console.WriteLine(log);

            Account sa1 = new SavingsAccount { AccountNumber = 104, HoldersName = "Tintin", Balance = 2000.21m };
            Account ca1 = new CurrentAccount { AccountNumber = 204, HoldersName = "Mandrake", Balance = 2200.21m };
            Account sa2 = new SavingsAccount { AccountNumber = 106, HoldersName = "T", Balance = 4000.21m };
            Account ca2 = new CurrentAccount { AccountNumber = 206, HoldersName = "M", Balance = 3200.21m };
            Account sa3 = new SavingsAccount { AccountNumber = 109, HoldersName = "Thmoson", Balance = 8000.21m };
            Account ca3 = new CurrentAccount { AccountNumber = 209, HoldersName = "Spiderman", Balance = 2900.21m };
            Account sa4 = new SavingsAccount { AccountNumber = 105, HoldersName = "Haddock", Balance = 10000.21m };
            Account ca4 = new CurrentAccount { AccountNumber = 205, HoldersName = "BatMan", Balance = 8200.21m };
            mEntities.Accounts.Add(sa1);
            mEntities.Accounts.Add(ca1);
            mEntities.Accounts.Add(sa2);
            mEntities.Accounts.Add(ca2);
            mEntities.Accounts.Add(sa3);
            mEntities.Accounts.Add(ca3);
            mEntities.Accounts.Add(sa4);
            mEntities.Accounts.Add(ca4);
            int recEffected = mEntities.SaveChanges();
            Console.WriteLine($"{recEffected}-Record Inserted scuccesfully...");

            var result = (from a in mEntities.Accounts
                          select a).ToList();

            foreach(var item in result)
            {
                Console.WriteLine($"{item} and Account Type: {item.GetType().Name}");
            }

        }
    }
}
