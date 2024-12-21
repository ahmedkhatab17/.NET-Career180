using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI.Models
{
    public class BookStoreContext:IdentityDbContext
    {
        public BookStoreContext() { }

        public BookStoreContext(DbContextOptions<BookStoreContext> option) : base(option) { }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }   

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<OrderItems>().HasKey("BookId", "OrderId");
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Name = "admin", NormalizedName = "ADMIN" },
                new IdentityRole() { Name = "customer", NormalizedName = "CUSTOMER" }
                );
        }
    }
}
