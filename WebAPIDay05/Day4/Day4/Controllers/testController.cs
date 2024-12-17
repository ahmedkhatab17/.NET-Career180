using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //testing model binner
    public class testController : ControllerBase
    {


        //[HttpGet("{id}")] //route data
        ////[HttpGet]
        // public IActionResult get( [FromQuery]int id , string name, int age)
        // {
        //     return Ok(id);
        // }
        //[HttpGet]
        //public IActionResult getall()
        //{
        //    return Ok();
        //}
        //[HttpGet]
        //public IActionResult gatall()
        //{

        //}

        [HttpPost]
        public IActionResult upload(IFormFile file)
        {

            //path  =>upload folder path + file name +file exetination

            string path = $"{Directory.GetCurrentDirectory()}\\Uploads\\{file.FileName}";
            FileStream st = new FileStream(path, FileMode.Create);
            file.CopyTo(st);


            //Save path in db 
            return Ok();
        }

        
    }
}
