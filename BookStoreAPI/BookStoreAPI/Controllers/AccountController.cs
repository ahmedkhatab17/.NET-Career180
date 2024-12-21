using BookStoreAPI.DTOs.AccountDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Annotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        SignInManager<IdentityUser> signIn;
        UserManager<IdentityUser> userManager;

        public AccountController(SignInManager<IdentityUser> signIn, UserManager<IdentityUser> userManager)
        {
            this.signIn = signIn;
            this.userManager = userManager;
        }


        [HttpPost("Login")]
        [SwaggerOperation(Summary = "Log in a user", Description = "Authenticates a user and returns a JWT token if login is successful.")]
        [SwaggerResponse(200, "Login successful. Returns a JWT token.", typeof(string))]
        [SwaggerResponse(401, "Invalid username or password.")]
        public IActionResult Login(LoginDTO loginDTO)
        {
            var r = signIn.PasswordSignInAsync(loginDTO.Username, loginDTO.Password, false, false).Result;
            if (r.Succeeded)
            {
                var user = userManager.FindByNameAsync(loginDTO.Username).Result;

                List<Claim> userdata = new List<Claim>();
                userdata.Add(new Claim(ClaimTypes.Name, user.UserName));
                userdata.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));

                var roles = userManager.GetRolesAsync(user).Result;
                foreach (var role in roles)
                {
                    userdata.Add(new Claim(ClaimTypes.Role, role));
                }

                string key = "welcome to my secret key Ahmed Khatab";
                var secertkey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key));

                var signingcer = new SigningCredentials(secertkey, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    claims: userdata,
                    signingCredentials: signingcer,
                    expires: DateTime.Now.AddDays(2)
                    );

                var tokenstring = new JwtSecurityTokenHandler().WriteToken(token);
                return Ok(tokenstring);
            }
            else 
                return Unauthorized("InValid Username Or Password");

        }

        [HttpGet("Logout")]
        [Authorize]
        [SwaggerOperation(Summary = "Log out a user", Description = "Logs out the currently authenticated user.")]
        [SwaggerResponse(200, "Logout successful.")]
        public IActionResult Logout()
        {
            signIn.SignOutAsync();
            return Ok();
        }
    }
}
