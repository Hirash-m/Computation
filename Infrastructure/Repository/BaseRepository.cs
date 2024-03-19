using Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace Infrastructure.Repository
{
    public class BaseRepository<T, TKey> : IRepository<T, TKey> where T : class
    {
        private readonly DbContext context;

        public BaseRepository(DbContext context)
        {
            this.context = context;
        }
        public void Create(T entity)
        {
            context.Add(entity);
        }

        public void Delete(T entity)
        {
            context.Remove(entity);
        }

        public void DeleteAll(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(TKey id)
        {
            var entity = Get(id);

            Delete(entity);
        }

        public bool Exist(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Any(expression);
        }

        public bool ExistById(TKey id)
        {
            
            var entity = context.Set<T>().Find(id);

            
            if (entity != null)
            {
                return true;
            }

            
            return false;
        }

      

        public T Get(TKey id)
        {
            return context.Find<T>(id);
        }

        public List<T> Get()
        {
            return context.Set<T>().ToList();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }



    }

}
