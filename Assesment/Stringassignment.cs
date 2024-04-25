using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    //1.	WAP to split string into 2 tokens where string is “HELLO$WORLD”
    public class Stringassignment
    {
        public static void SplitDemo(string s) {
            string[] st = s.Split("$");
            foreach (string item in st)
            {
                Console.WriteLine(item + " ");
            }


        }
        //2.	Write a C# program to find first occurrence of a character in a given string.
        public static void  Firstoccurance(string s)
        {
            string[] st = s.Split(" ");

        }

        public static void TrimDemo(string s)
        {
            s.Trim();
            Console.WriteLine(s);




        }
        //5.	Write a C# program to count total number of words in a string. 
        public static void Counttest(string s)
        {
            int count = 0;
            string[] st = s.Split(" ");
            for(int i = 0; i < st.Length; i++)
            {
                count++;
                //Console.WriteLine(st);
            }
            Console.WriteLine(count);

        }
        static void Main(string[] args)
        {
            string s1 = "HELLO$WORLD";
            SplitDemo(s1);
            Console.WriteLine("-----------------------");
            string sr = "Java is programming language";
            Firstoccurance(sr);

            Console.WriteLine("---------Trim Demo------------");
            string s2 = " Hello ";
            TrimDemo(s2);
            Console.WriteLine("--------");
            string s3 = "Java is good programming language and it is very easy to understand";
            Counttest(s3);
            Console.WriteLine("----------------");



        }
    }
}
