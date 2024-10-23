using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    public class Car : Vehicle
    {
        public Car(string make) : base(make)
        {
        }
        public int Year { get; set; }

        // return type void
        // name of method StartEngine
        public int StartEngine(int a)
        {
            var role = Helper.RoleAdmin;
            var result = 1;

            Vehicle vehicle = new Vehicle("1");

            Console.WriteLine(vehicle);  // Can read, but can't set


            return result;

        }


    }
}
