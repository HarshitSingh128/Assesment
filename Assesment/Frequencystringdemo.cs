using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Frequencystringdemo
    {
        //12.	Write a C# program to find highest frequency character in a string.
        public static void Frequencytest(string s)
        {
            char[] ch = s.ToCharArray();
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
                        if(ch[i].Equals(ch[k]) )
                        {
                            count++;
                        }
                    }
                     Console.WriteLine(ch[i]+"->" + "Frequency is:" + count);
                    // if (count > 1)
                    //{
                    //  Console.WriteLine("Duplicate is:" + ch[i]);
                    //}
                    //if (count == 1)
                    //{
                     //   Console.WriteLine("Unique is:" + ch[i]);
                    //}
                }

            }
        }
    
        static void Main(string[] args)
        {
            string st = "Javaisprogramming";
            Frequencytest(st);



        }
    }
}
