namespace BookStoreAPI.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FulName { get; set; }
        public string Bio { get; set; }
        public int NumOfBooks { get; set; }
        public int Age { get; set; }

        public virtual List<Book> Books { get; set; } = new List<Book>();
        
        
    }
}
