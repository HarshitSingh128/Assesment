using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Users
    {
        public string name, city;
        public bool isCustomer;
        // user as admin / customer
        //When you pass any value with argument with some default value, predefined 
        public void Accept(string name, string city, bool isCustomer = true, string country = "ind")//bool isCustomer=true -> default argument
        {
            this.name = name;
            this.isCustomer = isCustomer;
            this.city = city;
        }
    }

}
