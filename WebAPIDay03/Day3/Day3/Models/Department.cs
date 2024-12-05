namespace Day3.Models
{
    public class Department
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public virtual List<Student> Students { get; set; } = new List<Student>();
    }
}
