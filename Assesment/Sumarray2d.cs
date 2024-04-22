using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Sumarray2d
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] sum = new int[3, 3];

            Console.WriteLine("Enter Elements for the first 3x3 Matrix");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter Elements for the Second 3x3 Matrix");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
          

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum[i, j] = arr1[i, j] + arr2[i,j]
;                }
            }

            Console.WriteLine("Result Matrix");
            for (int i = 0; i < 3; i++) // row size
            {
                for (int j = 0; j < 3; j++) // col size
                {
                    Console.Write(sum[i,j]+" ");


                }
                Console.WriteLine();
            }









        }
    }
}
