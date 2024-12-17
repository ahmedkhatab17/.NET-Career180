using Day6.Models;
using Microsoft.EntityFrameworkCore;

namespace Day6.Repository
{
    public class EmployeeRepository
    {
        public EmployeeRepository(companyContext db)
        {
            Db = db;
        }

        public companyContext Db { get; }


        //select all
        public List<Employee> selectall()
        {
            return Db.Employees.Include(n => n.dept).ToList();
        }



        //select by id

        public Employee selectbyid(int id)
        {
           return Db.Employees.Include(n => n.dept).FirstOrDefault(n => n.id == id);
           
        }


        //addd
        public void add (Employee emp)
        {
            Db.Employees.Add(emp);
            Db.SaveChanges();
        }



        //edit
        public void edit(Employee emp)
        {
            Db.Entry(emp).State = EntityState.Modified;
            Db.SaveChanges();

        }



        //delete

        public void delete(int id)
        {
            Employee emp=selectbyid(id);
            Db.Employees.Remove(emp);
            Db.SaveChanges();
        }
    }
}
