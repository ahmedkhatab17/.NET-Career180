using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    //Base class
    public class Vehicle
    {
        public string Make { get; }
        public string Model { get; set; }

        protected int Value;

        public int MyProperty { get; private set; }

        public Vehicle(string make)
        {
           Make = make;
        }
        public void Drive()
        {
            Console.WriteLine("The vehicle is driving...");
        }

    }
}
