using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Productinfo
    {
        static void Main(string[] args)
        {
            //property initializer syntax
            Product p1 = new Product();
            
            p1.Code = 1;//internallt calls set acessesor
            p1.Name = "Sugar";
            p1.Price = 100;

            // Console.WriteLine($"{p1.Code},{p1.Name},{p1.Price}");

            //object intialiser syntax
            Product p2 = new Product { Code=101,Name="Keyboard",Price=1500};
            Console.WriteLine($"{p2.Code},{p2.Name},{p2.Price}");

        }
    }
}
