using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Trimstringassign
    {
        //4.	Write a C# program to trim leading white space characters in a string.
        static string TrimLeadingWhiteSpace(string str)
        {
            return str.TrimStart();
        }
        //   7.	Write a C# program to trim trailing white space characters in a string.
        static string TrimTrailingWhiteSpace(string str)
        {
            return str.TrimEnd();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("---Leading white spaces-----");
            string str = "    Hello, world!   ";
            string trimmedStr = TrimLeadingWhiteSpace(str);

            Console.WriteLine("Original string: '{0}'", str);
            Console.WriteLine("String after trimming leading white space: '{0}'", trimmedStr);
            Console.WriteLine();
            Console.WriteLine("-----Trailling white spaces-----");

            string st = "   Hello, world!    ";
            string trimmedSt = TrimTrailingWhiteSpace(st);

            Console.WriteLine("Original string: '{0}'", st);
            Console.WriteLine("String after trimming trailing white space: '{0}'", trimmedSt);


        }
    }
}
