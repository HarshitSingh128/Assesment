using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Stringarray
    {
        static void Main(string[] args)
        {
            string[] names = { "Amol", "Rajesh", "Suraj", "Anuj" };
            string[] names1 = new string[3];

            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--After sorting--");
            Array.Sort(names);
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            Array.Reverse(names);
            Console.WriteLine("---After Reverse----");
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--After Copy--");
            Array.Copy(names, 1, names1, 0, 3);
            foreach (string item in names1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---After clear--");
            Array.Clear(names1);
            foreach (string item in names1)
            {
                Console.WriteLine(item);
            }



        }
    }
}
