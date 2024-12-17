using System.ComponentModel.DataAnnotations.Schema;

namespace Day6.DTOs.EmployeeDTO
{
    public class DisplayemployeeDTO
    {
        public string name { get; set; }

        public int age { get; set; }

        public DateOnly hiredate { get; set; }

        public decimal salary { get; set; }

        public string departmentName { get; set; }
    }
}
