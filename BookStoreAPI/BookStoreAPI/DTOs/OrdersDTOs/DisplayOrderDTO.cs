namespace BookStoreAPI.DTOs.OrdersDTOs
{
    public class DisplayOrderDTO
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string CustomerId { get; set; }
        public List<DisplayOrderItemsDTO> OrderItems { get; set; }
    }
}
