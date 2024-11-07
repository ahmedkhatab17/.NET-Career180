using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD07
{
    public class Department:ICloneable
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string Description { get; set; }

        public Department()
        {
            DeptId = 10;
            DeptName = ".NET";
            Description = "FullStack .NET";
        }
        public Department(int _deptId,string _deptName,string _Desc)
        {
            DeptId = _deptId;
            DeptName = _deptName;
            Description = _Desc;
        }
        public override string ToString() 
        {
            return $"{DeptName} Department";
        }

        public object Clone()
        {
            return new Department { DeptId=this.DeptId,DeptName=this.DeptName, Description=this.Description};
        }
    }
}
