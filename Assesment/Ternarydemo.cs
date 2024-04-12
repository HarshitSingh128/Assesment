using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Ternarydemo
    {
        static void greatest()
        {
            int n1 = 2;
            int n2 = 9;
            int n3 = 11;

            int large = (n1 >= n2) ? ((n1 >= n3) ? n1 : n3) : ((n2 >= n3) ? n2 : n3);
            Console.WriteLine("Largest Number :"+large);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            string res = (num > 0) ? "Positive" : "Negative";
            Console.WriteLine(res);
            greatest();
        }
    }
}
