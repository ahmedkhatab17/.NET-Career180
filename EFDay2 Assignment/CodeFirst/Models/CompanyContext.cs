using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;


namespace CodeFirst.Models
{
    public class CompanyContext : DbContext
    {
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Catalog> Catalog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=AHMED-KHATAB\\SQLEXPRESS; Database=EFDay2;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().HasData(
                new News
                {
                    Id = 1,
                    Title = "AI Revolution",
                    Bref = "How AI is reshaping industries",
                    Desc = "A deep dive into the advancements of Artificial Intelligence and its impact on the world.",
                    DateTime = DateTime.Now,
                    CataId = 1,
                    AuthId = 2
                },
                new News
                {
                    Id = 2,
                    Title = "Healthy Living Tips",
                    Bref = "Your guide to a healthier lifestyle",
                    Desc = "Discover essential tips and tricks to improve your health and well-being.",
                    DateTime = DateTime.Now,
                    CataId = 2,
                    AuthId = 1
                },
                new News
                {
                    Id = 3,
                    Title = "Economic Growth in 2024",
                    Bref = "Key factors driving global economic growth",
                    Desc = "An analysis of the factors shaping the global economy in the coming year.",
                    DateTime = DateTime.Now,
                    CataId = 3,
                    AuthId = 3
                }
            );

            modelBuilder.Entity<Catalog>().HasData(
                new Catalog { Id = 1, Name = "Technology", Desc = "Latest in technology and innovations" },
                new Catalog { Id = 2, Name = "Health", Desc = "Health and wellness tips" },
                new Catalog { Id = 3, Name = "Business", Desc = "Latest trends in business and economy" }
            );

            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "Ahmed Khattab", JoinDate = DateTime.Now, Username = "ahmed_khatab", Password = "pass123", Bref = "Health Specialist" },
                new Author { Id = 2, Name = "Omar Khatab", JoinDate = DateTime.Now, Username = "omar_khatab", Password = "pass123", Bref = "Technology Enthusiast" },
                new Author { Id = 3, Name = "Sara Ali", JoinDate = DateTime.Now, Username = "sara_ali", Password = "pass123", Bref = "Business Consultant" }
            );
        }


    }
}
