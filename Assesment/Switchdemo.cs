using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Vowelconsonettest
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Welcome to my cafe=");
            Console.WriteLine("1.Tea\n2.coffe\n3.cold drink=");
            Console.WriteLine("Enter choice=");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Tea is Rs 30=");
                    break;
                case 2:
                    Console.WriteLine("Coffe is Rs 80=");
                    break;
                case 3:
                    Console.WriteLine("Cold drink is Rs 20=");
                    break;
                default:
                    Console.WriteLine("Out of stock");
                    break;
            





            }
        }
    }
}
