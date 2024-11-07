using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD09
{
    //syntax
    //public delegate   retType   DelegateName (inputParams);
    public delegate bool MyDelegate(Employee abc);

    public delegate int MathDelegate(int left, int right);

    public delegate void PrintDelegate<T>(T e1);

    public delegate U MathDelegate2<in T,out U>(T left, T right);

}
