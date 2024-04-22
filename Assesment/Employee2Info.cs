using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Employee2Info
    {
        static void Main(string[] args)
        {
            
            Employee2 e1 = new Employee2("Suraj",2000);
           
            Console.WriteLine(e1);

          
            Console.WriteLine("---------------");
            Employee2 e2 = new Employee2("Suraj", 20000);
            Employee2 e3 = new Employee2("Suyash", 10000);
            double res = e2.CompareTo(e3);
            if (res == 1)
            {
                Console.WriteLine("Suraj has more salry than Suyash");
            }
            else if (res == -1)
            {
                Console.WriteLine("Suraj has less salary than Suyash");
            }
            else
            {
                Console.WriteLine("Both Employees  has same salary");
            }
        }
    }
}
