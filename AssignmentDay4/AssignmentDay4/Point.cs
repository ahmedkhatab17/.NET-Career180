using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay4
{
    public class Point
    {
        int x, y;
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
        public Point()
        {
            x = y = 0;
            Console.WriteLine("Point def ctor");
        }
        public Point(int _x,int _y )
        {
            x = _x;
            y = _y;
            Console.WriteLine("Point 2p ctor");
            
        }
        public string PrintPoint()
        {
            return $"{x}, {y}";
        }

    }
}
