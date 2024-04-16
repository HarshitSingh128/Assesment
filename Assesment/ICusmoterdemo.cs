using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assesment
{
    public class ICusmoterdemo
    {
        static void Main(string[] args)
        {
            ICustomer c1 = new Transaction();
            Console.WriteLine(c1.Print());

            IOreder i1 = new Transaction();
            Console.WriteLine(i1.Print());
        }
    }
}
