using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class ExceptionInfo
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            try
            {
                p1.AcceptName("");
            }
            catch (NameException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
