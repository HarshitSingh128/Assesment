using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class ArrayListdemo
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();// u can also set the default initial value of ArrayList
            a1.Add(15);
            a1.Add(55.54);
            a1.Add('c');
            a1.Add("Manoj");

            int[] arr = { 2, 4, 6, 4, 2, 4 };

            a1.Add(45);
            a1.Add(88);
            a1.Add(11);
            a1.AddRange(arr);//it is used to pass any coolection

            /*

            a1.RemoveAt(2); // 2 is index
            a1.Remove(20); // remove based on object / element present in the collection
            a1.RemoveRange(1, 3);// remove multiple values from collections

            a1.Clear(); // clear list at once

            //a1.Sort();//asc
            //a1.Reverse();//desc
            //Console.WriteLine($"Total elements in list = {a1.Count}");

            */


            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
