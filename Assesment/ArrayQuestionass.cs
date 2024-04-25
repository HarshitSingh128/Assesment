using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    //5.	WAP to find the maximum and minimum value in an array.
    public class ArrayQuestionass
    {
        public static void Maximum(int[] a)
        {
            int max = a[0];
            int min = a[0];
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                else
                    min = a[i];
            }
            Console.WriteLine("Max is:"+max);
            Console.WriteLine("Min is:"+min);

        }

        //8.	WAP to find the second smallest element in an array.
        public static int FindsecondSmallest(int[] a) {
            int lowest = int.MaxValue;
            int secondlowest = int.MaxValue;

            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] < lowest)
                {
                    secondlowest = lowest;
                    lowest = a[i];
                  
                }
              else  if (a[i] < secondlowest)
                {
                    secondlowest = a[i];
                }
            }
            return secondlowest;
        


        }


        static void Main(string[] args)
        {
            int[] ar = { 2, 3, 5, 7, 9, 7 };
            Maximum(ar);
            Console.WriteLine("=================");
            int temp= FindsecondSmallest(ar);
            Console.WriteLine("secondLowest is:"+temp);

        }
    }
}
