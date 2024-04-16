using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;

        }
        public string Display()
        {
            return $"{day}-{month}-{year}";
        }

    }

    
}
