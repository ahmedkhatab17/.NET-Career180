using Microsoft.AspNetCore.Identity;

namespace Day6api.Models
{
    public class Student:IdentityUser
    {
        public string fullname { get; set; }
        public int age { get; set; }
        public int year { get; set; }
    }
}
