using System.ComponentModel.DataAnnotations;

namespace BookStoreAPI.DTOs.CustomerDTOs
{
    public class AddCustomerDTO
    {
        public string Name { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

    }
}
