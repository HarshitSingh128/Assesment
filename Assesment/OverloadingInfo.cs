using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class OverloadingInfo
    {
        static void Main(string[] args)
        {
            Overloadingdemo o1 = new Overloadingdemo();
            Console.WriteLine("1.Area of Recatngle");
            Console.WriteLine("2.Area of Triangle");
            Console.WriteLine("3.Area of Circle");
            Console.WriteLine("4.Area of Square");
            Console.WriteLine("Enter choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    o1. Calculate(5,5);
                    break;
                case 2:
                    o1.Calculate(3, 7);
                    break;
                case 3:
                    o1.Calculate(4);
                    break;
                case 4:
                    o1.Calculate(6);
                    break;
                default :
                    Console.WriteLine("Out of Choice");
                    break;




            }
        }
    }
}
