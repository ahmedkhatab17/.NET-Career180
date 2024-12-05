using System.ComponentModel.DataAnnotations;

namespace Day6api.DTOs
{
    public class studentLoginDTO
    {
        [Required]
        public string username { get; set; }
        [Required]

        public string password { get; set; }
    }
}
