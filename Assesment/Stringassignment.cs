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
        public static void SplitDemo(string s)
        {
            string[] st = s.Split("$");
            foreach (string item in st)
            {
                Console.WriteLine(item + " ");
            }


        }
        //2.	Write a C# program to find first occurrence of a character in a given string.
        //3.	Write a C# program to count occurrences of a character in given string.
        public static void Firstoccurance(string s, char ch)
        {
            int i;
            char[] ch1 = s.ToCharArray();
            bool flag = false;
            int count = 0;
            for (i = 0; i < ch1.Length; i++)
            {
                if (ch1[i] == ch)
                {
                    flag = true;

                    count++;
                    Console.WriteLine("Index is:" + i);
                }


                if (!flag)
                {
                    Console.WriteLine("Element Not found");

                }

            }
            Console.WriteLine("Occurancse is:"+count);


        }
        //6.	Write a C# program to remove all occurrences of a character from string.
        static string RemoveCharacter(string str, char c)
        {
            return str.Replace(c.ToString(), string.Empty);
        }




        //5.	Write a C# program to count total number of words in a string. 
        public static void Counttest(string s)
        {
            int count = 0;
            string[] st = s.Split(" ");
            for (int i = 0; i < st.Length; i++)
            {
                count++;

            }
            Console.WriteLine(count);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("----Split Demo---");
            string s1 = "HELLO$WORLD";
            SplitDemo(s1);
            Console.WriteLine();
            Console.WriteLine("----------Occurances-------------");
            string sr = "harshit";
            Firstoccurance(sr, 'h');
            Console.WriteLine();
            Console.WriteLine("---------Remove all occrances------");
            string str = "Hello, World!";
            char ch = 'o';
            string result = RemoveCharacter(str, ch);

            Console.WriteLine("Original string: '{0}'", str);
            Console.WriteLine("String after removing '{0}': '{1}'", ch, result);

            Console.WriteLine();
            Console.WriteLine("---Word count-----");
            string s3 = "Java is good programming language";
            Counttest(s3);
          



        }
    }
}
