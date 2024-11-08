using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay8_9
{
    public static class Filtration2 //with delegates
    {
        public static List<Employee> FilterPerDelegate(List<Employee> param, MyDelegate del1) 
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
        public static List<Employee> FilterWithPredicate(List<Employee> param, Predicate<Employee> predicate)
        {
            return param.FindAll(predicate);
        }

        public static List<Employee> FilterWithFunc(List<Employee> param, Func<Employee, bool> func)
        {
            return param.Where(func).ToList();
        }

        public static void PrintEmployees(List<Employee> employees, Action<Employee> printAction)
        {
            foreach (var emp in employees)
            {
                printAction(emp);
            }
        }

        public static bool PerDeptId(Employee item)
        {
            return item.DeptId == 20;
        }
    }
}
