using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Percentagetest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter maths marks");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter English marks");
            double e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Science marks");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Computer marks");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Social science marks");
            double ss = Convert.ToDouble(Console.ReadLine());
            int total = 500;
            double per = (m + e + s + c + ss) *100/total;
            Console.WriteLine("Percentage is "+per);

        }
    }
}
