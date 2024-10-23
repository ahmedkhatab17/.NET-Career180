using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    public class GenericClass<T>
    {
        public T GenericMethod(T input)
        {
            return input;
        }
    }
}
