using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay6
{
    public class Math
    {
        public static int Add(int a, int b) { return a + b; }
        public static int Subtract(int a, int b) {return a - b; }
        public static int Multiply(int a, int b) {return (a * b); }
        public static double Divide(double a, double b)
        {
            if (b != 0) return a / b;
            else
                Console.WriteLine("Cannot divide by zero");
            return -1222222.3;
        }
    }
}
