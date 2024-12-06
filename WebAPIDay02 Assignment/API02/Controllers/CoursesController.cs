using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API02.Models;

namespace API02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        CoursesContext db = new CoursesContext();

        [HttpGet]
        public ActionResult get()
        {
            var courses = db.Courses.ToList();
            if (courses.Count > 0)
                return Ok(courses);
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult deleteCourse(int id)
        {
            var course = db.Courses.FirstOrDefault(c => c.Id == id);
            if (course == null)
                return NotFound();

            db.Courses.Remove(course);
            db.SaveChanges();

            return Ok(course);
        }

        [HttpPut("{id}")]
        public ActionResult put(int id, Course Upcourse)
        {
            if (id != Upcourse.Id)
                return BadRequest();

            var existingCourse = db.Courses.FirstOrDefault(c => c.Id == id);
            if (existingCourse == null)
                return NotFound();

            existingCourse.Name = Upcourse.Name;
            existingCourse.Description = Upcourse.Description;
            existingCourse.Duration = Upcourse.Duration;

            db.SaveChanges();

            return NoContent();
        }

        [HttpPost]
        public ActionResult post(Course newCourse)
        {
            if (newCourse == null) return BadRequest();

            db.Courses.Add(newCourse);
            db.SaveChanges();

            return CreatedAtAction(nameof(getById), new { id = newCourse.Id }, newCourse);
        }

        [HttpGet("{id:int}")]
        public IActionResult getById(int id)
        {
            var course = db.Courses.FirstOrDefault(c => c.Id == id);
            if (course == null)
                return NotFound();

            return Ok(course);
        }

        [HttpGet("name/{name}")]
        public IActionResult couseByName(string name)
        {
            var course = db.Courses.FirstOrDefault(c => c.Name.ToLower() == name.ToLower());
            if (course == null)
                return NotFound();

            return Ok(course);
        }
    }
}
