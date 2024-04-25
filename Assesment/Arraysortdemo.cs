using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    //11.	WAP sort array elements in ascending order.
    public class Arraysortdemo
    {
        static void Arraymethod(int[] ar)
        {
            for(int i = 0; i < ar.Length; i++)
            {
                for(int j = i + 1; j < ar.Length; j++)
                {
                    if (ar[i] > ar[j])
                    {
                        int temp = ar[i];
                        ar[i] = ar[j];
                        ar[j] = temp;
                    }
                }
            }
           for(int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 85, 45, 12, 78, 1 };
            int[] arr2 = new int[3];

            //print as it is
            foreach(int item in arr1)
            {
                Console.WriteLine(item);
            }
            //sort the element
            Array.Sort(arr1);
            Console.WriteLine("--After Sorting--");
            foreach (int item in arr1)
            {
                Console.WriteLine(item);
            }
            //print in reverse
            Array.Reverse(arr1);
            Console.WriteLine("--After Reverse--");
            foreach (int item in arr1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=============");

            //copy the 3 element 45,12,1 int the new array
            Array.Copy(arr1,2, arr2,0, 3);
            foreach (int item in arr2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");
            int[] arr3 = new int[] { 12, 45, 78, 96, };
            Array.Clear(arr3);
            Console.WriteLine("===After Clear=====");
            foreach (int item in arr3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---By method--");
            Arraymethod(arr1);


        }
    }
}
