using AutoMapper;
using BookStoreAPI.DTOs.CustomerDTOs;
using BookStoreAPI.Models;
using BookStoreAPI.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        UserManager<IdentityUser> userManager;
        RoleManager<IdentityRole> roleManager;
        IMapper mapper;

        public CustomerController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.mapper = mapper;
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Create a new customer", Description = "Adds a new customer to the system and assigns the 'customer' role.")]
        [SwaggerResponse(200, "Customer created successfully", typeof(AddCustomerDTO))]
        [SwaggerResponse(400, "Invalid customer data or role assignment failed")]
        public IActionResult Create(AddCustomerDTO ctDTO)
        {
            if (ModelState.IsValid)
            {
                Customer ct = mapper.Map<Customer>(ctDTO);
                var rt = userManager.CreateAsync(ct, ctDTO.Password).Result;
                if (rt.Succeeded)
                {
                    IdentityResult ir = userManager.AddToRoleAsync(ct, "customer").Result;
                    if (ir.Succeeded)
                        return Ok(ctDTO);
                    else
                        return BadRequest(ir.Errors);
                }
                else
                    return BadRequest(rt.Errors);
            }
            return BadRequest(ModelState);

        }

        [HttpPut]
        [SwaggerOperation(Summary = "Edit customer profile", Description = "Updates the profile of an existing customer.")]
        [SwaggerResponse(204, "Customer profile updated successfully")]
        [SwaggerResponse(400, "Invalid customer data")]
        [SwaggerResponse(404, "Customer not found")]
        public IActionResult EditProfile(EditCustomerDTO editDTO)
        {
            if (ModelState.IsValid)
            {
                Customer ct = (Customer)userManager.FindByIdAsync(editDTO.Id).Result;
                if (ct == null) return NotFound();
                mapper.Map<EditCustomerDTO>(ct);
                var r = userManager.UpdateAsync(ct).Result;
                if (r.Succeeded)
                    return NoContent();
                else
                    return BadRequest(r.Errors);
            }
            else
                return BadRequest(ModelState);

        }

        [HttpGet("All")]
        [SwaggerOperation(Summary = "Get all customers", Description = "Retrieves a list of all customers.")]
        [SwaggerResponse(200, "Customers retrieved successfully", typeof(List<SelectCustomerDTO>))]
        [SwaggerResponse(404, "No customers found")]
        public IActionResult GetAll()
        {
            if (ModelState.IsValid)
            {
                var users = userManager.GetUsersInRoleAsync("customer").Result.OfType<Customer>().ToList();
                if (!users.Any()) return NotFound();
                var result = mapper.Map<List<SelectCustomerDTO>>(users);
                return Ok(result);
            }
            else return BadRequest(ModelState);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get a customer by ID", Description = "Retrieves a specific customer by their ID.")]
        [SwaggerResponse(200, "Customer retrieved successfully", typeof(SelectCustomerDTO))]
        [SwaggerResponse(404, "Customer not found")]
        public IActionResult GetById(String id)
        {
            if (ModelState.IsValid)
            {
                var ct = (Customer)userManager.GetUsersInRoleAsync("customer").Result.Where(n => n.Id == id).FirstOrDefault();
                if (ct == null) return NotFound();
                var cDTO = mapper.Map<SelectCustomerDTO>(ct);
                return Ok(cDTO);
            }
            else return BadRequest(ModelState);
        }
    } 
}
