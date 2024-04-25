using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{


    //15.	WAP to arrange the elements of an given array of integers where
    //all negative integers appear before all the positive integers.
    public class ArrayQ15
    {
        public static void Beforenegative(int[] a)
        {
            Console.WriteLine("Negative Element Comes first:");

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = a.Length - 1; j >= 0; j--)
                {
                    if (a[i] > 0 && i < j)
                    {
                        int temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;

                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }


        }
        //13.	Write a  program to test the equality of two arrays.
        //Means e.g arr1[] = [12, 22, 32, 42, 52, 62] and arr2[] = [52, 22, 62, 12, 42, 22]
        //Here both arrays are equal.
        //
        public static bool ArraysAreEqual(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }

            return true;
        }


        static void Main(string[] args)
        {
            int[] ar = { 1, 2, -2, -3, 4, -5, 6 };
            Beforenegative(ar);
            Console.WriteLine("---------Same Array test-----------");


            int[] arr1 = { 12, 22, 32, 42, 52, 62 };
            int[] arr2 = { 52, 22, 62, 12, 42, 32 };

            bool Equal = ArraysAreEqual(arr1, arr2);

            if (Equal)
            {
                Console.WriteLine("Arrays are equal.");
            }
            else
            {
                Console.WriteLine("Arrays are not equal.");
            }
        }




    }
}

