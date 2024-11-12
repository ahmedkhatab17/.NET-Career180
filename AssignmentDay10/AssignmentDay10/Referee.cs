using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay10
{
    public class Referee
    {
        public String Name {  get; set; }
        public String RefereeType { get; set; }

        public Referee() {
            Name = "omar";
            RefereeType = "Main Referee";
        }
        //callback
        public void Observe(Location loc)
        {
            Console.WriteLine($"Referee {Name} is observing ball{loc}");
        }


    }
}
