using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD03
{
    class Draft
    {
        public const double Pi = 3.14;
        //ابعدوا عن المشتبهات
        //ambiguty
        public int Add(int x = 0, int y = 0, int z = 0)
        {
            return x + y + z;
        }
        ////////////////////////////////////////////////////

        public int Add(int x)
        {
            return x;
        }
        ////////////////////////////////////////////////////////////////
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            return x - y;
        }
        public static int Mul(int x, int y)
        {
            return x * y;
        }
        public static int Div(int x, int y)
        {
            return x / y;
        }
    }
}
