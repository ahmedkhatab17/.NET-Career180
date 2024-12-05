using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Day6api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userroleController : ControllerBase
    {
        RoleManager<IdentityRole> roleManager;
        UserManager<IdentityUser> userManager;

        public userroleController(UserManager<IdentityUser> userManager , RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [HttpGet("{rolename}")]
        public IActionResult addrole(string rolename)
        {
            IdentityRole role = new IdentityRole(rolename);
          var r=  roleManager.CreateAsync(role).Result;
            if (r.Succeeded) return Ok();
            else return BadRequest(r.Errors);
        }

        [HttpGet("{username}/{rolename}")]
        public IActionResult addusertorole(string username , string rolename)
        {
          IdentityUser user=  userManager.FindByNameAsync(username).Result;

          var r=  userManager.AddToRoleAsync(user, rolename).Result;
            if (r.Succeeded) return Ok();
            else return BadRequest(r.Errors);
        }

        [HttpGet]
        public IActionResult userroles(string username)
        {
            IdentityUser user = userManager.FindByNameAsync(username).Result;
           var userroles= userManager.GetRolesAsync(user).Result;
            if (userroles != null) return Ok(userroles);
            else return NotFound();
        }

    }
}
