using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Krishnamurtitest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem;
            int sum=0;
            int temp = num;
            while (num > 0)
            {
                int fact = 1;
                rem = num % 10;
                num =num/ 10;
                for(int i = 1; i <= rem; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                //Console.WriteLine(sum);

            }
            if (temp == sum)
            {
                Console.WriteLine("Krishnamurti number");
            }
            else
            {
                Console.WriteLine(" Not Krishnamurti number");
            }
        }
    }
}
