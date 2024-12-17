using Day6.DTOs.DepartmentDto;
using Day6.DTOs.EmployeeDTO;
using Day6.Models;
using Day6.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        GenericRepository<Department> _reps;
        public DepartmentController(GenericRepository<Department> _reps)
        {
            this._reps = _reps;   
        }
        [HttpGet] 
        public IActionResult getall()
        {
            List<Department> depts = _reps.selectall();
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
                _reps.add(d);
                _reps.save();
                return Ok(d);
            }
            else return BadRequest(ModelState);
        }

    }
}
