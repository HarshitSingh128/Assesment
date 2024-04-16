using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class ManagerInfo
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(101, "Manoj", 2000, 1000, 1000);
            emp.calsal();
            Console.WriteLine(emp.Display());

            Manager m1 = new Manager(102, "Suraj", 2000, 1000, 1000, 2000);
            m1.calsal();
            Console.WriteLine(m1.Display());
            

            Employee e1 = new Manager(103, "Suyash", 4000, 2000, 1000, 1000);
            e1.calsal();
            Console.WriteLine(e1.Display());
           // e1.assign();


        }
    }
}
