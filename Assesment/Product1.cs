using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public  class Product1
    {
        public Product1()
        {
            
        }
        /*
        public Product1(int Pid,string Pname,double Price)
        {
            this.Pid = Pid;
            this.Pname = Pname;
            this.Price = Price;
        }
        */
        public int Pid { get; set; }
        public string Pname { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Id={Pid},Pname={Pname},Price={Price}";
        }






    }
}
