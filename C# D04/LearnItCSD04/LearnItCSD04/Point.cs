using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD04
{
    public class Point
    {
        int x;
        int y;

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

        //l1 start call ->
        //l1 end->
        public Point()
        {
            x = y = 0;
            Console.WriteLine("Point def ctor");
        }

        public Point(int _x,int _y)
        {
            x = _x;
            y = _y;
            Console.WriteLine("Point 2p ctor");
        }
        public string PrintPoint() 
        {
            return $"({x},{y})";
        }

    }
}
