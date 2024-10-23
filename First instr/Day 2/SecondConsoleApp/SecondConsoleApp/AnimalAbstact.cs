using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    public abstract class AnimalAbstact
    {
        // Abstract method (no implementation here)
        public abstract void MakeSound();

        // Non-abstract method (with implementation)
        public void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }

    }
}
