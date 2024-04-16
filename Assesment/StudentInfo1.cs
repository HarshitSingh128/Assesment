using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class StudentInfo1
    {
        static void Main(string[] args)
        {
            Student1 s1 = new Student1(101,"Mukesh");
            //s1.calpercentage();
            s1.fulldetails(102, "Raju", 78, 89, 78);
        }
    }
}
