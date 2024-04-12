using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Gradedemo
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
            double per = (m + e + s + c + ss) * 100 / total;
            Console.WriteLine("Percentage is " + per);

            if(per>=33 && per < 40)
            {
                Console.WriteLine("Grade D");
            }
            else if(per>40  && per < 60)
            {
                Console.WriteLine("Grade C ");
            }
            else if(per>60 && per < 80)
            {
                Console.WriteLine("Grade B");
            }
            else if(per>80  && per < 95)
            {
                Console.WriteLine("Grade A");
            }

        }
    }
}
