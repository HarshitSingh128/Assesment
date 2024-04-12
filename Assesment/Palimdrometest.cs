using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Palimdrometest
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            int rem;
            int sum = 0;
            int temp = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = (sum * 10) + rem;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Palimdrome");
            }
            else
            {
                Console.WriteLine("Not palimdrome");
            }



        }

    }
}

