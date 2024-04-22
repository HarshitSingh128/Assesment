using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Dictionarydemo
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> d1 = new Dictionary<int, string>();

            d1.Add(1, "Pune");
            d1.Add(2, "Mumbai");
            d1.Add(3, "Nagpur");
            d1.Add(7, "Uttar Pradesh");
            d1.Add(8, "Delhi");

            foreach (KeyValuePair<int, string> item in d1)
            {
                Console.WriteLine(item.Key + "->" + item.Value);
            }
            Console.WriteLine("------------");
            Dictionary<string, int> d2 = new Dictionary<string, int>();
            d2.Add("Rajesh", 1);
            d2.Add("suyash", 6);
            d2.Add("Sharma", 7);
            d2.Add("Tejas", 9);
            foreach(KeyValuePair<string,int> i in d2)
            {
                Console.WriteLine(i.Key+"->"+i.Value);
            }
            Console.WriteLine("---------------");
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
            Console.WriteLine("--------------");
            HashSet<string> l4= new HashSet<string>();
            l4.Add("Suyash");
            l4.Add("Anmol");
            l4.Add("Amit");
            l4.Add("Rajesh");

            foreach (string item in l4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");
            SortedList<int, string> s1 = new SortedList<int, string>();

            s1.Add(1, "Pune");
            s1.Add(2, "Mumbai");
            s1.Add(3, "Nagpur");
            s1.Add(7, "Uttar Pradesh");
            s1.Add(8, "Delhi");

            foreach (KeyValuePair<int, string> item in s1)
            {
                Console.WriteLine(item.Key + "->" + item.Value);
            }
            Console.WriteLine("==================");
            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();

            sd.Add(1, "Pune");
            sd.Add(2, "Mumbai");
            sd.Add(3, "Nagpur");
            sd.Add(7, "Uttar Pradesh");
            sd.Add(8, "Delhi");

            foreach (KeyValuePair<int, string> item in sd)
            {
                Console.WriteLine(item.Key + "->" + item.Value);
            }
            Console.WriteLine("-------------------");


        }
    }
}
