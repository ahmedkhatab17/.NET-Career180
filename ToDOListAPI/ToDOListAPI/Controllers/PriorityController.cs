using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToDOListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriorityController : ControllerBase
    {
        TaskRepository tr;
        public PriorityController(TaskRepository tr)
        {
            this.tr = tr;
        }
        [HttpPut("{id}/priority")]
        public IActionResult UpdatePriority(string id, [FromBody] string priority)
        {
            var task = tr.GetTaskById(id);
            if (task == null) return NotFound();

            if (!new[] { "low", "medium", "high" }.Contains(priority.ToLower()))
            {
                return BadRequest("Invalid priority value.");
            }

            task.Priority = priority;
            tr.Update(task);

            return NoContent();
        }
    }
}
