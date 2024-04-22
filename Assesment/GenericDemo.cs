using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class GenericDemo
    {
        static void Main(string[] args)
        {
            List<int> ilist = new List<int>();
            ilist.Add(1);
            ilist.Add(2);

            List<string> slist = new List<string>();

            slist.Add("Pune");
            slist.Add("Mumbai");


            List<Product1> products = new List<Product1>();

            products.Add(new Product1 { Pid = 1, Pname = "Pen", Price = 200.0 });
            products.Add(new Product1 { Pid = 2, Pname = "Pen", Price = 20 });
            products.Add(new Product1 { Pid = 3, Pname = "Pen", Price = 20 });
            foreach(Product1 p in products)
            {
                Console.WriteLine(p);
            }



            Stack<int> st = new Stack<int>();
            st.Push(10);

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amol");
            queue.Enqueue("Suraj");

            Queue<Product> qproduct = new Queue<Product>();

            //qproduct.Enqueue(new Product1 { Pid = 1, Pname = "Pen", Price = 20 });

            Hashtable ht = new Hashtable();
            ht.Add(1, "Pune");
            ht.Add("Mumbai", 2);


            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

            keyValuePairs.Add(1, "Pune");
            keyValuePairs.Add(2, "Mumbai");
            keyValuePairs.Add(3, "Nagpur");

            foreach (KeyValuePair<int, string> item in keyValuePairs)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }


            HashSet<int> list1 = new HashSet<int>();

            list1.Add(10);
            list1.Add(20);
            list1.Add(10);
            list1.Add(30);
            list1.Add(40);


            foreach (int item in list1)
            {
                Console.WriteLine(item);
            }


        }
    }
}
