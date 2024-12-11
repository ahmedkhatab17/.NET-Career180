using Microsoft.EntityFrameworkCore;

namespace API03.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext() { }

        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) { }

        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<Product> Products { get; set; }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=AHMED-KHATAB\\SQLEXPRESS;Database=APIDay03;Trusted_Connection=True;TrustServerCertificate=True;");
        //}
    }
}
