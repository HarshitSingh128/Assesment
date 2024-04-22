using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Player:IComparable<Player>
    {
        private string name;
        private int runs;
        public Player(string name, int runs)
        {
            this.name = name;
            this.runs = runs;
        }
        public int Runs
        {
            get { return runs; }
        }


        public int CompareTo(Player? other)
        {
            if (this.runs > other.runs)
            {
                return 1;

            }
            else if (this.runs < other.runs)
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
            return $"Name={name},Runs={runs}";

        }
       
    }

    public class Team : IEnumerable
    {
        private Player[] players;
        public Team()
        {
            players = new Player[5];
            players[0] = new Player("Virat", 3000);
            players[1] = new Player("Gabbar", 4000);
            players[2] = new Player("Hitman", 7000);
            players[3] = new Player("MurliVijay", 9000);
            players[4] = new Player("Ishan", 1000);

        }

        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }
}
