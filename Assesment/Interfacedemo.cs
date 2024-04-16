using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Interfacedemo
    {
        static void Main(string[] args)
        {
            Job j1 = new Job();
            Console.WriteLine(j1.Paytax());

            Business b1 = new Business();
            Console.WriteLine(b1.Paytax());


        }
        }
}
