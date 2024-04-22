using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class HashTabledemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(11, "Akasj");
            ht.Add(13, "suraj");
            ht.Add(45, "Nilesh");
            ht.Add(75, "Suyash");
            ht.Add(95, "Lion");
            ht.Remove(95); // remove is based on key


            foreach (DictionaryEntry item in ht)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
               

        }
    }
}
