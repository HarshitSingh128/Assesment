using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Charctername
    {
        //7.	Write a Java program to input any character and check whether it is alphabet, digit or special character 
        //4.	Write a Java program to input any alphabet and check whether it is vowel or consonant 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter character");
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch=='A' || ch == 'E' || ch=='I' || ch=='O' || ch=='U' || ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else if(ch=='#' || ch=='$' || ch == '@')
            {
                Console.WriteLine("Special character");
            }
            else
            {
                Console.WriteLine("Alphabet");
            }
        }
    }
}
