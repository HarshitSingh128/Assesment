using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class MyGeneric<T>
    {
        private T data;

        public void Add(T data)
        {
            this.data = data;
        }

        public T Print()
        {
            return this.data;
        }
    }

    public static class Demo
    {
        public static void Swap<T>(T a, T b) // generic method
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a = {a}, b = {b}");
        }
    }


}
