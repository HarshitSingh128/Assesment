using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class BookInfo
    {
        static void Main(string[] args)
        {
            //property initializer syntax
            Book b1 = new Book();
            b1.Bid = 101;
            b1.Bname = "Maths";
            b1.Bprice = 1500;
             Console.WriteLine($"{b1.Bid},{b1.Bname},{b1.Bprice}");

            //object intialiser syntax
            Book b2 = new Book { Bid=102,Bname="English",Bprice=1400};
            Console.WriteLine($"{b2.Bid},{b2.Bname},{b2.Bprice}");



        }



    }
}
