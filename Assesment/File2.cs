using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public partial class Calc
    {
        public void  Sub(double a, double b)
        {
            double res = a - b;
            Print(res);
        }
        public void Div(int a,int b)
        {
            int res = a / b;
            Print(res);
        }
        partial void Print(double c)
        {
            Console.WriteLine($"Result={c}");
        } 

    }
}
