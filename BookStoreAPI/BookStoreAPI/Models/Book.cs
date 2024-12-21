using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [ForeignKey("author")]
        public int AuthorId { get; set; }
        [Column(TypeName ="money")]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        [Column(TypeName ="date")]
        public DateOnly PublishedDate { get; set; }
        [ForeignKey("catalog")]
        public int? CatalogId { get; set; }
        public virtual Catalog? Catalog { get; set; }
        public virtual Author? Author { get; set; }
        public virtual List<OrderItems> OrderItems { get; set; }


    }
}
