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
            p1[0].pid = 101;
            p1[0].pname = "Keyboard";
            p1[0].price = 1200;

            p1[1] = new Product1();
            p1[1].pid = 102;
            p1[1].pname = "Mouse";
            p1[1].price = 1000;

            p1[2] = new Product1();
            p1[2].pid = 103;
            p1[2].pname = "Joystick";
            p1[2].price = 1400;

            p1[3] = new Product1();
            p1[3].pid = 104;
            p1[3].pname = "Hometheter";
            p1[3].price = 14000;

            p1[4] = new Product1();
            p1[4].pid = 105;
            p1[4].pname = "Speaker";
            p1[4].price = 5000;

            for(int i = 0; i < p1.Length; i++)
            {
                Console.WriteLine($"Id={p1[i].pid},Name={p1[i].pname},Price={p1[i].price}");
            }

        }
    }
}
