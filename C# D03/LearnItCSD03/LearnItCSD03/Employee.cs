using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD03
{
    public class Employee
    {
        int id;
        string name;
        int age;
        decimal salary;

        //
        //
        public Employee()
        {
            id = 1;
            name = "Ali";
            age = 22;
            salary = 1234;
        }
        public Employee(int _id,string _name,int _age,decimal _salary)
        {
            id = _id;
            name = _name;
            age = _age;
            salary = _salary;
        }

        public string Print()
        {
            return $"{id}:{name}:{age}:{salary}";
        }
    }
}
