using Day6.Models;

namespace Day6.Repository
{
    public class GenericRepository<TEntity> where TEntity:class
    {
        public companyContext Db { get; }

        public GenericRepository(companyContext db)
        {
            Db = db;
        }

        public List<TEntity> selectall()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity selectbyid(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void add(TEntity entity) { 
            Db.Set<TEntity>().Add(entity);
           // Db.SaveChanges();
        }


        public void edit (TEntity entity)
        {
            Db.Entry(entity).State= Microsoft.EntityFrameworkCore.EntityState.Modified;
            //Db.SaveChanges();
        }

        public void delete(int id) { 
        TEntity entity=selectbyid(id);
            Db.Set<TEntity>().Remove(entity);
//Db.SaveChanges();
        
        
        }

        public void save()
        {
            Db.SaveChanges();
        }


    }
}
