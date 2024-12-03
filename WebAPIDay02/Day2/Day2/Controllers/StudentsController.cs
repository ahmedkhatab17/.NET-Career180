using Day2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        CompanyContext db = new CompanyContext();

        [HttpGet]
        public ActionResult getall()
        {
            List<Student> sts= db.Students.ToList();
            if (sts.Count > 0)
                return Ok(sts);
            else
                return NotFound();
        }
        [HttpGet("{id:int}")]
        public IActionResult getbyid(int id)
        {
            Student s= db.Students.Where(n => n.ID == id).FirstOrDefault();
            if (s == null)
                return NotFound();//404
            else
                return Ok(s);//200+student
        }
       // [HttpGet("/api/sts/{name}")]
        [HttpGet("{name}")]
        public IActionResult getbyname(string name)
        {
            Student s = db.Students.Where(n => n.name == name).FirstOrDefault();
            if (s == null)
                return NotFound();//404
            else
                return Ok(s);//200+student
        }

        [HttpPost]
        public IActionResult add(Student s)
        {
            if(s==null) return BadRequest();
            db.Students.Add(s);
            db.SaveChanges();
            return CreatedAtAction("getbyid", new {id=s.ID}, s);
        //    return Created($"https://localhost:7203/api/students/{s.ID}", s);
        }

        [HttpPut("{id}")]
        public IActionResult edit(int id ,Student s)
        {
            if(s==null) return BadRequest();
            if(id != s.ID) return BadRequest();
          db.Entry(s).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //Student st = db.Students.Where(n => n.ID == s.ID).SingleOrDefault();
            //st.name = s.name;
            //st.age = s.age; 
            //st.adddress=s.adddress;
            //st.deptid = s.deptid;

            db.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            Student s = db.Students.Where(n => n.ID == id).FirstOrDefault();
            if (s == null) return NotFound();
            db.Students.Remove(s);
            db.SaveChanges();
            return Ok(s);
        }



    }
}
