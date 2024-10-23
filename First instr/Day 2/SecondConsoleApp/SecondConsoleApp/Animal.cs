using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    public class Animal
    {
        // Base class method marked as virtual
        public virtual void Speak()
        {
            ////////
            ///////
            ///
            Console.WriteLine("The animal makes a sound.");
        } 
        
        public void Eat()
        {
            ////////
            ///////
            ///
            Console.WriteLine("The animal eat.");
        }

    }
}
