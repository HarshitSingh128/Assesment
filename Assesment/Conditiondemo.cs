using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public  class Conditiondemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of c");
            int c = Convert.ToInt32(Console.ReadLine());

            if(a>b && a > c)
            {
                Console.WriteLine("A is greatest");
            }
            else if(b>a  && b > c)
            {
                Console.WriteLine("B is greatest");
            }
            else if (c > a &&  c> b)
            {
                Console.WriteLine("C is greatest");
            }


        }
    }
}
