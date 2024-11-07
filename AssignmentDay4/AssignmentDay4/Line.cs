using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay4
{
    //composition
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
            
            Console.WriteLine("Line def ctor");
        }
        public Line(int x1,int y1,int x2,int y2 )
        {
            start.X = x1; start.Y = y1;           
            end.X = x2; end.Y = y2;
            Console.WriteLine("point 4p ctor");
        }
        public string PrintLine()
        {
            return $"Line start {start.PrintPoint()}, End {end.PrintPoint()}";
        }
    }
}
