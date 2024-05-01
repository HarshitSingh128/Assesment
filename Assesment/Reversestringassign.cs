using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Reversestringassign
    {
        //10.	Write a C# program to find reverse of a string.


        public static void ReverseTest(string s)
        {
            string rev ="";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i];

            }
            Console.WriteLine(rev);


        }
        //11.	Write a C# program to reverse order of words in a given string.
        public static void Findreversebyword(string st){
            string[] s = st.Split(" ");
            string rev = "";
            for(int i = 0; i < s.Length; i++)
            {
                for(int j = s[i].Length - 1; j >= 0; j--)
                {
                    rev = rev + s[i][j];
                }
                rev = rev + " ";
            }
            Console.WriteLine(rev);

        }
        static void Main(string[] args)
        {
            string s1 = "Java";
            ReverseTest(s1);
            Console.WriteLine("-------Reverse by word--------");

            string str = "I like java programming";
            Findreversebyword(str);




        }
    }
}
