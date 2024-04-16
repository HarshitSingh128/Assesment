using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{


    public  class Partialdemo
    {
        static void Main(string[] args)
        {


            Calc c1 = new Calc();
            Console.WriteLine(c1.add(10,20));
            Console.WriteLine(c1.Multi(10,10));
            c1.Sub(20, 10);
            c1.Div(20, 10);
         
           
          


        }
    }
}


