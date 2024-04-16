using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    //extends=: in c#
    public class Manager : Employee
        
    {
        private double food;
        //base keyword will call the base class constructor


        public Manager():base()
        {

        }
        public Manager(int id,string name ,double b,double h,double p,double food) : base(id, name, b, h, p)
        {
            this.food = food;

        }
        public override void calsal()
        {
            gross = (bs + hra) - pf;
        }
        public void assign()
        {

        }
        public override string Display()
        {
            return $"magid={id},magname={name},gross={gross}";
        }

    }
}
