using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD04
{
    ///association / aggregation
    public class Triangle
    {
        Point p1;
        Point p2;
        Point p3;

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

        public Triangle()
        {
            p1 = null;
            p2 = null;
            p3 = null;
            Console.WriteLine("Tri def ctor");
        }
        public Triangle(Point _p1,Point _p2 ,Point _p3)
        {
            p1 = _p1;
            p2 = _p2;
            p3 = _p3;
        }

        //=> composition
        public Triangle(int x1,int y1,int x2,int y2,int x3,int y3)
        {
            //p1 = new Point(x1,y1);
            //p2 = new Point(x2,y2);
            //p3 = new Point(x3,y3);
            //RUNTIME ERROR
            p1.X=x1;
            p1.Y=y1;
            p2.X=x2;
            p2.Y=y2;
            p3.X=x3;
            p3.Y=y3;
        }
    }
}
