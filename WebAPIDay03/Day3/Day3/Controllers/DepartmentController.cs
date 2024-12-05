using Day3.DTOs.DEpartmentDTO;
using Day3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        learnContext db;
        public DepartmentController(learnContext db)
        {
            this.db = db;
        }

        [HttpGet("{id}")]
        public IActionResult getbyid(int id) { 
        
        Department d= db.Departments.Where(n=>n.id==id).FirstOrDefault();
            if (d==null) return NotFound();
            else
            {
                DisplayDeptDTO dDTO = new DisplayDeptDTO()
                {
                    id = d.id,
                    name = d.name,
                    location = d.location,
                    studentsname = d.Students.Select(n => n.name).ToList()
                };
                //foreach (var item in d.Students)
                //{
                //    dDTO.studentsname.Add(item.name);
                //}
                return Ok(dDTO);
            }
        
        
        }
    }
}
