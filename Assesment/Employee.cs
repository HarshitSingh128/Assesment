using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assesment
{
    public class Employee
    {
        protected int id;
        protected string name;
        protected double bs, hra, pf, gross;

        public Employee()
        {

        }

        public Employee(int id,String name,double b,double h,double p)
        {
            this.id = id;
            this.name = name;
            this.bs = b;
            this.hra = h;
            this.pf = p;
        }
        public void Accept(int id,string name,double b,double h,double p)
        {
            id = id;
            name = name;
            bs = b;
            hra = h;
            pf = p;



        }
        public virtual void calsal()
        {
            gross = (bs + hra) - pf;
        }
        public virtual string Display()
        {
            return $"empid={id},empname={name},gross={gross}";
        }
      
    }
}
