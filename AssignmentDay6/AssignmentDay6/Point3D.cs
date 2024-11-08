using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay6
{
    public class Point3D
    {
        public int X {  get; set; }
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
    }
}
