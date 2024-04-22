using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
   public class Array2ddemo
    {
        static void Main(string[] args)
        {
            int[,] arr=new int[3, 3]
            {
           {1,1,1 },
           {2,5,6 },
           {7,8,9}
            };
          

            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++) // row size
            {
                for (int j = 0; j < arr.GetLength(1); j++) // col size
                {
                    Console.Write($"arr[{i},{j}] --> {arr[i, j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------After Sum----------");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++) 
                {
                    sum = sum + arr[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine(sum);


        }
    }
}
