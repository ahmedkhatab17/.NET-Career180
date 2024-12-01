using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay2.Models
{
    public class Workfor
    {
        [ForeignKey("employee")]
        //[Key]
        //[Column(Order =1)]
        public int emp_id { get; set; }
        [ForeignKey("project")]
        //[Key]
        //[Column(Order = 2)]

        public int proj_id { get; set; }
        public int workingdays { get; set; }

        public virtual Employee employee { get; set; }
        public virtual Project project { get; set; }
    }
}
