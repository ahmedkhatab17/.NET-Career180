using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay2.Models
{
    public class Department
    {
        //public Department()
        //{
        //    employees = new List<Employee>();
        //}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//disable ideninty 
        public int deptid { get; set; }
        public string deptname { get; set; }
        public string desc { get; set; }
        //public char location { get; set; }

        public virtual List<Employee> employees { get; set; } = new List<Employee>();


        public override string ToString()
        {
            return $"{deptid}-{deptname}-{desc}";
        }
    }
}
