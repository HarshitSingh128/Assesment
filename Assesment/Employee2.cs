using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Employee2 : IComparable<Employee2>
    {


        protected string name;
        protected double salary;
        public Employee2(string name, double salary)
        {
            this.name = name;
            this.salary = salary;

        }

        public int CompareTo(Employee2? other)
        {
            if (this.salary > other.salary)
            {
                return 1;

            }
            else if (this.salary < other.salary)
            {
                return -1;

            }
            else
            {
                return 0;
            }
        }
             public override string ToString()
        {
            return $"Name={name},Salary={salary}";

        }

    }
}
