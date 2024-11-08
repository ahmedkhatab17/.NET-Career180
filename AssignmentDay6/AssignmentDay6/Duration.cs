using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay6
{
    public class Duration
    {
        int hours;
        int minutes;
        int seconds;
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int _hours, int _minutes, int _seconds)
        {
            Hours = _hours;
            Minutes = _minutes;
            Seconds = _seconds;
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }

        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }
        private int ToSeconds()
        {
            return (Hours * 3600) + (Minutes * 60) + Seconds;
        }
        //D3 = D1 + D2
        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = d1.ToSeconds() + d2.ToSeconds();
            return new Duration(totalSeconds);
        }
        //D3 = D1 + sec
        public static Duration operator +(Duration d1, int seconds)
        {
            int totalSeconds = d1.ToSeconds() + seconds;
            return new Duration(totalSeconds);
        }
        //D3 = sec + D1
        public static Duration operator +(int seconds, Duration d1)
        {
            int totalSeconds = d1.ToSeconds() + seconds;
            return new Duration(totalSeconds);
        }
        //D3 = D1++
        public static Duration operator ++(Duration d1)
        {
            int totalSeconds = d1.ToSeconds() + 60;
            return new Duration(totalSeconds);
        }

        //D3 = --D2
        public static Duration operator --(Duration d1)
        {
            int totalSeconds = d1.ToSeconds() - 60;
            return new Duration(totalSeconds);
        }
        //D1 > D2
        public static bool operator > (Duration d1, Duration d2)
        {
            return d1.ToSeconds() > d2.ToSeconds();
        }
        //D1 <= D2
        public static bool operator < (Duration d1, Duration d2)     ///    ! <=
        {
            return d1.ToSeconds() < d2.ToSeconds();
        }

        

    }

}
