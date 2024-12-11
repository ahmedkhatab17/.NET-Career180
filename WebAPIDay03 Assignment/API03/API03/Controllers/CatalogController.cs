using API03.DTOs;
using API03.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        CompanyContext db;

        public CatalogController(CompanyContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Catalog> Catalogs = db.Catalogs.ToList();
            List<DisplayCatalogDTO> CatalogsDTO = new List<DisplayCatalogDTO>();
            foreach (Catalog c in Catalogs)
            {
                DisplayCatalogDTO CatalogDTO = new DisplayCatalogDTO()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    Product = c.ProductName.Select(p => p.Name).ToList()
                };
                CatalogsDTO.Add(CatalogDTO);
            }
            return Ok(CatalogsDTO);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Catalog c = db.Catalogs.Where(n => n.Id == id).FirstOrDefault();
            if (c == null) return NotFound();
            else
            {
                DisplayCatalogDTO catalogDTO = new DisplayCatalogDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    Product = c.ProductName.Select(p => p.Name).ToList()
                };

                return Ok(catalogDTO);
            }
        }
    }
}
