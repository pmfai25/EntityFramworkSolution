using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultitabletoSingleTableConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiDbEntities mEntities = new MultiDbEntities();
            mEntities.Database.Log = (Log) => { Console.WriteLine(Log); };

            #region Insert Employees
            //Employee emp1 = new Employee { EmployeeID=101,FirstName="Tintin",LastName="Rep",Salary=2010.90m};

            //Employee emp2 = new Employee { EmployeeID = 102, FirstName = "Tin", LastName = "Tin", Salary = 2110.90m };

            //Employee emp3 = new Employee { EmployeeID = 103, FirstName = "Power", LastName = "parker", Salary = 3010.90m };

            //Employee emp4 = new Employee { EmployeeID = 104, FirstName = "Wayene", LastName = "Bruce", Salary = 4010.90m };

            //mEntities.Employees.Add(emp1);
            //mEntities.Employees.Add(emp2);
            //mEntities.Employees.Add(emp3);
            //mEntities.Employees.Add(emp4);

            //int recEffected = mEntities.SaveChanges();
            //Console.WriteLine($"{recEffected} - Employees Added..."); 
            #endregion

            var result = (from e in mEntities.Employees
                          select e);
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}
