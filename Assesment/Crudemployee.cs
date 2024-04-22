using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Crudemployee
    {
        static void Main(string[] args)
        {
            bool exit=false;
           
            EmployeeCrudmethods e1 = new EmployeeCrudmethods();


            do {
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Update Employee");
                Console.WriteLine("3.Delete Employee");
                Console.WriteLine("4 Show all Employee Details");
                Console.WriteLine("5.Exit");

                Console.WriteLine("Enter Choice");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        e1.Addemployee();
                        break;
                    case 2:
                        e1.UpdateEmployee();
                        break;
                    case 3:
                        e1.DeleteEmployee();
                        break;
                    case 4:
                        e1.ShowallEmployee();
                   break;
                    case 5:
                        exit = true;

                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }



            } while (!exit);
        }
    }
}
