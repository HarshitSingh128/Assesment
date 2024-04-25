using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Assesment
{
    //6.	WAP to find and count total number of duplicate elements in an array.
    //7.	WAP to print all unique elements in the array.
    //9.	WAP to count frequency of each element in an array.

    public class Frequencydemo
    {
        public static void Frequencytest(int[] a)
        {
            bool flag;
            int count;
            for(int i = 0; i < a.Length; i++)
            {
                flag = false;
                count = 1;
                for(int j = i - 1; j >= 0; j--)
                {
                    if (a[i] == a[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    for(int k = i + 1; k < a.Length; k++)
                    {
                        if (a[i] == a[k])
                        {
                            count++;
                        }
                    }
                   // Console.WriteLine(a[i]+"->" + "Frequency is:" + count);
                   // if (count > 1)
                    //{
                      //  Console.WriteLine("Duplicate is:" + a[i]);
                    //}
                    if (count == 1)
                    {
                        Console.WriteLine("Unique is:" + a[i]);
                    }
                }
                
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 1, 1, 2, 2, 3, 3, 4, 4, 5 };
            Frequencytest(a);


        }
    }
}
