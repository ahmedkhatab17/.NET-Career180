using Day6.Models;
using Day6.Repository;

namespace Day6.UnitOfWorks
{
    public class UnitOfWork
    {
        GenericRepository<Employee> _empreps;
        GenericRepository<Department> _deptrep;
        GenericRepository<Project> _projreps;
        companyContext db;
        public UnitOfWork(companyContext db)
        {
            this.db = db;

           
            //_deptrep = new GenericRepository<Department>(db);
            //_projreps = new GenericRepository<Project>(db);
        }

        public GenericRepository<Employee> empreps
        { 
            get {
                if(_empreps == null)
                _empreps = new GenericRepository<Employee>(db);

                 return _empreps;
            }
        
        }

        public GenericRepository<Department> deptrep { get { 
            
            if(_deptrep == null)
                    _deptrep = new GenericRepository<Department>(db);

            return _deptrep;


            } }
        public void save()
        {
            db.SaveChanges();
        }
    }
}
