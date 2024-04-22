using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public  class Movei
    {
      
        public Movei(int Mid,string Mname,double Tcost,string Pname)
        {
            this.Mid = Mid;
            this.Mname = Mname;
            this.Tcost = Tcost;
            this.Pname = Pname;
                
        }
        public int Mid { get; set; }
        public string Mname{ get; set; }
        public double Tcost{ get; set; }
        public string Pname { get; set; }


        public string ToSting()
        {
            return $"Movieid={Mid},MoveiName={Mname},TicketCost={Tcost},ProducerName={Pname}";

        }

    }
}
