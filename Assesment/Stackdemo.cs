using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Stackdemo
    {
        static void Main(string[] args)
        {
           
            Stack s1 = new Stack();
            s1.Push(10);
            s1.Push(20);
            s1.Push(30);
            s1.Push(40);

            //to remove first element
           // s1.Pop();

          //  Console.WriteLine($"Top element on stack {s1.Peek()}");
           // Console.WriteLine($"Total elements {s1.Count}");


            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
