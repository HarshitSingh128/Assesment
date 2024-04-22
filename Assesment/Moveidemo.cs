using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Moveidemo
    {
        static void Main(string[] args)
        {
            Movei[] m1 = new Movei[3];
            m1[0] = new Movei(101, "Sholey", 450, "Abc");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(m1[i]);
            }
        }
    }
}
