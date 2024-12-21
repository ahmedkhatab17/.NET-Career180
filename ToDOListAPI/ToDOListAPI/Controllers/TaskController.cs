using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDOListAPI.DTOs;

namespace ToDOListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        TaskRepository tr;
        IMapper mapper;
        public TaskController(TaskRepository tr, IMapper mapper)
        {
            this.tr = tr;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var tasks = tr.GetAllTasks();
            var dto= mapper.Map<List<TaskDTO>>(tasks);
            return Ok(dto);
        }

        [HttpPost]
        public IActionResult CreateTask([FromBody] TaskDTO taskDTO)
        {
            if (ModelState.IsValid)
            {
                var task = mapper.Map<Models.Task>(taskDTO);
                //task.Id = Guid.NewGuid().ToString();
                //task.CreationDate = DateOnly.FromDateTime(DateTime.Now);
                tr.Add(task);
                return CreatedAtAction(nameof(GetTask), new { id = task.Id }, mapper.Map<DTOs.TaskDTO>(task));
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult GetTask(string id)
        {
            var task = tr.GetTaskById(id);
            if (task == null)
                return NotFound();
            var taskDto = mapper.Map<TaskDTO>(task);
            return Ok(taskDto);
        }

        [HttpPut("{id}")]
        public IActionResult EditTask(string id, [FromBody] TaskDTO taskDto)
        {
            var existingTask = tr.GetTaskById(id);
            if (existingTask == null)
            {
                return NotFound();
            }

            mapper.Map(taskDto, existingTask);
            tr.Update(existingTask);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(string id)
        {
            var task = tr.GetTaskById(id);
            if (task == null)
            {
                return NotFound();
            }

            tr.Delete(id);
            return NoContent();
        }

    }
}
