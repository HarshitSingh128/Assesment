using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    //5.	Write a Java program to create Simple Calculator  
    public class Calculatordemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Mod");
            Console.WriteLine("Enter your choice");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter the value of a");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of b");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int c = a + b;
                    Console.WriteLine("Addition="+c);
                    break;
                case 2:
                    Console.WriteLine("Enter the value of a");
                     a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of b");
                     b = Convert.ToInt32(Console.ReadLine());
                     c = a - b;
                    Console.WriteLine("Addition=" + c);
                    break;
                case 3:
                    Console.WriteLine("Enter the value of a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of b");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Addition=" + c);
                    break;
                case 4:
                    Console.WriteLine("Enter the value of a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of b");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Addition=" + c);
                    break;
                case 5:
                    Console.WriteLine("Enter the value of a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of b");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a % b;
                    Console.WriteLine("Addition=" + c);
                    break;
                default:
                    Console.WriteLine("Out of choice");
                    break;

            }
        }
    }
}
