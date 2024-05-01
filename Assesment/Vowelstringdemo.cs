using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Vowelstringdemo
    {
        public static void Voweltest(string s)
        {
            char[] ch = s.ToCharArray();
            int count = 0;
            int count1 = 0;
            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i]=='a'|| ch[i]=='e' || ch[i]=='i' || ch[i]=='o' || ch[i]=='u' || ch[i] == 'A' || ch[i] == 'E' || ch[i] == 'I' || ch[i] == 'O' || ch[i] == 'U')
                {
                    count++;
                }
                else
                {
                    count1++;
                }
              
            }
            Console.WriteLine("Vowel is:"+count+" "+"Consonent is:"+count1);

        }
        static void Main(string[] args)
        {
            string s1 = "Java";
            Voweltest(s1);   
        }
    }
}
