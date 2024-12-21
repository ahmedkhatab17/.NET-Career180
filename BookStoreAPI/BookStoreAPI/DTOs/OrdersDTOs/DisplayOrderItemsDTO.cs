namespace BookStoreAPI.DTOs.OrdersDTOs
{
    public class DisplayOrderItemsDTO
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quntity { get; set; }
    }
}
