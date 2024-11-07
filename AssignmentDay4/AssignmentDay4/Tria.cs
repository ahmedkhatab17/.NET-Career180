using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay4
{
    //Association  &composition
    public class Tria
    {
        Point p1 , p2 ,p3;

        public Point P1
        {
            get
            {
                return p1;
            }

            set
            {
                p1 = value;
            }
        }

        public Point P2
        {
            get
            {
                return p2;
            }

            set
            {
                p2 = value;
            }
        }

        public Point P3
        {
            get
            {
                return p3;
            }

            set
            {
                p3 = value;
            }
        }

        public Tria()
        {
            p1 = null;
            p2 = null;
            p3 = null;
            Console.WriteLine("tria def ctor");
        }
        //Association
        public Tria (Point _p1, Point _p2, Point _p3)
        {
            p1 = _p1;
            p2 = _p2;
            p3 = _p3;
        }
        //composition
        public Tria(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y2);
            p3 = new Point(x3, y3);

        }
        public string PrintTria()
        {
            return $"Point 1 {p1.PrintPoint()},Point 2 {p2.PrintPoint()},Point 3 {p3.PrintPoint()}";
        }

    }
}
