using Microsoft.EntityFrameworkCore;
namespace Lab4.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        
    }
}
