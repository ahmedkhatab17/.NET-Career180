using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD04
{
    public class Circle
    {
        Point center;
        int radius;

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

        public int Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        public Circle()
        {
            center = default;
            radius = default;
        }

        public Circle(Point _center,int _radius)
        {
            center = _center;
            radius = _radius;
        }
        public Circle(int x1,int y1,int _radius)
        { 
            center = new Point(x1,y1);
            radius = _radius;
        }
    }
}
