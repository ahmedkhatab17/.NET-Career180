using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD07
{
    public class Employee:IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public Gender Gen { get; set; }
        public Department Dept { get; set; }

        HireDate hd;
        public HireDate HD
        {
            set { hd = value; }
            get { return hd; }
        }
        //tightly coupled -> loosely coupled
        public Employee()
        {
            Id = 1;
            Name = "Sara";
            Age = 22;
            Salary = 1234;
            Gen = Gender.Female;
            hd = default;
            Dept= default;
            //hd=new HireDate { Day=4,Month=4,Year=2004};
            //Dept = new Department(20,"O.S","Open Source");
        }

        //loosely coupled
        public Employee(int _id,string _name,int _age,decimal _salary,Gender _gen,Department _dept,HireDate _hd)
        {
            Id = _id;
            Name = _name;
            Age = _age;
            Salary = _salary;
            Gen = _gen;
            Dept = _dept;
            hd = _hd;
        }

        public override string ToString()
        {
            return $"{Id}:{Name}:{Age}:{Salary}:{Gen}:{hd?.ToString()}:{Dept}";
        }

        public int CompareTo(object obj)
        {
            Employee right = (Employee)obj;
            return this.hd.CompareTo(right.hd);
            //return this.Name.CompareTo(right.Name);
            //return this.Age.CompareTo(right.Age);
        }
    }
}
