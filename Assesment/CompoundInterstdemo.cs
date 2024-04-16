using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class CompoundInterstdemo
    {
        //3.	Write a  program to enter P, T, R and calculate Compound Interest.
        static void Main(string[] args) { 
            double amount, p, rate, t, n, CI;
            p = 200;
            rate = 5;
            t = 2;
            n = 2;
            amount = p * Math.Pow(1 + rate / 100, t);
            CI = amount - p;
            Console.WriteLine("Amount is=" + amount);
            Console.WriteLine("compound interest is=" + CI);
        }
    }
}