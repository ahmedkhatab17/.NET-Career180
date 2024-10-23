using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD04
{
    public class Utility
    {
        public static void MultiplyArrayByTenV(int[] param) 
        {
            
            Console.WriteLine($"param identity= {param.GetHashCode()}");
            for (int i = 0; i < param.Length; i++)
            {
                param[i] *= 10;
            }
            param = new int[10];
            Console.WriteLine($"param identity= {param.GetHashCode()}");

        }

        public static void MultiplyArrayByTenR(ref int[] param)
        {
            Console.WriteLine($"param identity= {param.GetHashCode()}");
            for (int i = 0; i < param.Length; i++)
            {
                param[i] *= 10;
            }
            param = new int[10];
            Console.WriteLine($"param identity= {param.GetHashCode()}");
        }
    }
}
