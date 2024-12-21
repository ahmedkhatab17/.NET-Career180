using System.ComponentModel.DataAnnotations;

namespace ToDOListAPI.Models
{
    public class Task
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        [RegularExpression("low|medium|high", ErrorMessage = "Priority must be 'low', 'medium', or 'high'.")]
        public string Priority { get; set; } = "medium";

        [Required]
        [RegularExpression("created|incomplete|completed", ErrorMessage = "Status must be 'created', 'incomplete', or 'completed'.")]
        public string Status { get; set; } = "created"; 

        [Required]
        public DateTime CreationDate { get; set; } 

        [Required]
        public DateTime DueDate { get; set; }

    }
}
