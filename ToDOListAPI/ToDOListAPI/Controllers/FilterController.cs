using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToDOListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilterController : ControllerBase
    {
        TaskRepository tr;
        IMapper mapper;
        public FilterController(TaskRepository tr, IMapper mapper)
        {
            this.tr = tr;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult FilterTasks([FromQuery] string completed, [FromQuery] string due_date, [FromQuery] string priority)
        {
            var tasks = tr.GetAllTasks();
            if (!string.IsNullOrEmpty(completed))
            {
                bool isCompleted = completed.ToLower() == "true";
                tasks = (List<Models.Task>)tasks.Where(t => t.Status == (isCompleted ? "completed" : "incomplete"));
            }

            if (!string.IsNullOrEmpty(due_date) && DateTime.TryParse(due_date, out var parsedDate))
            {
                tasks = (List<Models.Task>)tasks.Where(t => t.DueDate == parsedDate);
            }

            if (!string.IsNullOrEmpty(priority))
            {
                tasks = (List<Models.Task>)tasks.Where(t => t.Priority.ToLower() == priority.ToLower());
            }

            var taskDTOs = mapper.Map<List<DTOs.TaskDTO>>(tasks);
            return Ok(taskDTOs);
        }


    }
}
