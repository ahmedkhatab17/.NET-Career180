namespace BookStoreAPI.DTOs.OrdersDTOs
{
    public class AddOrderDTO
    {
        public string CustomerId { get; set; }
        public List<OrderItemDTO> Books { get; set; } = new List<OrderItemDTO>();
    }
}
