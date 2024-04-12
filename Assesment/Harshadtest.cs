using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Harshadtest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem;
            int temp = num;
            int sum = 0;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;


            }
            if (temp % sum == 0)
            {
                Console.WriteLine("Harshad number");
            }
            else
            {
                Console.WriteLine("Not Harshad number");
            }
        }
    }
}
