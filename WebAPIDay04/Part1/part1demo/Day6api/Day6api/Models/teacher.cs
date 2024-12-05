using Microsoft.AspNetCore.Identity;

namespace Day6api.Models
{
    public class teacher:IdentityUser
    {
        public int teacherid { get; set; }
        public DateTime hiredate { get; set; }
        public string title { get; set; }
    }
}
