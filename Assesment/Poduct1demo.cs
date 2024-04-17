using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Poduct1demo
    {
        static void Main(string[] args)
        {
            Product1[] p1 = new Product1[5];
            p1[0] = new Product1();
            p1[0].Pid = 101;
            p1[0].Pname = "Keyboard";
            p1[0].Price = 1200;

            p1[1] = new Product1();
            p1[1].Pid = 102;
            p1[1].Pname = "Mouse";
            p1[1].Price = 1000;

            p1[2] = new Product1();
            p1[2].Pid = 103;
            p1[2].Pname = "Joystick";
            p1[2].Price = 1400;

            p1[3] = new Product1();
            p1[3].Pid = 104;
            p1[3].Pname = "Hometheter";
            p1[3].Price = 14000;

            p1[4] = new Product1();
            p1[4].Pid = 105;
            p1[4].Pname = "Speaker";
            p1[4].Price = 5000;
            for (int i = 0; i < p1.Length; i++)
            {
                Console.WriteLine(p1[i]);
            }

            //  for(int i = 0; i < p1.Length; i++)
            //{
            //  Console.WriteLine($"Id={p1[i].Pid},Name={p1[i].Pname},Price={p1[i].Price}");
            //}
            //if i have getter setter or property then we can also declare like this
            //  Product[] products = new Product[]
            {
   // new Product{Id=1, Name="Mouse",Price=799},
   // new Product{Id=2, Name="Keyboard",Price=899},
   // new Product{Id=3, Name="Pencil",Price=10},
   // new Product{Id=4, Name="Pen",Price=10},
};


        }
    }
}
