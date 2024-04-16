using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Overloadstaticmethod
    {
        public static void Calculate(int a,int b)
        {
            int add = a + b;
            Console.WriteLine("Addition:"+add);
        }
        public static void Calculate(double a,double b)
        {
            double sub = a - b;
            Console.WriteLine("Substraction:"+sub);
        }
        public static void Calculate(int a,int b,int c)
        {
            int multi = a * b * c;
            Console.WriteLine("Multiplication:"+multi);

        }
        public static void Calculate(int a,double b)
        {
            double div = a / b;
            Console.WriteLine("Division"+div);
        }
        static void Main(string[] args)
        {
            Calculate(2, 5);
            Calculate(5, 2);
            Calculate(2, 3, 4);
            Calculate(7, 2);
            
        }
    }
}
