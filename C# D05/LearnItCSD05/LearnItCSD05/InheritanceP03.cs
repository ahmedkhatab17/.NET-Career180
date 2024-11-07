using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD05
{
    public class Geoshape
    {
        private double dim1;
        private double dim2;

        protected double Dim1
        {
            get{return dim1;}
            set{dim1 = value;}
        }
        protected double Dim2
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
    }
    //
    public class Rect:Geoshape
    {
        //inherits dim1,dim2 Dim1 Dim2
        //data fields??? NO
        ///Rect r1=new Rect();
        public Rect() 
        {
            Console.WriteLine("Rect def ctor");
        }
        public Rect(double _d1,double _d2):base(_d1,_d2)
        {
            //useless after ctor chaining
            Dim1 = _d1;
            Dim2 = _d2;
            Console.WriteLine("rect 2p ctor");
        }
        public double CArea()
        {
            return Dim1 * Dim2;
        }
    }
    //
    public class Square:Geoshape
    {
        public Square()
        {
            Console.WriteLine("Sq def ctor");
        }
        public Square(double _dim):base(_dim,_dim)
        {
            Dim2=Dim1 = _dim;
        }
        public double CArea() 
        {
            return Dim1 * Dim2;
        }
        ////
        //public double Dim1
        //{
        //    get { return dim1; }
        //    set { dim1=dim2 = value; }
        //}
        //public double Dim2
        //{
        //    get { return dim2; }
        //    set { dim2 =dim1= value; }
        //}
        ////
    }
    //
    public class SquareV2:Rect
    {
        public SquareV2()
        {
            
        }
        public SquareV2(double _dim):base (_dim,_dim)
        {
            
        }
    }
    //
    public class Tri:Geoshape
    {
        public Tri()
        {
            
        }
        public Tri(double _base,double _height):base(_height,_base)
        {
            
        }
        public double CArea()
        {
            return 0.5 * Dim1 * Dim2;
            return  Dim1 * Dim2 *(1/2);
        }
    }
    public sealed class Circle:Geoshape
    {
        public Circle()
        {
            
        }
        public Circle(double _radius):base(_radius,_radius)
        {
            
        }
        public double CArea()
        {
            return Math.PI * Dim1 * Dim2;
            return 3.14 * Dim1 * Dim2;
            // WRONG return 22/7 * dim1 * dim2;
        }
    }

    //
    //public class Abc : Circle
    //{

    //}

}


//ImmutableDT