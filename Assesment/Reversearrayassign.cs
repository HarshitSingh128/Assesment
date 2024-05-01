using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Reversearrayassign
    {
        //12.WAP to reverse the array itself, don’t print array in reverse – I want current array reverse.
        //Means e.g. arr[] = [3, 90, 45, 29, 37, 78]
        //so your same array must be [78, 37, 29, 45, 90, 3] without using temporary array.

        //By using temporary variable
        public static void ReverseArraytest(int[] arr)
        {
            int[] arr1 = new int[arr.Length];
            int index = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arr1[index++] = arr[i];
            }
            foreach (int i in arr1)
            {
                Console.Write(i+" ");
            }
        }


        static void Main(string[] args)
        {
            int[] arr = { 3, 90, 45, 29, 37, 78 };



            Console.WriteLine("----------------------------");
            ReverseArraytest(arr);



        }
    }
}
