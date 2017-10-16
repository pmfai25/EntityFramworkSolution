using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstEfConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiDbModelContainer mContainer = new MultiDbModelContainer();
            mContainer.Database.Log = (log) => Console.WriteLine(log);
            Member m1 = new Member { MemberName = "D" };
            Member m2 = new Member { MemberName = "Donald" };
            Member m3 = new Member { MemberName = "M" };
            Member m4 = new Member { MemberName = "Mickey" };
            Game g1 = new Game { GameName = "Cricket", Fees = 900 };
            Game g2 = new Game { GameName = "Tennis", Fees = 2900 };
            Game g3 = new Game { GameName = "Football", Fees = 1900 };
            Game g4 = new Game { GameName = "BasketBall", Fees = 400 };

            m1.Games.Add(g1);
            m1.Games.Add(g2);
            m2.Games.Add(g2);

            m3.Games.Add(g3);
            m3.Games.Add(g4);

            m4.Games.Add(g4);

            mContainer.Members.Add(m1);
            mContainer.Members.Add(m2);
            mContainer.Members.Add(m3);
            mContainer.Members.Add(m4);
            int recEffected = mContainer.SaveChanges();
            Console.WriteLine($"{recEffected} - Members games Added...");



        }
    }
}
