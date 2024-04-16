using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Overloadingdemo
    {
        public void Calculate(int len,int br)
        {
            double area = len * br;
            Console.WriteLine("Area of Rectangle is:"+area);
        }
        public void Calculate(double b,int h)
        {
            double area = (b*h)*0.5;

            Console.WriteLine("Area of Triangle is:" + area);
        }
        public void Calculate(int r)
        {
            double area = 3.14 * r * r;
            Console.WriteLine("Area of circle is:"+area);
        }
        public void Calculate(double a)
        {
            double area = a * a;
            Console.WriteLine("Area of Square is:"+area);
        }
    }
}
