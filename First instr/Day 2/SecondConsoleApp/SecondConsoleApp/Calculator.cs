﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    public class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(double a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(int a, double b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }

    }
}
