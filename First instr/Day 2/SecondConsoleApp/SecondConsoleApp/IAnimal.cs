using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    public interface IAnimal
    {
        void MakeSound();  // Interface method (no implementation)
        void Eat();        // Interface method (no implementation)
        void Drink();
        void Sleep();
    }
}
