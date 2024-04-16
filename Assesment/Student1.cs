using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Student1
    {
         int sid;
         string sname;
         double sub1, sub2, sub3;

        public  Student1(int sid,string sname)
         
        {
            this.sid = sid;
            this.sname = sname;
            Console.WriteLine("Studentid="+sid+" "+"StudentName="+sname);
        }
        public void calpercentage()
        {
            Console.WriteLine("Enter Marks of sub1");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks of sub2");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks of sub3");
            sub3 = Convert.ToInt32(Console.ReadLine());
            int total = 300;
            double per = (sub1 + sub2 + sub3) * 100 /total;
            Console.WriteLine("Percentage is:"+per);

        }
        public void fulldetails(int sid,string sname,double sub1,double sub2,double sub3)
        
            {
            int total = 300;
            double per = (sub1 + sub2 + sub3) * 100 / total;
            Console.WriteLine("StudentId="+sid+" "+"StudentName="+sname+" "+"Percentage="+per);
        }

    }
}
