using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD07
{
    public enum Gender
    {
        Male,
        Female
    }
    [Flags]
    public enum Position 
    {
        Developer=1,
        secretary=2,
        DBA=4,
        Tester=8,
        Admin=16,
        Senior=7
    }

    //attribute class
    [Flags]
    enum DayName 
    {
        Friday=1,
        Saturday=0b10,
        Sunday=0x4,
        Monday=0b1000,
        Tuesday=16,
        Wednesday=32,
        Thursday=64
    }
}
