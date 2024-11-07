using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD05
{
    //class Parent
    //{
    //    int x;
    //    int y;
          ////public static int counter=0;
    //    public int X
    //    {
    //        set { x = value; }
    //        get { return x; }
    //    }

    //    public int Y
    //    {
    //        get
    //        {
    //            return y;
    //        }
    //        set
    //        {
    //            y = value;
    //        }
    //    }

    //    //c2 call def ctor to initialize inherited members
    //    public Parent()
    //    {
    //        x = y = 0;
    //        Console.WriteLine("Parent def ctor");
    //    }
    //    //c2 call def ctor to initialize inherited members
    //    public Parent(int _x, int _y)
    //    {
    //        x = _x;
    //        this.y = _y;
    //        Console.WriteLine("Parent 2p ctor");
    //    }

    //    public int SumXY()
    //    {
    //        return x + y;
    //    }
    //}
    ///////////////////////////////////////////////////////////////////
    /////private:member can be accessed inside class scope ONLYYYYYYYY
    /////child DT inherts EVERTHING from Parent .....MAYBE except search ctor  , static
    //class Child : Parent
    //{
    //    ///x y X Y SumXY
    //    int z;

    //    public int Z
    //    {
    //        get
    //        {
    //            return z;
    //        }

    //        set
    //        {
    //            z = value;
    //        }
    //    }

    //    public Child()
    //    {
    //        ///c1 x|0| y|0| z||
    //        z = 0;
    //        ///c1 x|0| y|0| z|0|
    //        //x=0;y=0;  //Compile Error Inaccessible
    //        ////useless code
    //        //this.X = 0;
    //        //Y = 0;
    //        Console.WriteLine("Child def ctor");
    //    }

    //    //public Child(int _x,int _y,int _z)
    //    //{
    //    //    ///c2 x|0| y|0| z||
    //    //    z = _z;
    //    //    ///c2 x|0| y|0| z|3|
    //    //    //x=_x;y=_y; //Compile Error //inaccessible
    //    //    X = _x;
    //    //    Y = _y;
    //    //    ///c2 x|1| y|2| z|3|
    //    //    Console.WriteLine("child 3p ctor");
    //    //}

    //    //ctor chaining 1-increase performance 2-reduce written code 
    //    public Child(int _x, int _y, int _z) : base(_x, _y)
    //    {
    //        ///c2 x|1| y|2| z||
    //        z = _z;
    //        ///c2 x|1| y|2| z|3|
    //        Console.WriteLine("child 3p ctor");
    //    }

    //    public int SumXYZ() 
    //    {
    //        return z + SumXY();
    //        //return z + X + Y;
    //        //return z + x + y;
    //    }
    //}

}