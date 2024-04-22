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
            foreach (int i in l1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------------");
            List<string> l2 = new List<string>();
            l2.Add("Mukesh");
            l2.Add("Suresh");
            l2.Add("Makhan");

            foreach (string i in l2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------");
            Stack<int> l3 = new Stack<int>();
            l3.Push(11);
            l3.Push(21);
            l3.Push(13);
            l3.Push(17);
            l3.Push(19);
            foreach (int i in l3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------");
            Stack<string> l4 = new Stack<string>();
            l4.Push("Suyash");
            l4.Push("Anmol");
            l4.Push("Amit");
            l4.Push("Rajesh");

            foreach (string i in l4)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("==================");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amol");
            queue.Enqueue("Suraj");
            queue.Enqueue("Rajesh");
            queue.Enqueue("Harsh");
            queue.Enqueue("Harshit");
            foreach (string i in queue)
            {
                Console.WriteLine(i);
            }

            Queue<Employee1> q = new Queue<Employee1>();
             // q.Enqueue( new Employee1 { Eid = 1,  Ename= "Suayash", Esalary=15000 });
           




        }
    }
}
