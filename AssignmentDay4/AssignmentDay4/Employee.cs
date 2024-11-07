using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay4
{
    public class Employee
    {
        #region auto prop
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public Employee() { 
            Id = 0;
            Name = "Ahmed";
            Age =20; 
            Salary = 9000;
        
        }
        public string PrintEmp() { return $"{Id} - {Name} - {Age} - {Salary} "; }
        #endregion
    }
}
