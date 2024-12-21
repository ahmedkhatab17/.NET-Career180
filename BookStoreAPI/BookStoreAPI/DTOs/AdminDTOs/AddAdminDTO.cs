using System.ComponentModel.DataAnnotations;

namespace BookStoreAPI.DTOs.AdminDTOs
{
    public class AddAdminDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
