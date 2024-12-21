using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }
        [Column(TypeName ="date")]
        public DateTime OrderDate { get; set; }
        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }
        public string CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual List<OrderItems> OrderItems { get; set; } = new List<OrderItems>();

    }
}
