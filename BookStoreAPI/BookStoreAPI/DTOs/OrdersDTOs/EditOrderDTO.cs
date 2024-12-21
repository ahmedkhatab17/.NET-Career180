namespace BookStoreAPI.DTOs.OrdersDTOs
{
    public class EditOrderDTO
    {
        public string Status { get; set; }
        public List<OrderItemDTO> Books { get; set; }
    }
}
