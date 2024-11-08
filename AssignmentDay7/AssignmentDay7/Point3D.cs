using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay7
{
    public class Point3D: IComparable<Point3D>, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D()
        {
            X = Y = Z = 0;
        }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"Point {X}, {Y}, {Z}";
        }

        public static implicit operator string(Point3D pt)
        {
            return pt.ToString();
        }

        public int CompareTo(Point3D other)
        {
            if (this.X != other.X)
            {
                return this.X.CompareTo(other.X);
            }
            return this.Y.CompareTo(other.Y);
        }

        public object Clone()
        {
            return new Point3D(this.X, this.Y, this.Z);
        }


    }
}
