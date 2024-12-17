using Lab4.Models;
using Lab4.Repository;

namespace Lab4.Repository
{
    public class UnitOfWork
    {

        CompanyContext db;
        GenericRepository<Employee> _empreps;

        public UnitOfWork(CompanyContext db)
        {
            this.db = db;
        }

        public GenericRepository<Employee> empreps { 
            get
            {
                if (_empreps == null)
                    _empreps = new GenericRepository<Employee>(db);
                
                return _empreps;
            }
        }

        public void Save()
        {
            db.SaveChanges ();
        }

    }
}
