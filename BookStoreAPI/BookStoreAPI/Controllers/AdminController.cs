using AutoMapper;
using BookStoreAPI.DTOs.AdminDTOs;
using BookStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        UserManager<IdentityUser> userManager;
        RoleManager<IdentityRole> roleManager;

        public AdminController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Create a new admin", Description = "Creates a new admin user and assigns them the 'admin' role.")]
        [SwaggerResponse(200, "Admin created successfully", typeof(AddAdminDTO))]
        [SwaggerResponse(400, "Invalid admin data or role assignment failed")]
        public IActionResult Create(AddAdminDTO dto)
        {
            if (ModelState.IsValid)
            {
                Admin admin = new Admin()
                {
                    Email = dto.Email,
                    UserName = dto.Username,
                    PhoneNumber = dto.PhoneNumber
                };
                var rt = userManager.CreateAsync(admin, dto.Password).Result;
                if (rt.Succeeded)
                {
                    IdentityResult ir = userManager.AddToRoleAsync(admin, "admin").Result;
                    if (ir.Succeeded)
                        return Ok(dto);
                    else
                        return BadRequest(ir.Errors);
                }
                else
                    return BadRequest(rt.Errors);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Check admin authentication", Description = "Checks if the current user is authenticated as an admin.")]
        [SwaggerResponse(200, "User is authenticated as admin")]
        [SwaggerResponse(401, "User is not authenticated")]
        public IActionResult Get()
        {
            if(User.Identity.IsAuthenticated) 
                return Ok();
            else
                return Unauthorized();
        }






    }
}
