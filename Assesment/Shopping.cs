using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Shopping
    {
        int pid;
        string pname;
        double price;
        int qty;
      
        public void AcceptDetails()
        {
            Console.WriteLine("Enter product id");
            pid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter product Name");
            pname= Console.ReadLine();

            Console.WriteLine("Enter product Price");
            price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Quantity of product");
            qty = Convert.ToInt32(Console.ReadLine());

        }
        public double Bill()
        {
            return price * qty;
        }
        public void Display()
        {
            if (qty > 0)
            {
                Console.WriteLine($"pid={pid},Pname={pname},Price={price},Quantity={qty},Bill={Bill()}");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

       

    }
}
