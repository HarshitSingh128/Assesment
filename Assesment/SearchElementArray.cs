using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class SearchElementArray
    {
        public static bool SearchElement(int[] a,int ele)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == ele)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
         
            int[] arr = { 2, 5, 3, 7 };
            if (SearchElement(arr, 7))
            {
                Console.WriteLine("Element Found");
            }
            else
            {
                Console.WriteLine("Element Not found");
            }
            
        }
    }
}
