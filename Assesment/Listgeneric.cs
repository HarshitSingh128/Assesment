using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Listgeneric
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>();
            l1.Add(11);
            l1.Add(21);
            l1.Add(13);
            l1.Add(17);
            l1.Add(19);


            //l1.AddRange(l1);//it take a collection and print all the element in given collection
            Console.WriteLine("List capacity is:" + l1.Capacity);//By default capacity is 8 of list
            //l1.Clear();//it remove all the element of collection
            Console.WriteLine("Count is:" + l1.Count);//it gives total data of collection 
            Console.WriteLine("Average is:" + l1.Average());//list has inbuilt average method
            Console.WriteLine("Sum is:" + l1.Sum());//list has inbuilt sum method

            // l1.Remove(11);//remove contains element of specific index

            // l1.RemoveAt(0);//RemoveAt contains index of specific element

            Console.WriteLine(l1.Contains(11));//contains tell us the element is present or not
            l1.Insert(1, 12);//it insert element on given index
            Console.WriteLine("fIRST is:" + l1.First());//it gives first element
            Console.WriteLine(l1.IndexOf(12));//it gives index of given element

            foreach (int i in l1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------List with String-----------");

            List<string> l2 = new List<string>();
            l2.Add("Mukesh");
            l2.Add("Suresh");
            l2.Add("Makhan");

            foreach (string i in l2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----Stack demo--------");

            Stack<int> l3 = new Stack<int>();
            l3.Push(11);
            l3.Push(21);
            l3.Push(13);
            l3.Push(17);
            l3.Push(19);


            Console.WriteLine("Count is:" + l3.Count);
            Console.WriteLine(l3.Contains(11));
            Console.WriteLine("Average is:" + l3.Average());
            Console.WriteLine("Sum is:" + l3.Sum());

            // l3.Clear();
            // Console.WriteLine(l3.Pop());// it remove top element of stack 
            Console.WriteLine(l3.Peek());//it gives top element of stack
            Console.WriteLine("Element is:" + l3.ElementAt(2));//it gives element at given index
            //l3.Reverse();
            Console.WriteLine("First is:" + l3.First());
            Console.WriteLine("Capacity is:" + l3.EnsureCapacity(5));//default capacity is 8 of stack
            foreach (int i in l3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----Stack with string----------");
            Stack<string> l4 = new Stack<string>();
            l4.Push("Suyash");
            l4.Push("Anmol");
            l4.Push("Amit");
            l4.Push("Rajesh");

            foreach (string i in l4)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("=========Queue with string=========");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amol");
            queue.Enqueue("Suraj");
            queue.Enqueue("Rajesh");
            queue.Enqueue("Harsh");
            queue.Enqueue("Harshit");

           // Console.WriteLine(queue.Dequeue());

            foreach (string i in queue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("=============Queue with Custom class==================");
            Queue<Product1> q = new Queue<Product1>();
            q.Enqueue(new Product1 { Pid = 1, Pname = "Suayash", Price = 15000 });


            foreach (Product1 i in q)
            {
                Console.WriteLine(i);
            }




        }
    }
}
