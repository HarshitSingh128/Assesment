using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assesment
{
    public class NamedArgumentanddefaultparameterdemo
    {
        static void Main(string[] args)
        {
            Users u1 = new Users();
            u1.Accept("Amol", "Pune");// isCustomer is my optional parameter
        

            Users u2 = new Users();
            u2.Accept("Suraj", "Mumbai", false);// override the value
            


            u2.Accept("John", "abc", true, "UK");
         

            u2.Accept("Akshay", "Pune");


            Console.WriteLine("---------------Named parameter----------");
            /*
                       Named argument

           You can change sequence
           You can assign the value using argument name using : (colon)



                                   public class Users
                               {
                                   private string name, city;

                                   public Users(string name, string city)
                                   {
                                       this.name = name;
                                       this.city = city;
                                   }
                               }


                               Users u1 = new Users("Amol", "Pune");

                               // named arguments

                               Users u2 = new Users(city: "Mumbai", name: "Akshay");

                               Users u3 = new Users(name: "Akshay", city: "Mumbai");
                       */





        }
    }
}
