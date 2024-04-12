using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Displaynub
    {
        static void Main(string[] args)
        {
            for(int i=1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Pune"+i);
                }
                 if (i % 5 == 0)
                {
                    Console.WriteLine("Welcome "+i);
                }
                 if(i%3==0 && i%5== 0)
                {
                    Console.WriteLine("Welcome to pune"+i);
                }
                {

                }
               
            }
        }
    }
}
