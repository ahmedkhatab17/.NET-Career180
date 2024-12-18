using AutoMapper;
using Day6.Models;
using Day6.Repository;
using Day6.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Day6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class empDeptController : ControllerBase
    {

        UnitOfWork _unit;
        IMapper Mapper;
        public empDeptController(UnitOfWork _unit, IMapper mapper)
        {
            this._unit = _unit;
            this.Mapper = mapper;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get all employees and departments", Description = "Fetch both employee and department records")]
        [SwaggerResponse(200, "List of employees and departments")]
        [SwaggerResponse(500, "Internal server error")]
        public IActionResult GetAll ()
        {
            List<Employee> emps = _unit.empreps.selectall();
            List<Department> depts= _unit.deptrep.selectall();
            var ob = new { employees = emps, department = depts };
            return Ok(ob);
        }
       

        [HttpPost]
        [SwaggerOperation(Summary = "Add an employee with a department", Description = "Create a new employee and assign to a department")]
        [SwaggerResponse(200, "Employee and department successfully created")]
        [SwaggerResponse(400, "Invalid input provided")]
        [SwaggerResponse(500, "Internal server error")]
        public IActionResult Add(Employee emp)
        {
            _unit.deptrep.add(emp.dept);
            _unit.empreps.add(emp);
            _unit.save();
            return Ok();
        }
    }
}
