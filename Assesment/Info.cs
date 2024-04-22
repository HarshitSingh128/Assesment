using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public  interface Info
    {
        public int b { get; }
        static int j = 10;


    }
    public class ChildInfo : Item, Info
    {
        public int b { get; } = 10;

        public int Addition()
        {
            return a + Info.j;
        }
        static void Main(string[] args)
        {
            ChildInfo c1 = new ChildInfo();
            Console.WriteLine("Addition is:"+c1.Addition());
        }

    }
}
