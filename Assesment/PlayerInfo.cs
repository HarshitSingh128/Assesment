using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class PlayerInfo
    {
        static void Main(string[] args)
        {
            
            Team t1 = new Team();
            foreach(Player p in t1)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("======By IComparable=====");
            Player v = new Player("Virat", 7000);
            Player r = new Player("Rohit", 4000);

            int res = v.CompareTo(r);
            if (res == 1)
            {
                Console.WriteLine("Virat has more runs than Rohit");
            }
            else if(res==-1)
            {
                Console.WriteLine("Virat has less runs than Rohit");
            }
            else
            {
                Console.WriteLine("Both have same runs");
            }

            Console.WriteLine("------By  IComparer----------");
            Player virat = new Player("Virat", 2500);
            Player rohit = new Player("Rohit", 3000);

            PlayerCompare obj = new PlayerCompare();

            int result = obj.Compare(virat, rohit);
            if (result == 1)
            {
                Console.WriteLine("Virat has more runs than Rohit");
            }
            else if (result == -1)
            {
                Console.WriteLine("Virat has less runs than Rohit");
            }
            else
            {
                Console.WriteLine("Both have equal runs");
            }

        }
    }
}
