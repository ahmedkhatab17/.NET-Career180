using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD09
{
    public static class FilterPer
    {
        public static bool PerDeptId(Employee item)
        {
            return item.DeptId == 20;
        }

        public static bool PerName(Employee item) 
        {
            return item.Name.ToLower().Contains("m");
        }

        //infinity
    }
}
