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
        public DepartmentController(UnitOfWork _unit)
        {
            this._unit = _unit;   
        }
        [HttpGet]
        [SwaggerOperation(Summary ="return all department" ,Description ="return all department in companu hdhdhdhhd")]
        [SwaggerResponse(200,"all department data" ,typeof(List<DisplayDepartmentDto>))]
        public IActionResult getall()
        {
            List<Department> depts = _unit.deptrep.selectall();
            List<DisplayDepartmentDto> deptsDTO = new List<DisplayDepartmentDto>();
            foreach (var item in depts)
            {
                DisplayDepartmentDto dDTO = new DisplayDepartmentDto()
                {
                    name = item.name,
                    id = item.id,
                    employeecount = item.Employees.Count()
                };
                deptsDTO.Add(dDTO);
                
            }
            return Ok(deptsDTO);
        }
        [HttpPost]
        public IActionResult add(AddDepartmentDTo deptDTO)
        {
            if (ModelState.IsValid)
            {
                Department d = new Department()
                {
                    name = deptDTO.name,
                    desc = deptDTO.desc,
                };
                _unit.deptrep.add(d);
                _unit.save();
                return Ok(d);
            }
            else return BadRequest(ModelState);
        }

    }
}
