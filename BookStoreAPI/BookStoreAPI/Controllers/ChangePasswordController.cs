using BookStoreAPI.DTOs.CustomerDTOs;
using BookStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChangePasswordController : ControllerBase
    {
        UserManager<IdentityUser> userManager;
        public ChangePasswordController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpPost("ChangePassword")]
        [SwaggerOperation(Summary = "Change a user's password", Description = "Allows a user to change their password by providing their ID, old password, and new password.")]
        [SwaggerResponse(200, "Password was successfully changed.")]
        [SwaggerResponse(400, "Invalid input or errors encountered while changing the password.")]
        public IActionResult ChangePassword(ChangePasswordDTO chDTO)
        {
            if (ModelState.IsValid)
            {
                var ct = userManager.FindByIdAsync(chDTO.Id).Result;
                var r = userManager.ChangePasswordAsync(ct, chDTO.OldPassword, chDTO.NewPassword).Result;
                if (r.Succeeded)
                    return Ok();
                else
                    return BadRequest(r.Errors);
            }
            else
                return BadRequest(ModelState);
        }

    }
}
