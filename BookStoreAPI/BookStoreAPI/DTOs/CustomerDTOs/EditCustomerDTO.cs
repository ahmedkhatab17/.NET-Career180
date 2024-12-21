using System.ComponentModel.DataAnnotations;

namespace BookStoreAPI.DTOs.CustomerDTOs
{
    public class EditCustomerDTO
    {
        [Required]
        public string Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }


    }
}
