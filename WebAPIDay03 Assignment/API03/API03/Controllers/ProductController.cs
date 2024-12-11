using API03.DTOs;
using API03.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        CompanyContext db;

        public ProductController(CompanyContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> Products = db.Products.ToList();
            List<DisplayProductDTO> productsDTO = new List<DisplayProductDTO>();
            foreach (Product p in Products)
            {
                DisplayProductDTO productDTO = new DisplayProductDTO()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Quantity = p.Quantity,
                    CatalogName = p.Catalog?.Name ?? "No Catalog"
                };
                productsDTO.Add(productDTO);
            }
            return Ok(productsDTO);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Product product = db.Products.Where(p => p.Id == id).FirstOrDefault();
            if (product == null) return NotFound();
            else
            {
                DisplayProductDTO productDTO = new DisplayProductDTO
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = product.Quantity,
                    CatalogName = product.Catalog?.Name ?? "No Catalog"
                };

                return Ok(productDTO);
            }
        }

        
    }
}
