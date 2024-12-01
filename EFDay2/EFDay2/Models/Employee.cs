using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay2.Models
{
    //[Table("instructor")]
    public class Employee
    {
        //[Key]
        public int id { get; set; }
        [StringLength(50)]
        public string? fullname { get; set; }
        [Required]
        public string? username { get; set; }
        [Required]
        public string? password { get; set; }
        [NotMapped]
        public string? confirm_password { get; set; }
        [Column(TypeName ="date")]
        public DateTime hiredate { get; set; }
        [Column("netsalary" ,TypeName ="money")]
        public decimal salary { get; set; }
        [ForeignKey("department")]
        public int dept_id { get; set; }
        public virtual Department department { get; set; }

        public virtual List<Workfor> Projects { get; set; } = new List<Workfor>();

    }
}
