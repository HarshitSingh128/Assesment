

using System.Globalization;

namespace Assesment
{
    public class Firstprogram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter a number");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            int d = a - b;
            Console.WriteLine("Addition is "+c);
            Console.WriteLine("Substractin is "+d);


        }



    }
   
}
