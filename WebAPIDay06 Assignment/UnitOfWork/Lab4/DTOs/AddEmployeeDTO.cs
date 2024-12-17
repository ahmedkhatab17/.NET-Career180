using System.ComponentModel.DataAnnotations;

namespace Lab4.DTOs
{
    public class AddEmployeeDTO
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int Salary {  get; set; }

        public IFormFile Photo { get; set; }
    }
}
