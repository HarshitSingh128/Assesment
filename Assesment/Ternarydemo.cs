using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Ternarydemo
    {
       
      
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            string res = (num > 0) ? "Positive" : "Negative";
            Console.WriteLine(res);
         
            
        }
    }
}
