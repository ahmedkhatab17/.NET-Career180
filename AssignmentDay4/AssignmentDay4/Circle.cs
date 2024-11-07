using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay4
{
    //Association  &composition
    public class Circle
    {
        Point center;
        int redius;

        public Point Center
        {
            get
            {
                return center;
            }

            set
            {
                center = value;
            }
        }
        public int Redius
        {
            get
            {
                return redius;
            }

            set
            {
                redius = value;
            }
        }

        public Circle()
        {
            center = default;
            redius=default;
        }
        //Association
        public Circle(Point _center, int _redius )
        {
            center= _center;
            this.redius = _redius;
        }
        //composition
        public Circle(int x1,int y1,int _radius)
        {
            center = new Point(x1,y1);
            redius = _radius;
        }
        public string PrintCircle()
        {
            return $"Center {center.PrintPoint()},Redius {redius}";
        }

    }
}
