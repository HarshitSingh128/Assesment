using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class ShapeInfo
    {
        static void Main(string[] args)
        {


            Circle c1 = new Circle(12);
            c1.CalArea();
            Console.WriteLine(c1.Print());
            Rectangle r1 = new Rectangle(12,41);
            r1.CalArea();
            Console.WriteLine(r1.Print());
        }
    }
}
