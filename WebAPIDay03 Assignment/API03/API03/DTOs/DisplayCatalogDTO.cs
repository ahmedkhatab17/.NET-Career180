namespace API03.DTOs
{
    public class DisplayCatalogDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Product { get; set; } = new List<string>();
    }
}
