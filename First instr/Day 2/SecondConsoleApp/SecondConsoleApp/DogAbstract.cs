using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    public class DogAbstract : AnimalAbstact
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dog makes a barks.");
        }


    }
}
