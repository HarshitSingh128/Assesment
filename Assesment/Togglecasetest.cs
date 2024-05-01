using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Togglecasetest
    {
        //8.	Write a C# program to toggle case of each character of a string.
        public static void ToggleTest(string s)
        {
            char[] ch = s.ToCharArray();
            for(int i = 0; i < ch.Length; i++)
            {
                if (char.IsUpper(ch[i]))
                {
                    ch[i] = char.ToLower(ch[i]);

                }
                else if (char.IsLower(ch[i]))
                {
                    ch[i] = char.ToUpper(ch[i]);
                }
            }
            foreach(char c in ch)
            {
                Console.Write(c);
            }


        }
        static void Main(string[] args)
        {
            string s = "Java";
            ToggleTest(s);
            
        }
    }
}
