using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay2.Models
{
    public class CompanyContext:DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Workfor> Worksfor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=AHMED-KHATAB\\SQLEXPRESS; Database=CodeFirtComapny;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().Property<string>("username").IsRequired();
            modelBuilder.Entity<Workfor>().HasKey("emp_id", "proj_id");

            modelBuilder.Entity<Department>().HasData(
                new Department() { deptid = 1, deptname = "dotnet", desc = "dotnet" },
                new Department() { deptid = 2, deptname = "php", desc = "php" },
                new Department() { deptid = 3, deptname = "flutter", desc = "flutter" });


            modelBuilder.Entity<Employee>().HasData(
                 new Employee() { id=3, fullname="ali ahmed",username="ali",password="123",hiredate=new DateTime(2005,05,05),salary=12000,dept_id=2},
                 new Employee() { id = 1, fullname ="mostafa mohamed",username="mostafa",password="123",hiredate=new DateTime(2005,05,05),salary=12000,dept_id=1},
                 new Employee() { id = 2, fullname ="ola ahmed",username="ola",password="123",hiredate=new DateTime(2005,05,05),salary=12000,dept_id=1}
                );
        }
    }
}
