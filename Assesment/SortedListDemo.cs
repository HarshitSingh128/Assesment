using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class SortedListDemo
    {
        static void Main(string[] args)
        {
            
            SortedList sl = new SortedList();
            sl.Add(114, "HR");
            sl.Add(153, "Sales");
            sl.Add(171, "Development");
            sl.Add(182, "Testing");
            sl.Add(116, "production");

            //sl.Remove(116);
            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            Console.WriteLine("-------------------");

            SortedList list = new SortedList();

            list.Add(104, "HR");
            list.Add(103, "Sales");
            list.Add(101, "Development");
            list.Add(102, "Testing");

            list.Remove(104);
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }





        }
    }
}
