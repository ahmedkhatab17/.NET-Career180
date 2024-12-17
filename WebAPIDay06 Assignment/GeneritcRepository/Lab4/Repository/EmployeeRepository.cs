using Lab4.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Repository
{
    public class EmployeeRepository
    {
        public EmployeeRepository( CompanyContext db)
        {
            Db = db;
        }
        public CompanyContext Db { get; }

        public List<Employee> GetAll()
        {
            return Db.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return Db.Employees.SingleOrDefault(n => n.Id == id);
        }

        public void Add(Employee emp)
        {
            Db.Employees.Add(emp);
            Db.SaveChanges();
        }
    }
}
