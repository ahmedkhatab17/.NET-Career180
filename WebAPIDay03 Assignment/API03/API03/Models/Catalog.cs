namespace API03.Models
{
    public class Catalog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<Product> ProductName { get; set; } = new List<Product>();
    }
}
