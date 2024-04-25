using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Deligatedemo
    {
        static void Main(string[] args)
        {
            //delegate hold the method reference
            DelegateTest c1 = new DelegateTest();
            //// create object of delegate & pass the method name to hold the address


            Mydel m1 = new Mydel(c1.Add);
            m1 += new Mydel(c1.Sub);
            m1 += new Mydel(c1.Mul);

            // to remove method from invocation list
            m1 -= new Mydel(c1.Sub);

            //// to get the invocation list to retrieve the methods from delegate
            Delegate[] list = m1.GetInvocationList();
            foreach (Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(45, 34));
            }


            // this is in case of single cast delete
            //int result=mydelegate.Invoke(20, 40);
            //Console.WriteLine(result);

            // Invocation List --> delegate will create list & hold all method ref 
            // in sequence

        }
    }
}
