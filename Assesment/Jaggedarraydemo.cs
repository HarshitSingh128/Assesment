using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Jaggedarraydemo
    {
        static void Main(string[] args)
        {
            // Jagged array

            int[][] arr = new int[4][];// rows are fixed -

            arr[0] = new int[] { 1, 2 }; // 0th row has 5 columns
            arr[1] = new int[] { 10, 45,78,7,87,20, 30 }; // 1st row has 3 columns
            arr[2] = new int[] { 100, 200 ,300,400,500,600}; // 2nd row 2 columns
            arr[3] = new int[] { 10, 20, 3, 7, 8, 9, 87 };

            // row
            for (int i = 0; i < arr.Length; i++) // arr.Length returns size of row
            {
                for (int j = 0; j < arr[i].Length; j++) // col
                {
                    Console.Write($"{arr[i][j]}  ");
                }
                Console.WriteLine();
            }

            // with foreach
            Console.WriteLine("-----using foreach----------");
            foreach (int[] item in arr) // assing row to item
            {
                foreach (int i in item)
                {
                    Console.Write($"{i}  ");
                }
                Console.WriteLine();
            }

        }
    }
}
