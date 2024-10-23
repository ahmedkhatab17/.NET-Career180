using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD03
{
    public class Utility
    {
        public static void SwapV(int left, int right) 
        {
            int tmp;
            tmp = left;
            tmp = right;
            right = tmp;
        }
        public static void SwapR(ref int left,ref int right)
        {
            int tmp;
            tmp = left;
            left = right;
            right = tmp;
        }
        public static void MultiplyArrayByTen(int[] param) 
        {
            for (int i = 0; i < param.Length; i++) 
            {
                param[i] *= 10;
            }
            param[0] = 10000;
        }

        public static void Add(int left,int right,out int result)
        {
            result =left+right;
        }

        public static void AddSub(int left, int right, out int resultA,out int resultS)
        {
            resultA = left + right;
            resultS = left - right;
        }
    }
}
