using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Student
    {
        private int sid;
        private string name;
        private static int count;
        public Student()
        {
            count++;
            sid = count;
            name = "Anmol";
            
        }
        public Student(int count,string name)
        {
            count++;
            this.sid = count;
            this.name = name;
        }
        public static int getCount()
        {
            return count;
        }
        public string Display()
        {
            return $"StudentId={sid},Studentname={name}";
        }
        
            
        
    }
}
