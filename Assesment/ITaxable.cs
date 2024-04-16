using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//implicit interface
namespace Assesment
{
    public interface ITaxable
    {
        double Paytax();//public ,abstract virtual
    }
    //implicit implement of interface

    public class Job : ITaxable
    {
        private double salary;
        private double taxamount;
        //ctor for constuctor
        public Job()
        {
            salary = 10000;
        }
        public double Paytax()
        {
            taxamount = salary * .20;
            return taxamount;

        
        }
    }
    public class Business : ITaxable
    {
        private double salary;
        private double taxamount;
        //ctor for constuctor
        public Business()
        {
            salary = 10000;
        }
        public double Paytax()
        {
            taxamount = salary * .30;
            return taxamount;


        }
    }
}
