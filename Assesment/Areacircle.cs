

namespace Assesment
{
    public class Areacircle
    {
        static void squarearea(int side)
        {
            double area = side * side;
            Console.WriteLine("Area of Square is "+area);
        }
        static double cubetest(int lenght)
        {
            double area = 6 * lenght * lenght;
            return area;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius");
            int r = Convert.ToInt32(Console.ReadLine());
            double area = 3.14 * r *r;
            Console.WriteLine("Area of circle is "+area);
            Console.WriteLine("==========================");
            squarearea(6);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Area of cube is" + cubetest(3));
           

        }
    }
}
