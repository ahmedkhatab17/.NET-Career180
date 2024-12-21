using BookStoreAPI.Models;

namespace BookStoreAPI.Repository
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        BookStoreContext db;
        public GenericRepository(BookStoreContext db)
        {
            this.db = db;
        }

        public List<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public void Add(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void Delete(int id)
        {
            TEntity obj = db.Set<TEntity>().Find(id);
            db.Set<TEntity>().Remove(obj);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
