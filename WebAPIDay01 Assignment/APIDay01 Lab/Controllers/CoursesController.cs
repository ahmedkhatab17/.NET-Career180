using APIDay01_Lab.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIDay01_Lab.Controllers
{
    [Route("api/courses")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        static List<Course> courses = new List<Course>()
        {
            new Course() { Id = 1, Name = "CSS", Duration = 40 },
            new Course() { Id = 2, Name = "HTML", Duration = 60 },
            new Course() { Id = 3, Name = ".NET", Duration = 120 },
        };

        [HttpGet]
        public List<Course> GetAll()
        {
            return courses;
        }

        [HttpGet("{name}")]
        public Course GetByName(string name)
        {
            return courses.Find(s => s.Name == name);
        }

        [HttpPost]
        public List<Course> Add(Course course)
        {
            courses.Add(course);
            return courses;
        }
    }
}
