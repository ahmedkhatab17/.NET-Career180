using Day3.DTOs.StudentDTO;
using Day3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class studentsController : ControllerBase
    {
        // learnContext db = new learnContext();
        learnContext db;
        public studentsController(learnContext db)
        {
            this.db = db;
        }


        [HttpGet]
        public IActionResult getall()
        {
            List<Student> sts = db.Students.ToList();
            List<DisplayStudentDTO> stsDTO = new List<DisplayStudentDTO>();
            foreach (Student s in sts) {

                DisplayStudentDTO stDTO = new DisplayStudentDTO()
                {
                    id = s.id,
                    fullname = s.name,
                    age = s.age+1,
                    address = s.address,
                    DepartmentName = s.department.name
                };
                stsDTO.Add(stDTO);
            
            }



            return Ok(stsDTO);
        }
        [HttpGet("{id}")]
        public IActionResult getbyid(int id)
        {
            Student s = db.Students.Where(n => n.id == id).FirstOrDefault();
            if (s == null) return NotFound();
            else
            {
                DisplayStudentDTO sdto = new DisplayStudentDTO()
                {
                    id = s.id,
                    fullname = s.name,
                    age = s.age,
                    address = s.address,
                    DepartmentName = s.department.name
                };


                return Ok(sdto);

            }




        }

        [HttpPost]
        public IActionResult add(AddStudentDTO sdto)
        {
            Student s = new Student()
            {
                name = sdto.fullname,
                age = sdto.age,
                address = sdto.address,
                deptid = sdto.deptid,
            };
            db.Students.Add(s);
            db.SaveChanges();

            return Ok();
        }
    }
}
