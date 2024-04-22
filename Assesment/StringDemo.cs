using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
   public class StringDemo
    {
        static void Main(string[] args)
        {
            string str = "Hello to all";
            string str2 = "Hello";
            //string str3 = "";
            // need to convert string to char[] we can use split

            char[] chs = str.ToCharArray();
            foreach (var item in chs)
            {
                Console.WriteLine(item);
            }
            //split  --> string to string[] using condition

            string[] result = str.Split(' ');

            // result[0]="Hello"
            // result[1]="to"
            //result[2]="all"

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            if (string.IsNullOrEmpty(str2))
            {
                Console.WriteLine("string is empty or null");
            }
            else
            {
                Console.WriteLine(str2);
            }





        }
    }
}
