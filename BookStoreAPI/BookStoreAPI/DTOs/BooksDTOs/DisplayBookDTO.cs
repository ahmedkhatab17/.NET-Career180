using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BookStoreAPI.DTOs.BooksDTOs
{
    public class DisplayBookDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [JsonIgnore]
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public DateOnly Publishdate { get; set; }

        public string Authorname { get; set; }
        public string Catalog { get; set; }
    }
}
