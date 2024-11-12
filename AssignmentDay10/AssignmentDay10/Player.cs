using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay10
{
    public class Player
    {
        public int Number {  get; set; }
        public string Name { get; set; }
        public string Team { get; set; }

        public Player() { 
            Number = 10;
            Name = "ahmed";
            Team = "ahly";

        }

        public override string ToString()
        {
            return $"{Name} from team {Team}";
        }

        // callback

        public void Run(Location loc)
        {
            Console.WriteLine($"Player {Name} from {Team} is runnung into ball{loc}");
        }


        


    }
}
