using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{


    public class TempratureConversion
    {
        ///5.	Write a  program to enter temperature in Fahrenheit(°F) and convert it into Celsius(°C)
       public static void Celsius()
        {
            Console.WriteLine("Enter temprature in °Fahrenheit.");
            double f = Convert.ToDouble(Console.ReadLine());
            double c, fahrenheit;
            
            fahrenheit = (9 * f + 160) / 5;
            Console.WriteLine("In celsius tamprature is="+fahrenheit+"C");


        }
       
        static void Main(string[] args)
        {
            //4.	Write a program to enter temperature in °Celsius and convert it into °Fahrenheit.
            Console.WriteLine("Enter temprature in Celsius");
            double f = Convert.ToDouble(Console.ReadLine());
            double  celsius;
            
            celsius = (5 * f - 160) / 9;
            Console.WriteLine("In fahrenheit temp is=" + celsius + "celsius");

            Console.WriteLine("====================");
            Celsius();


        }
    }
}
