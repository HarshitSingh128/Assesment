using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class EmployeeInfo
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
           // emp.Assign();
            emp.calsal();
            string s1 = emp.Display();
            Console.WriteLine(s1);

            //2nd way
            Employee emp2 = new Employee();
            emp2.Accept(101, "Manoj", 2000, 1000, 1000);
            emp2.calsal();
            string s2 = emp2.Display();
            Console.WriteLine(s2);

            //we can also write like this
            //Console.WriteLine(emp2.Display());
           




        }
    }
}
