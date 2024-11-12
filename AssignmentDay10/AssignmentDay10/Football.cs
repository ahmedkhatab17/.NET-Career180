using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay10
{
    public class Football
    {
        public int Id {  get; set; }
        public string FootballName { get; set; }
        Location location;
        public Location Location {
            set
            {
                if (value != location)
                {
                    //fireeee  evet
                    //FootballLocatonChanged();

                    //if(FootballLocatonChanged != null)
                    //{
                    //    FootballLocatonChanged();
                    //}

                    FootballLocatonChanged?.Invoke(value);
                }
                location = value;
            }
            get
            {
                return location;
            }

        }

        public override string ToString()
        {
            return $"football in location {this.Location}";
        }
        ///event 
        ///public event DelegetType EventName

        //public event Action FootballLocatonChanged;

        public event Action<Location> FootballLocatonChanged;

    }
}
