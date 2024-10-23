using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    public class Dog: Animal, IAnimal
    {
        public void Drink()
        {
            throw new NotImplementedException();
        }

        public void MakeSound()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public override void Speak()
        {
            Console.WriteLine("The dog makes a barks.");
        }
    }
}
