using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD10
{
    //Publisher
    public class Football
    {
        public int Id { get; set; }
        public string FootballName { get; set; }
        Location location;
        public Location Location
        {
            set //(Location value)
            {
                if(value != location) 
                {
                    //fire event
                    //BallLocationChanged();

                    //if(BallLocationChanged != null) 
                    //{
                    //    BallLocationChanged();
                    //}

                    BallLocationChanged?.Invoke(value);
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
            return $"football in location {this.location}";
        }

        //event framework
        ///public event DelegateType EventNameInPastSimple;
        ///
        //public event Action BallLocationChanged;
        //build frameworrk and who interested will subscribe with same signature
        
        public event Action<Location> BallLocationChanged;

        //event ->
        //1- event firing must in publisher
        //2- when subscribe , you must use += or -=


        //Most Commonly used
        //EventHandler
    }
}
