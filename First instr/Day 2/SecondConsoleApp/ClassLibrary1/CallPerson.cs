using SecondConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CallPerson
    {
        public readonly IPerson _person;
        public CallPerson(IPerson persone)
        {
            _person = persone;
        }


        public void CreatePerson()
        {
            _person.Create();
           
        }
    }
}
