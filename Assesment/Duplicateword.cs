using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    //15.	Write a C# program to find the duplicate words and their number of occurrences in a string
    public class Duplicateword
    {
        public static void Duplicatedemo(string s)
        {
            string[] ch = s.Split(" ");
            bool flag;
            int count;
            for (int i = 0; i < ch.Length; i++)
            {
                flag = false;
                count = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (ch[i].Equals(ch[j]))
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    for (int k = i + 1; k < ch.Length; k++)
                    {
                        if (ch[i].Equals(ch[k]))
                        {
                            count++;
                        }
                    }
                  
                     if (count > 1)
                    {
                      Console.WriteLine("Duplicate word is:" + ch[i]+" "+"Count is:"+count);
                    }
                  
                }

            }
        }
    
        static void Main(string[] args)
        {
            string s = "Java is programming language and Java is very easy";
            Duplicatedemo(s);
        }
    }
}
