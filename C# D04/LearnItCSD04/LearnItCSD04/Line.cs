using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD04
{
    //Composition
    public class Line
    {
        Point start = new Point();
        Point end = new Point();

        public Point Start
        {
            get
            {
                return start;
            }

            set
            {
                start = value;
            }
        }

        public Point End
        {
            get
            {
                return end;
            }

            set
            {
                end = value;
            }
        }

        public Line() 
        {
            ///L1 start x0 y0   end x0 y0
            //start.x=0;start.y=0; //compile error
            //useless
            start.X = 0;start.Y = 0;
            end.X = 0;end.Y = 0;
            //
            Console.WriteLine("Line def ctor");
        }
        public Line(int x1,int y1,int x2,int y2)
        {
            ///L2 start x1 y2   end x3 y4
            start.X=x1;start.Y=y1;
            end.X=x2;end.Y=y2;
            Console.WriteLine("Line 4p ctor");
        }

        public string PrintLine() 
        {
            return $"Line start {start.PrintPoint()} , End {end.PrintPoint()}";
        }
    }
}
