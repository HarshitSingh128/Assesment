using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class PlayerCompare : IComparer<Player>
    {
        // x-> virat , y-> rohit
        public int Compare(Player? x, Player? y)
        {
            if (x.Runs > y.Runs)
            {
                return 1;
            }
            else if (x.Runs < y.Runs)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

}
