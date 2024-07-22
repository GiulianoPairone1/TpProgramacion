using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repositories
{
    public class RepositoryBase<T> where T : class
    {
        private readonly DbContext _context;

        public RepositoryBase(DbContext dbContext) 
        {
            _context = dbContext;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T? GetById<Tid>(Tid id)
        {
            return _context.Set<T>().Find(new object[] { id });
        }

        public T Add(T entity)

        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }


        public int Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return _context.SaveChanges();

        }


        public int Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            return _context.SaveChanges();

        }

    }
}
