using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay4
{
    public class Rect
    {
        Point ul, lr;

        public Point Ul
        {
            get
            {
                return ul;
            }

            set
            {
                ul = value;
            }
        }

        public Point Lr
        {
            get
            {
                return lr;
            }

            set
            {
                lr = value;
            }
        }

        public Rect()
        {
            ul = new Point();
            lr = new Point();
            Console.WriteLine("rect def ctor");

        }
        public Rect(int x1, int y1, int x2, int y2)
        {
            ul = new Point(x1, y1);
            lr = new Point(x2, y2);
            Console.WriteLine("rect 4p ctor");
        }
        public string PrintRect()
        {
            return $"Line start {ul.PrintPoint()}, End {lr.PrintPoint()}";
        }
    }
}
