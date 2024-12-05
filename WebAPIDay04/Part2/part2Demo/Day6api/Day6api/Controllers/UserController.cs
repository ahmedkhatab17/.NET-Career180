using Day6api.DTOs;
using Day6api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Day6api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //usermanager
        //signinmanager
        //rolemanager

        UserManager<IdentityUser> _manger;
        SignInManager<IdentityUser> signmanager;
        public UserController(UserManager<IdentityUser> _manger, SignInManager<IdentityUser> signmanager)
        {
            this._manger = _manger;
            this.signmanager = signmanager;
        }

        [HttpPost]
        public IActionResult register(StudentRegisterDTO st)
        {
            //IdentityUser user=new IdentityUser()
            //{
            //    UserName=st.username,
            //    Email=st.email
            //};
            Student user = new Student()
            {
                UserName = st.username,
                Email = st.email,
                age = st.age,
                year = st.year
            };
          IdentityResult r=  _manger.CreateAsync(user, st.password).Result;
            if (r.Succeeded)
            {
                return Ok();
            }
            else
            {
                return BadRequest(r.Errors);
            }
        }

        [HttpPut]
        public IActionResult login(studentLoginDTO st)
        {
            if (ModelState.IsValid)
            {
                var r = signmanager.PasswordSignInAsync(st.username, st.password, false, false).Result;
                if (r.Succeeded)
                {
                    //valid user
                    //generate JWT tokens....

                    return Ok("token");
                }
                else
                {
                    //invalid user
                    return Unauthorized();
                }


            }
            else
                return BadRequest(ModelState);
        }


        [HttpGet]
        public IActionResult logout()
        {
            signmanager.SignOutAsync();

            //delete token 
            return Ok();
        }
    }
}
