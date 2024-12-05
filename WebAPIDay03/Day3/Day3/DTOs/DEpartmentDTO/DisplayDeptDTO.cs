namespace Day3.DTOs.DEpartmentDTO
{
    public class DisplayDeptDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public List<string> studentsname { get; set; } = new List<string>();
    }
}
