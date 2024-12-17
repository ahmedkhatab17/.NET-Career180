using Lab4.Models;
using Lab4.DTOs;
using Lab4.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public GenericRepository<Employee> repob { get; }

        public EmployeeController(GenericRepository<Employee> repo)
        {
            this.repob = repo;
        }
 
        [HttpPost("add")]
        public IActionResult AddEmployee(AddEmployeeDTO edto, IFormFile photo)
        {
            if (ModelState.IsValid)
            {
                string path = $"{Directory.GetCurrentDirectory()}\\Uploads\\{photo.FileName}";
                FileStream st = new FileStream(path, FileMode.Create);
                photo.CopyTo(st);

                Employee e = new Employee()
                {
                    Name = edto.Name,
                    Username = edto.Username,
                    Salary = edto.Salary,
                    Email = edto.Email,
                    Password = edto.Password,
                    Photo = path
                };
                repob.Add(e);
                repob.Save();
                return Ok(e);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        

        [HttpGet("all")]
        public IActionResult GetAllEmployees()
        {
            return Ok(repob.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = repob.GetById(id);
            return Ok(employee);
        }
    }
}
