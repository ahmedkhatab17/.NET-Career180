using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD09
{
    class Trial1
    {
        public static void Swap<T>(ref T left,ref T right)
        {
            T tmp;
            tmp = left;
            left = right;
            right = tmp;
        }  
    }

    class Trial2<T>
    {
        public static void Swap(ref T left, ref T right)
        {
            T tmp;
            tmp = left;
            left = right;
            right = tmp;
        }
    }
}
