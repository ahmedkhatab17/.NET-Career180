using Lab4.Models;
using Lab4.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController(CompanyContext db)
        {
            Db = db;
        }

        public CompanyContext Db { get; }

        [HttpPost("add")]
        public IActionResult AddEmployee([FromForm] EmployeeDTO edto, IFormFile photo)
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
                Db.Employees.Add(e);
                Db.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

       

        [HttpGet("all")]
        public IActionResult GetAllEmployees()
        {
            var employees = Db.Employees.ToList();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            return Ok(Db.Employees.FirstOrDefault(e => e.Id == id));
        }
    }
}
