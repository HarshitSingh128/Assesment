using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Trianglearea
    {
        //1.	Write a program to calculate area of an equilateral triangle.
        static void equiletral(int side)
        {
            double area = (1.73 * side * side) / 4;
            Console.WriteLine("Area of equiletral is "+area);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height");
            int h= Convert.ToInt32(Console.ReadLine());
            double area = (b * h) *0.5;
            Console.WriteLine("Area of triangle is "+area);

            Console.WriteLine("=================");
            equiletral(2);

        }
    }
}
