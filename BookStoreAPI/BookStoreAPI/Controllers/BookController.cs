using AutoMapper;
using BookStoreAPI.DTOs.BooksDTOs;
using BookStoreAPI.UnitOfWork;
using BookStoreAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using BookStoreAPI.Models;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        UnitOfWork.UnitOfWork Unit;
        IMapper mapper;
        public BookController(UnitOfWork.UnitOfWork unitOfWork, IMapper mapper)
        {
            this.Unit = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get all books", Description = "Retrieves a list of all books.")]
        [SwaggerResponse(200, "Returns the list of books.", typeof(List<DisplayBookDTO>))]
        public IActionResult GetAll()
        {
            if (ModelState.IsValid)
            {
                var books = Unit.bookRepository.GetAll();
                var dto = mapper.Map<List<DisplayBookDTO>>(books);
                return Ok(dto);
            }
            else
                return BadRequest(ModelState);
            
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get a book by ID", Description = "Retrieves details of a book using its ID.")]
        [SwaggerResponse(200, "Returns the book details.", typeof(DisplayBookDTO))]
        [SwaggerResponse(404, "No book found with the given ID.")]
        public IActionResult GetById(int id)
        {

            if (ModelState.IsValid)
            {
                var b = Unit.bookRepository.GetById(id);
                if (b == null)
                    return NotFound();

                var dto = mapper.Map<DisplayBookDTO>(b);
                return Ok(dto);
            }
            else
                return BadRequest(ModelState);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        [SwaggerOperation(Summary = "Add a new book", Description = "Adds a new book to the database.")]
        [SwaggerResponse(201, "The book was successfully created.")]
        [SwaggerResponse(400, "Invalid book data.")]
        public IActionResult Add(AddBookDTO dto)
        {
            if (ModelState.IsValid)
            {
                var b = mapper.Map<Book>(dto);
                Unit.bookRepository.Add(b);
                Unit.bookRepository.Save();
                return CreatedAtAction(nameof(GetById), new { Id = b.Id }, null);
            }
            else
                return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "admin")]
        [SwaggerOperation(Summary = "Edit book details", Description = "Updates the details of an existing book.")]
        [SwaggerResponse(204, "The book was successfully updated.")]
        [SwaggerResponse(400, "Invalid book data.")]
        public IActionResult Edit(int id, AddBookDTO dto)
        {
            if (ModelState.IsValid)
            {
                var b = mapper.Map<Book>(dto);
                b.Id = id;
                Unit.bookRepository.Update(b);
                Unit.bookRepository.Save();
                return NoContent();
            }
            else return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        [SwaggerOperation(Summary = "Delete a book", Description = "Removes a book from the database.")]
        [SwaggerResponse(200, "The book was successfully deleted.")]
        [SwaggerResponse(404, "No book found with the given ID.")]
        public IActionResult Delete(int id)
        {
            Unit.bookRepository.Delete(id);
            Unit.bookRepository.Save();
            return Ok();
        }
    }
}
