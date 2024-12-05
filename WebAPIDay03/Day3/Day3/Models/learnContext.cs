using Microsoft.EntityFrameworkCore;

namespace Day3.Models
{
    public class learnContext:DbContext
    {
        public learnContext()
        {
                
        }
        public learnContext(DbContextOptions<learnContext> option):base(option)
        {
            
        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-JP4B1RU;Database=testapi;Trusted_Connection=True;TrustServerCertificate=True;");
        //}
    }
}
