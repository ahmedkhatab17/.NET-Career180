using System.ComponentModel.DataAnnotations;

namespace ToDOListAPI.DTOs
{
    public class UpdateTaskDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        [RegularExpression("low|medium|high", ErrorMessage = "Priority must be 'low', 'medium', or 'high'.")]
        public string Priority { get; set; }
        [RegularExpression("created|incomplete|completed", ErrorMessage = "Status must be 'created', 'incomplete', or 'completed'.")]
        public string Status { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
