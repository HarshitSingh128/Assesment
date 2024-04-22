using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Stringmethoddemo
    {
        static void Main(string[] args)
        {
            string d1 = "I love my India ";
            Console.WriteLine(d1);//print string
          
            Console.WriteLine(d1.IndexOf('I'));//it gives first index of i
            Console.WriteLine(d1.LastIndexOf('I'));//it gives last index of i

            string d2 = "India is very beatiful";
            d1.Concat(d2);
            
            Console.WriteLine(d1);
            Console.WriteLine(d1.Contains("India"));//it verifies content are in string or not


            string s3 = "Hello";
            string s2 = new string("Hello");
            Console.WriteLine(s3 == s2);
            Console.WriteLine(s3.Equals(s2));//it gives true because there is not any concept of scp


            Console.WriteLine(d1.ToUpper());//convert in upper case

            Console.WriteLine(d1.ToLower());//convert in lower case
         
            Console.WriteLine(d1.Trim());//it remove first and last spaces
            Console.WriteLine(d1.Substring(1));//it gives string from 1 to till length and index 1 not inculde

            Console.WriteLine(d1.Substring(1, 5));////it gives string from 1 to index 5 and index 1 not inculde

            d1.ToCharArray();//converts into charcter array
            Console.WriteLine(d1);
            
            d2.Split(" ");//string to string[] on condition spaces
            Console.WriteLine(d2);

            string d3 = "Hello  ";
            Console.WriteLine(d3.Length);
            Console.WriteLine(d3.Remove(5));
            Console.WriteLine(d3.Replace('H','h'));
           // Console.WriteLine(d3.Reverse());






        }
    }
}
