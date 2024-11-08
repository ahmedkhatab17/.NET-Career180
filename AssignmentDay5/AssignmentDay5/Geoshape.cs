using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5
{
    public abstract class Geoshape
    {
        private double dim2;
        private double dim1;

        public double Dim1
        {
            get
            {
                return Dim11;
            }

            set
            {
                Dim11 = value;
            }
        }

        public double Dim2
        {
            get
            {
                return Dim21;
            }

            set
            {
                Dim21 = value;
            }
        }

        public double Dim21
        {
            get
            {
                return dim2;
            }

            set
            {
                dim2 = value;
            }
        }

        public double Dim11
        {
            get
            {
                return dim1;
            }

            set
            {
                dim1 = value;
            }
        }

        public Geoshape()
        {
            Dim11 = Dim21 = 0;
            Console.WriteLine("Geo def ctor");
        }
        public Geoshape(double _dim1, double _dim2)
        {
            Dim11 = _dim1;
            Dim21 = _dim2;
            //Console.WriteLine("Geo 2p ctor");
        }
    }
    public class Rect : Geoshape
    {
        public Rect()
        {
            Console.WriteLine("Rect def ctor");
        }
        public Rect(double _d1, double _d2) : base(_d1, _d2)
        {
            Dim1 = _d1;
            Dim2 = _d2;
            //Console.WriteLine("rect 2p ctor");
        }
        public double CArea()
        {
            return Dim11 * Dim21;
        }
    }
    public class Square : Rect
    {
        public Square()
        {
            Console.WriteLine("Square def ctor");
        }
        public Square(double _dim) : base(_dim, _dim)
        {
            //Console.WriteLine("Square 1p ctor");
        }

    }
    public class Tri : Geoshape
    {
        public Tri() {
            Console.WriteLine("Tri def ctor");
        }
        public Tri(double _base, double _height) : base(_height, _base) {
            //Console.WriteLine("Tri 2p ctor");
        }

        public double CArea()
        {
            return 0.5 * Dim1 * Dim2;
        }
    }
    public sealed class Circle : Geoshape
    {
        public Circle()
        {
            Console.WriteLine("Circle def ctor");
        }
        public Circle(double _radius) : base(_radius, _radius)
        {
            //Console.WriteLine("Circle 1p ctor");
        }
        public double CArea()
        {
            return Math.PI * Dim1 * Dim2;
        }
    }

}
