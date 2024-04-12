using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Trianglearea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height");
            int h= Convert.ToInt32(Console.ReadLine());
            double area = (b * h) *0.5;
            Console.WriteLine("Area of triangle is "+area);

        }
    }
}
