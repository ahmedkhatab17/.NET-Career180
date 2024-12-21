using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToDOListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        TaskRepository tr;

        public StatusController(TaskRepository tr)
        {
            this.tr = tr;
        }

        [HttpPut("{id}/complete")]
        public IActionResult MarkAsCompleted(string id)
        {
            var task = tr.GetTaskById(id);
            if (task == null)
                return NotFound();

            task.Status = "completed";
            tr.Update(task);
            return NoContent();  
        }

        [HttpPut("{id}/incomplete")]
        public IActionResult MarkAsIncomplete(string id)
        {
            var task = tr.GetTaskById(id);
            if (task == null)
                return NotFound();

            task.Status = "incomplete";
            tr.Update(task);
            return NoContent();
        }
    }
}
