using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Patterndemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            int i, j, k;
            for (i = 1; i <= rows; i++)
            {
                for (k = rows; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
