using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class StudentInfo
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine(s1.Display());
            //For static keyword
            Console.WriteLine(Student.getCount());


            Student s2 = new Student(102,"Manoj");
            Console.WriteLine(s2.Display());
        }
    }
}
