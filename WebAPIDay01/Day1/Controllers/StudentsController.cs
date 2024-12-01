using Day1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        static List<student> mystudents = new List<student>()
        {
            new student(){id=1 , name="ali",age=22,address="cairo"},
            new student(){id=3 , name="ola",age=25,address="cairo"},
            new student(){id=6 , name="mona",age=22,address="alex"},
            new student(){id=8 , name="mohamed",age=30,address="tanta"},
        };

        [HttpGet]//httpget+"api/students"
        //[Route("api/students")]
        public List<student> getall()
        {
            return mystudents;
        }
        //[HttpGet]
        //[Route("api/students/{id}")]
       // [HttpGet("api/students/{id}")]
        [HttpGet("{id}")]//httpget+"api/students/2"
        public student getbyid(int id)
        {
            return mystudents.Find(n=>n.id==id);
        }

        [HttpPost]//httppost+"api/students"
        public List<student> add(student s)
        {
            mystudents.Add(s);
            return mystudents;
        }

    }
}
