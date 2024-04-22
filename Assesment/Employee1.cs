using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Employee1
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public double Esalary { get; set; }
        
        public Employee1(int Eid,string Ename,double Esalary)
        {
            this.Eid = Eid;
            this.Ename = Ename;
            this.Esalary = Esalary;
            
        }
        
        public string Tostring()
        {
            return $"Employeeid={Eid},Employeename={Ename},Employeesalary={Esalary}";
        }
    }
}
