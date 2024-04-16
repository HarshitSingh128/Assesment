using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
   abstract public  class Shape
    {
        public abstract void CalArea();

        public void Display()
        {
            // define some basic info about Shape
        }

    }
    public class Circle : Shape
    {
        private int radius;
        private double result;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override void CalArea()
        {
            result = 3.14 * radius * radius;
        }
        public string Print()
        {
            return $"Area of circle is {result}";
        }

    }
    public class Rectangle : Shape
    {
        private int len;
        private int br;
        private double area;

        public Rectangle(int len,int br)
        {
            this.len = len;
            this.br = br;
        }

        public override void CalArea()
        {
             area = len * br;
           // Console.WriteLine("Area of rectangle"+area);

        }
        public string Print()
        {
            return $"Area of rectangle is {area}";
        }
    }
}
