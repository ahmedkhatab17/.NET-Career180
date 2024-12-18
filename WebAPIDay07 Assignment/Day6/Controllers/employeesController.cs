using AutoMapper;
using Day6.DTOs.EmployeeDTO;
using Day6.Models;
using Day6.Repository;
using Day6.Repository.OldClass;
using Day6.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;

namespace Day6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employeesController : ControllerBase
    {
        UnitOfWork _unit;
        IMapper Mapper;
        public employeesController(UnitOfWork _unit, IMapper mapper)
        {
            this._unit =_unit;
            this.Mapper =mapper;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Retrieve all employees", Description = "Fetch all employee records")]
        [SwaggerResponse(200, "List of all employees", typeof(List<DisplayemployeeDTO>))]
        [SwaggerResponse(500, "Internal server error")]
        public IActionResult GetAll()
        {
            List<Employee> emps = _unit.empreps.selectall();
            List<DisplayemployeeDTO> employees = Mapper.Map<List<DisplayemployeeDTO>>(emps);
            return Ok(employees);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get employee by ID", Description = "Retrieve a specific employee by their ID")]
        [SwaggerResponse(200, "Employee data", typeof(DisplayemployeeDTO))]
        [SwaggerResponse(404, "Employee not found")]
        [SwaggerResponse(500, "Internal server error")]
        public IActionResult GetById(int id)
        {
            Employee emp = _unit.empreps.selectbyid(id);
            if (emp == null) return NotFound();

            else
            {
                DisplayemployeeDTO EmpDTO = Mapper.Map<DisplayemployeeDTO>(emp);
                return Ok(EmpDTO);
            }
                
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Add a new employee", Description = "Create a new employee record")]
        [SwaggerResponse(200, "Employee successfully created", typeof(Employee))]
        [SwaggerResponse(400, "Invalid input")]
        [SwaggerResponse(500, "Internal server error")]
        public IActionResult Add(addemployeeDTO empDTO)
        {
            if (ModelState.IsValid)
            {
                Employee em =Mapper.Map<Employee>(empDTO);
                _unit.empreps.add(em);
                _unit.save();
                return Ok(em);

            }
            else
                return BadRequest(ModelState);
        }
    }
}
