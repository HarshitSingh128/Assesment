using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class NameException : Exception
    {
        public NameException(string error) : base(error)
        {

        }
    }

    public class Person
    {
        public string name;
        public void AcceptName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.name = name;
            }
            else
            {
                // raise an exception
                throw new NameException("Name is required");
            }
        }
    }



}
