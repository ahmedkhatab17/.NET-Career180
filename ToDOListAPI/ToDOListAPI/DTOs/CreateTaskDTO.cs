using System.ComponentModel.DataAnnotations;

namespace ToDOListAPI.DTOs
{
    public class CreateTaskDTO
    {
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        [RegularExpression("low|medium|high", ErrorMessage = "Priority must be 'low', 'medium', or 'high'.")]
        public string Priority { get; set; } = "medium";

        [Required]
        public DateTime DueDate { get; set; }
    }
}
