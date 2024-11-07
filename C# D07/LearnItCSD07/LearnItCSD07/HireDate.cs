using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD07
{
    public class HireDate:IComparable
    {
        int day;
        int month;
        int year;

        public int Day
        {
            get
            {
                return day;
            }

            set
            {
                day = value;
            }
        }

        public int Month
        {
            get
            {
                return month;
            }

            set
            {
                month = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public HireDate()
        {
            day = 1;
            month=1; 
            year=2001;
        }
        public HireDate(int _day,int _month,int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }
        public override string ToString() 
        {
            return $"{day}/{month}/{year}";
        }

        public int CompareTo(object obj)
        {
            HireDate right = (HireDate)obj;
            return this.year.CompareTo(right.year);
        }
    }
}
