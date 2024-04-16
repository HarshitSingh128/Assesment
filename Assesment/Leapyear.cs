using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Leapyear
    {
        //1.	Write a program to check whether a year is leap year or not 


        public static void leapyeartest()
        {
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("leap Year");
            }
            else
            {
                Console.WriteLine("Not leap year");
            }
      
        }
        ////2.	Write a Java program to check whether a number is divisible by 5 and 11 or not
        public static void divisibility()
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num%5==0 || num % 11 == 0)
            {
                Console.WriteLine("Divisile");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }

        }
        static void Main(string[] args)
        {
            leapyeartest();
            Console.WriteLine("===============");
            divisibility();
        }

    }
}
