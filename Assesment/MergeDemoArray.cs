using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class MergeDemoArray
    {
        static int[] MergeTest(int[] a1,int[] a2)
        {
            int len1 = a1.Length;
            int len2 = a2.Length;
            int[] mer = new int[len1 + len2];
            int index = 0;
            for(int i = 0; i < a1.Length; i++)
            {
                mer[index++] = a1[i];
            }
            for (int i = 0; i < a2.Length; i++)
            {
                mer[index++] = a2[i];
            }
            return mer;
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 3, 4, 5 };
            int[] arr2 = { 2, 7, 8, 9, 4, 5, 6 };
            int[] mer = MergeTest(arr1, arr2);
            foreach(int a in mer)
            {
                Console.WriteLine(a);

            }
        }
    }
}
