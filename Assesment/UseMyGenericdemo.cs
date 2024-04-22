using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class UseMyGenericdemo
    {
        static void Main(string[] args)
        {
            /*
            MyGeneric<int> obj1 = new MyGeneric<int>();
            obj1.Add(10);
            Console.WriteLine(obj1.Print());

           // MyGeneric<Product1> obj2 = new MyGeneric<Product1>();
            //obj2.Add(new Product1 { Pid = 1, Pname = "Mouse", Price = 899 });

         //   Console.WriteLine(obj2.Print());


            MyGeneric<string> obj3 = new MyGeneric<string>();
            obj3.Add("Hello");
            Console.WriteLine(obj3.Print());

            */

            //use generic method
            int a = 10, b = 20;

            Console.WriteLine($"a= {a}, b={b}");
            Demo.Swap<int>(a, b);

            string name1 = "User1", name2 = "User2";
            Demo.Swap<string>(name1, name2);


        }
    }
}
