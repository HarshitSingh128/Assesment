using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assesment
{
   // 10.	Write a Java program to input basic salary of an employee and calculate its

//Gross salary according to following: Basic Salary <= 10000 : HRA = 20%,
//DA = 80% Basic Salary <= 20000 : HRA = 25%, DA = 90% Basic Salary >20000 :
//HRA = 30%, DA = 95% 

    public class Salarycal
    {
        static void GrossSal()
        {
            double grosssalary;
            Console.WriteLine("Enter salary=");
            double salary = Convert.ToDouble(Console.ReadLine());
            if (salary <= 10000)
            {
                grosssalary = salary + (0.2 * salary) + (0.8 * salary);
                Console.WriteLine("salary is=" + grosssalary);

            }
            else if (salary <= 20000)
            {
                grosssalary = salary + (.25 * salary) + (.9 * salary);
                Console.WriteLine("salary is=" + grosssalary);
            }
            else if (salary > 20000)

            {
                grosssalary = salary + (0.3 * salary) + (0.95 * salary);
                Console.WriteLine("salary is =" + grosssalary);

            }
            else
            {
                Console.WriteLine("salary is =" + salary);
            }
        }
       // 11.	Write a Java program to input electricity consumption unit and calculate
       // totalelectricity billaccording to the given condition: For first 50 units Rs. 0.50/unit
       // For next 100 units Rs. 0.75/unit For next 100 units Rs. 1.20/unit For unit above 250 Rs.
       // 1.50/unit An additional surcharge of 20% is added to the bill


        
        static void Main(string[] args)
        {
            //  GrossSal();
            


        }
    }
}
