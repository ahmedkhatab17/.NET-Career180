using System.ComponentModel.DataAnnotations;

namespace BookStoreAPI.DTOs.CustomerDTOs
{
    public class ChangePasswordDTO
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string OldPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
        [Required]
        [Compare("NewPassword", ErrorMessage ="Password Not Matched")]
        public string ConfirmPassword { get; set; }
    }
}
