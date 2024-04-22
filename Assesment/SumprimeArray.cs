using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class SumprimeArray
    {
        public static void Sumprime(int[] a)
        {
            bool flag = true;
            int sum = 0;
           
            Console.WriteLine("Prime Element is:");
            foreach(int x in a){
                flag = true;
                if (x > 1)
                {
                    for(int j = 2; j < x; j++)
                    {
                        if (x % j == 0)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        sum = sum + x;
                        Console.WriteLine(x);
                    }
                }
            }
            Console.WriteLine("Sum is:"+sum);

        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 3, 7, 8,11,13,16,18 };
            Sumprime(arr);
        }
    }
}
