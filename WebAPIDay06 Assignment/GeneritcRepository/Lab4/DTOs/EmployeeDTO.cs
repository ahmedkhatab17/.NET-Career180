using System.ComponentModel.DataAnnotations;

namespace Lab4.DTOs
{
    public class EmployeeDTO
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Username must be at least 10 characters")]
        public string Username { get; set; }

        [Range(1200, 20000, ErrorMessage = "Salary must be between 1200 and 20000")]
        public decimal Salary { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        public IFormFile Photo { get; set; }
    }
}
