using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public interface ICustomer
    {
        string Print();
    }
    public interface IOreder
    {
        string Print();
    }
    
    public class Transaction : ICustomer, IOreder
    {
        string ICustomer.Print()
        {
            return "Customer Details";
          
        }

        string IOreder.Print()
        {
            return "Oreder Details";
            
        }
    }
}
