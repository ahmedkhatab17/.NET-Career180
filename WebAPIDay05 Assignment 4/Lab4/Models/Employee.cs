using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab4.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime HireDate { get; set; }
        [Range(1200, 20000)]
        public decimal Salary { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(10)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        [NotMapped]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public string Photo { get; set; }
    }
}
