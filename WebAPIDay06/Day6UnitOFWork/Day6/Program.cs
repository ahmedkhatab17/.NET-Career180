
using Day6.Models;
using Day6.Repository;
using Day6.Repository.OldClass;
using Day6.UnitOfWorks;
using Microsoft.EntityFrameworkCore;

namespace Day6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<companyContext>(op => op.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("con")));
            //builder.Services.AddScoped<GenericRepository<Employee>>();
            //builder.Services.AddScoped<GenericRepository<Department>>();
            builder.Services.AddScoped<UnitOfWork>();
            
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
