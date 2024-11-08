using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay8_9
{
     public static class Repository
    {
        public static List<Employee> Employees { get; set; }
        = new List<Employee>()
        {
            new Employee{Id=1, Name="ahmed",Age=20,Salary=10000,DeptId=10},
            new Employee{Id=2, Name="omar", Age=30,Salary=9000, DeptId=20},
            new Employee{Id=3, Name="alaa", Age=29,Salary=8000, DeptId=20},
            new Employee{Id=4, Name="arwa", Age=28,Salary=7000, DeptId=30},
            new Employee{Id=5, Name="sara", Age=27,Salary=6234, DeptId=30},
            new Employee{Id=6, Name="mona", Age=26,Salary=11000,DeptId=20},
            new Employee{Id=7, Name="emad", Age=25,Salary=5000, DeptId=20},
            new Employee{Id=8, Name="eman", Age=24,Salary=5500, DeptId=10},
            new Employee{Id=9, Name="israa",Age=23,Salary=7700, DeptId=10},
            new Employee{Id=10,Name="ali",  Age=22,Salary=9009, DeptId=10}
        };
    }
}
