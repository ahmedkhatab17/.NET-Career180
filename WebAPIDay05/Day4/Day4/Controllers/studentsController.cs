using Day4.DTOs.StudentDTO;
using Day4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class studentsController : ControllerBase
    {
      
        public studentsController(CompanyContext db)
        {
            Db = db;
        }

        public CompanyContext Db { get; }


        [HttpPost] 
        public IActionResult add(addstudentDTO sdto)
        {
            if (ModelState.IsValid)
            {
                Student s = new Student()
                {
                    name = sdto.name,
                    age = sdto.age,
                    adddress = sdto.address,
                    deptid = sdto.deptid,
                };
                Db.Students.Add(s);
                Db.SaveChanges();
                return Ok(Db.Students.ToList());
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        //[HttpGet("{id}")]
        //public ActionResult<Student> getbyid(int id)

        //}

    }
}
