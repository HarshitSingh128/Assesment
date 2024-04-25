using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Arrayassignment
    {
        // 1.	WAP to search for a given number in an array and accordingly print the index if exists


        public static void ArrayTest(int[] a, int ele)
        {
            bool flag = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ele)
                {
                    flag = true;
                    Console.WriteLine("Index is:" + i);
                }

            }
            if (!flag)
            {
                Console.WriteLine("Element not found");
            }
        }
        //2.	Write two methods that return the average of an array with following headers.
        //i.  public static int average(int[] array)
        //ii. public static double average(double[] array).
        //iii.Write main and invoke the 2 methods.
        public static int Average (int[] a)
        {
            int sum = 0;
            int average=0;
            for(int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
                 average = sum / a.Length;
               
            }
            return average;
        }
        public static double Averagetest(double[] a)
        {
            double sum = 0;
            double average = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
                average = sum / a.Length;

            }
            return average;
        }
        //3.	WAP to print all negative elements in an array
        //and also count total number of negative elements in an array.
        public static void Printnegative(int[] a)
        {
            int count = 0;
            Console.WriteLine("Negative Element is:");
            for (int i = 0; i < a.Length; i++)
            {
                
                if (a[i] < 0)
                {
                    count++;
                    Console.WriteLine(a[i]);

                }

            }
            Console.WriteLine("Total Negative elemnt is:"+count);
        }
        //4.	WAP to put even and odd elements of array in two separate arrays.
        public static void SeprateEvenOdd(int[] a)

        {
            int[] Even = new int[4];
            int[] Odd = new int[4];
            int index=0;
            int index1 = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Even[index++] = a[i];
                }
                else
                {
                    Odd[index1++] = a[i];
                }
                

            }
            Console.WriteLine("Even is:");
            foreach(int ev in Even)
            {
                Console.WriteLine(ev);
            }
            Console.WriteLine("Odd is:");
            foreach (int ev in Odd)
            {
                Console.WriteLine(ev);
            }


        }
        static void Main(string[] args)
        {
            int[] ar = { 1, 8, 9, 71, 89, };
            ArrayTest(ar, 9);
            Console.WriteLine("--------------");
            int average=Average(ar);
            Console.WriteLine("Average is:"+average);
            Console.WriteLine("-------------");
            double[] arr = { 1.1, 2.2, 3.3,4.45,7.8,2.6 };
            double avg = Averagetest(arr);
            Console.WriteLine("Average is:"+avg);
            Console.WriteLine("----------");
            int[] arr1 = { -2, 2, -5, -7, -7, -8, 9, 6, 7 };
            Printnegative(arr1);

            Console.WriteLine("------------");
            int[] arr2 = { 2, 4, 7, 8, 9, 6, 7 };
            SeprateEvenOdd(arr2);


        }
    }
}
