using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    //6.	Write a Java program to check whether a number is negative, positive or zero 
    public class Positivenegativedemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Positive");

            }
            else if (num < 0)
            {
                Console.WriteLine("Negative");

            }
            else if (num == 0)
            {
                Console.WriteLine("Zero");
            }


        }
    }
}
