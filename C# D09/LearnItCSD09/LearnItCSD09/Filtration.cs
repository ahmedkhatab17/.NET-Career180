using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD09
{
    public static class Filtration
    {
        public static List<Employee> FilterPerDeptId(List<Employee> param)  //deptid 10
        {
            List<Employee> result = new List<Employee>();
            foreach (Employee emp in param) 
            {
                if (emp.DeptId==10) 
                {
                    result.Add(emp);
                }
            }
            return result;
        }

        public static List<Employee> FilterPerSalary(List<Employee> param)  //salary>5000
        {
            List<Employee> result = new List<Employee>();
            foreach (Employee emp in param)
            {
                if (emp.Salary >= 5000)
                {
                    result.Add(emp);
                }
            }
            return result;
        }

        public static List<Employee> FilterPerAge(List<Employee> param)  //age>25
        {
            List<Employee> result = new List<Employee>();
            foreach (Employee emp in param)
            {
                if (emp.Age >= 25)
                {
                    result.Add(emp);
                }
            }
            return result;
        }

        public static List<Employee> FilterPerAny(List<Employee> param)  //age>25
        {
            List<Employee> result = new List<Employee>();
            foreach (Employee emp in param)
            {
                //if (FilterPer.PerDeptId(emp))
                if (FilterPer.PerName(emp))
                {
                    result.Add(emp);
                }
            }
            return result;
        }

        //succeed in open close principle
        public static List<Employee> FilterPerDelegate(List<Employee> param,MyDelegate del1)  //age>25
        {
            List<Employee> result = new List<Employee>();
            foreach (Employee emp in param)
            {
                if (del1(emp))
                {
                    result.Add(emp);
                }
            }
            return result;
        }
    }
}
