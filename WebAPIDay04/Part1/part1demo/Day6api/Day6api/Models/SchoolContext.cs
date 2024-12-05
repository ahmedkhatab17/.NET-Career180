using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Day6api.Models
{
    public class SchoolContext:IdentityDbContext
    {
        public SchoolContext()
        {
                
        }

        public SchoolContext(DbContextOptions<SchoolContext> option):base(option)
        {
            
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<teacher> Teachers { get; set; }
        public virtual DbSet<parent> Parents { get; set; }
    }
}
