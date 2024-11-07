using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD06
{
    public abstract class Geoshape
    {
        protected double dim1;
        protected double dim2;

        public double Dim1
        {
            get { return dim1; }
            set { dim1 = value; }
        }
        public double Dim2
        {
            get { return dim2; }
            set { dim2 = value; }
        }
        public Geoshape()
        {
            dim1 = dim2 = 0;
            Console.WriteLine("Geo def ctor");
        }
        public Geoshape(double _dim1, double _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
            Console.WriteLine("Geo 2p ctor");
        }
        //////
        //public virtual double CArea()
        //{
        //    return -1;
        //}
        //////
        //
        public abstract double CArea();
        //
    }
    //
    public class Rect : Geoshape
    {
        //inherits dim1,dim2 Dim1 Dim2
        //data fields??? NO
        ///Rect r1=new Rect();
        public Rect()
        {
            Console.WriteLine("Rect def ctor");
        }
        public Rect(double _d1, double _d2) : base(_d1, _d2)
        {
            //useless after ctor chaining
            dim1 = _d1;
            dim2 = _d2;
            Console.WriteLine("rect 2p ctor");
        }
        public override double CArea()
        {
            return dim1 * dim2;
        }
    }
    //
    public class Square : Geoshape
    {
        public Square()
        {
            Console.WriteLine("Sq def ctor");
        }
        public Square(double _dim) : base(_dim, _dim)
        {
            dim2 = dim1 = _dim;
        }
        public override double CArea()
        {
            return dim1 * dim2;
        }

    }
    //
    public class SquareV2 : Rect
    {
        public SquareV2()
        {

        }
        public SquareV2(double _dim) : base(_dim, _dim)
        {

        }
    }
    //
    public class Tri : Geoshape
    {
        public Tri()
        {

        }
        public Tri(double _base, double _height) : base(_height, _base)
        {

        }
        public override double CArea()
        {
            return 0.5 * dim1 * dim2;
            return dim1 * dim2 * (1 / 2);
        }
    }

    public class Circle : Geoshape
    {
        public Circle()
        {

        }
        public Circle(double _radius) : base(_radius, _radius)
        {

        }
        public override double CArea()
        {
            return Math.PI * dim1 * dim2;
            return 3.14 * dim1 * dim2;
            // WRONG return 22/7 * dim1 * dim2;
        }
    }

}


