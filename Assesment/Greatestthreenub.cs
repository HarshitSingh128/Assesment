using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public  class Greatestthreenub
    {
        //3.	Write a Java program to find maximum between three numbers 
        static void greatest()
        {
            int n1 = 2;
            int n2 = 9;
            int n3 = 11;

            int large = (n1 >= n2) ? ((n1 >= n3) ? n1 : n3) : ((n2 >= n3) ? n2 : n3);
            Console.WriteLine("Largest Number :" + large);
        }
        static void greatest1()
        {
            int a = 5;
            int b = 8;
            int c = 9;
            int d;
            if (a > b)
            {
                if (a > c)
                    d = a;
                else
                    d = c;
            }
            else
            {
                if (b > c)
                    d = b;
                else
                    d = c;
            }
            Console.WriteLine(d +"is greatest");
        }
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

            greatest();
            greatest1();


        }
    }
}
