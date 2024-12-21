using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreAPI.DTOs.BooksDTOs
{
    public class AddBookDTO
    {
        public string Title { get; set; }
        [Range(20,1000 , ErrorMessage = "Invalid price ,price must between 20 and 1000")]
        public decimal Price { get; set; }
        [Range(1,500 , ErrorMessage = "Invalid stock number")]
        public int Stock { get; set; }
        [Column(TypeName ="date")]
        public DateOnly PublishedDate { get; set; }
        public int? AuthorId { get; set; }
        public int? CatalogId { get; set; }


    }
}
