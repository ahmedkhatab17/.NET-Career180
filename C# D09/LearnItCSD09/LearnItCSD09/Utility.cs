using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD09
{
    public class Utility
    {
        public static bool PerDept(Employee item)
        {
            return item.DeptId == 10;
        }
        public static void PrintEmployee(Employee item) 
        {
            Console.WriteLine(item);
        }
        public static int Add(int x,int y)
        {
            return x + y;
        }
        public static bool isEven(int x)
        {
            return x % 2 == 0;
        }

    }
}
