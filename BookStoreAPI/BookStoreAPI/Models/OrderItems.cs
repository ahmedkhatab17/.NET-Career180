using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreAPI.Models
{
    public class OrderItems
    {
        [ForeignKey("order")]
        public int OrderId { get; set; }
        [ForeignKey("book")]
        public int BookId { get; set; }
        public int Quntity { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        public virtual Order Order { get; set; }
        public virtual Book Book { get; set; }
    }
}
