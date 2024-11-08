using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay7
{
    public enum Gender
    {
        Male = 0,
        Female = 1,
    }
    [Flags]
    public enum State
    {
        Guest = 1,       // 0001
        Developer = 2,   // 0010
        Secretary = 4,   // 0100
        DBA = 8,         // 1000
        FullAccess = 15  // 1111 
    }
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(int _id, string _name, Gender _gen, decimal _salary, HiringDate _hd, State state)
        {
            Id = _id;
            Name = _name;
            Gen = _gen;
            Salary = _salary;
            HD = _hd;
            State = state;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gen { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HD { get; set; }
        public State State { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Gender: {Gen}, Salary: {Salary}, Hire Date: {HD}, State: {State}";
        }

    }
}
