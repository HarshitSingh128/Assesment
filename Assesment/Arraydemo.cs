﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Arraydemo
    {
        static void Main(string[] args)
        {


            int[] arr1 = new int[5] { 10, 20, 30, 40, 50 };

            Console.WriteLine(arr1[3]);

            arr1[4] = 500; // modified 50 replaced with 500

            Console.WriteLine(arr1[4]);

            // print all values - using for loop  , foreach loop in C#
            // for loop using for index
            for (int i = 0; i < arr1.Length; i++)  // i<5
            {
                Console.WriteLine($"arr1[{i}] = {arr1[i]}");
            }

            // new string[size]
            string[] names = { "Amol", "Rajesh", "Suraj", "Anuj" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            // adding size is optional if we initalize the values
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };

            int[] arr3;


            arr3 = new int[10];
            // accept from user
            Console.WriteLine("Enter 10 values");
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = Convert.ToInt32(Console.ReadLine());
            }

            //print
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }

        }
    }
}
