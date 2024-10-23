using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD04
{
    //Composition
    public class Rectangle
    {
        Point ul;
        Point lr;

        public Point Ul
        {
            get
            {
                return ul;
            }

            set
            {
                ul = value;
            }
        }

        public Point Lr
        {
            get
            {
                return lr;
            }

            set
            {
                lr = value;
            }
        }

        public Rectangle()
        {
            ul=new Point();
            lr=new Point(); 
            //useless
            //ul.X = 0; ....
            Console.WriteLine("Rect def ctor");
        }

        public Rectangle(int x1,int y1,int x2,int y2)
        {
            ul= new Point(x1,y1);
            lr=new Point(x2,y2);
            Console.WriteLine("Rect 4p ctor");
        }
        public string PrintRect()
        {
            return $"Line start {ul.PrintPoint()} , End {lr.PrintPoint()}";
        }
    }
}
