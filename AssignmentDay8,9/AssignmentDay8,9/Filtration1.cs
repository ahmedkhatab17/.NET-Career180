using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay8_9
{
    public static class Filtration1 //without delegates
    {
        public static List<Employee> FilterByDeptId(List<Employee> param, int deptId)
        {
            return param.Where(emp => emp.DeptId == deptId).ToList();
        }

        public static List<Employee> FilterBySalary(List<Employee> param, decimal minSalary)
        {
            return param.Where(emp => emp.Salary >= minSalary).ToList();
        }

        public static List<Employee> FilterByAge(List<Employee> param, int minAge)
        {
            return param.Where(emp => emp.Age >= minAge).ToList();
        }
    }
}
