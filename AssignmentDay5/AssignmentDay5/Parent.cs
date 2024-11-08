using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5
{
    class Parent
    {
        int x, y;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public Parent()
        {
            x = 0; y = 0;
            Console.WriteLine("Parent 2p ctor");
        }
        public Parent(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
            Console.WriteLine("Parent 2p ctor");
        }
        public int Sum()
        {
            return x + y;
        }
    }

    class Child : Parent
    {
        int z;
        public int Z
        {
            get
            {
                return z;
            }

            set
            {
                z = value;
            }
        }
        public Child()
        {
            z = 0;
            //X = 0;
            //Y = 0;
            Console.WriteLine("child def ctor");
        }
        public Child(int _x, int _y,int _z):base(_x,_y)
        {
            Z = _z;
            Console.WriteLine("child 3p ctor");
        } 
        public int Sum()
        {
            return X+Y+z  ;
        }

    }

}
