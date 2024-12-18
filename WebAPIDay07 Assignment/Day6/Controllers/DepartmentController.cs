using AutoMapper;
using Day6.DTOs.DepartmentDto;
using Day6.DTOs.EmployeeDTO;
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
    public class DepartmentController : ControllerBase
    {
        UnitOfWorks.UnitOfWork _unit;
        IMapper Mapper;
        public DepartmentController(UnitOfWork _unit, IMapper mapper)
        {
            this._unit = _unit;
            this.Mapper = mapper;
        }

        [HttpGet]
        [SwaggerOperation(Summary ="Return All Department")]
        [SwaggerResponse(200,"All Deparment Data",typeof(List<DisplayDepartmentDto>))]
        [SwaggerResponse(500, "Internal server error")]
        public IActionResult GetAll()
        {
            List<Department> depts = _unit.deptrep.selectall();
            List<DisplayDepartmentDto> deptsDTO = Mapper.Map<List<DisplayDepartmentDto>>(depts);
            return Ok(deptsDTO);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Add a new department", Description = "Create a new department record")]
        [SwaggerResponse(200, "Department successfully created", typeof(Department))]
        [SwaggerResponse(400, "Invalid input provided")]
        [SwaggerResponse(500, "Internal server error")]
        public IActionResult Add(AddDepartmentDTo deptDTO)
        {
            if (ModelState.IsValid)
            {
                Department d = Mapper.Map<Department>(deptDTO);
                _unit.deptrep.add(d);
                _unit.save();
                return Ok(d);
            }
            else return BadRequest(ModelState);
        }

    }
}
