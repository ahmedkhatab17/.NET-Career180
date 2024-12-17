using Lab4.Models;

namespace Lab4.Repository
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        public CompanyContext Db { get; }

        public GenericRepository(CompanyContext db)
        {
            Db = db;
        }

        public List<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Add(TEntity entity)
        {
            Db.Set<TEntity>().Add(entity);
        }

        public void Edit(TEntity entity)
        {
            Db.Entry(entity).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Delete(int id)
        {
            Db.Remove(id);
        }

        //public void Save()
        //{
        //    Db.SaveChanges();
        //}

    }
}
