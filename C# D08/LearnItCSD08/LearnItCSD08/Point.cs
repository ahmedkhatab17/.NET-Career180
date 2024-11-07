using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD08
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        //public Point()
        //{
        //    X = Y = 0;
        //}
        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
        public override string ToString()
        {
            return $"({X},{Y})";
        }

        //chane behavior to check equality by state[VALUES]
        public override bool Equals(/*Point this,*/object? obj)
        {
            
            //Best way to write effective code 
            //to check objects equality
            Point right = obj as Point;

            if (right is null) { return false; }

            if (this.GetType() != right.GetType()) { return false; }

            if (object.ReferenceEquals(this, right)) { return true; }

            return this.X == right.X && this.Y == right.Y;

            //with casting
            //  obj is Point
            //   as

            //if (obj is Point right)  //RECOMMENDED
            //{
            //    return X == right.X && Y == right.Y;
            //}


            //NOT Effective Code
            //if (obj is Point)
            //{
            //    Point right= obj as Point;
            //    return X == right?.X && Y == right?.Y;
            //}
            //else
            //{
            //    return false;
            //}


            ////worst casting ever [not recommended]
            ////casting
            //Point right = (Point)obj;
            //return X == right.X && Y == right.Y ;
        }
    }
    /////////////////////////////////////////
    public class Point3d : Point
    {
        public int Z { get; set; }
        public Point3d():base(0,0)
        {
            Z = 0;
        }
        public Point3d(int _x, int _y, int _z) : base(_x, _y)
        {
            Z = _z;
        }
        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }
    }
}
