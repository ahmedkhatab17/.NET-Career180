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
        private UnitOfWork _unit;

        public EmployeeController(UnitOfWork unit)
        {
            this._unit = unit;
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
                _unit.empreps.Add(e);
                _unit.Save();
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
            return Ok(_unit.empreps.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _unit.empreps.GetById(id);
            return Ok(employee);
        }
    }
}
