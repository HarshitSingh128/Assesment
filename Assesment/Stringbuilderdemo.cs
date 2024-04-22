using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Stringbuilderdemo
    {
        static void Main(string[] args)
        {
            StringBuilder s1 = new StringBuilder();
            s1.Append("Hello");
            Console.WriteLine(s1);

            Console.WriteLine(s1.GetHashCode());

            s1.Append(" hello to All");
            Console.WriteLine(s1);
            Console.WriteLine(s1.GetHashCode());
            /*
            s1.Append("Welocme to India ");
             Console.WriteLine(s1);
            Console.WriteLine(s1.GetHashCode());
            */

            Console.WriteLine(s1.Capacity);//by default capcity is 32 and grow by double


            Console.WriteLine(s1.Length);

            s1.Append(" India is very beautiful");
            Console.WriteLine(s1);
            Console.WriteLine(s1.GetHashCode());
            s1.Remove(0, 5);
            Console.WriteLine(s1);
            s1.Replace('h','H');
            Console.WriteLine(s1);
            s1.Clear();
           






        }
    }
}
